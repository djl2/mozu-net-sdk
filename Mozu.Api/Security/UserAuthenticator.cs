using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Mozu.Api.Contracts.AdminUser;
using Mozu.Api.Contracts.Core;
using Mozu.Api.Urls.Platform.Adminuser;
using Mozu.Api.Urls.Platform.Developer;
using Mozu.Api.Urls.Platform.User;
using Mozu.Api.Utilities;
using Newtonsoft.Json;

namespace Mozu.Api.Security
{

    public class Scope
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum UserScope
    {
        Tenant,
        Shopper,
        Developer
    }


    public class AuthenticationProfile
    {
        public AuthTicket AuthTicket { get; set; }
        public List<Scope> AuthorizedScopes { get; set; }
        public Scope ActiveScope { get; set; }
        public UserProfile User { get; set; }
    }

    public class AuthTicket : Contracts.AppDev.AuthTicket
    {
        public UserScope Scope { get; set; }
    }


    public class UserAuthenticator 
    {

        public static AuthenticationProfile SetActiveScope(AuthTicket authTicket, Scope scope)
        {
            return RefreshUserAuthTicket(authTicket, scope.Id);
        }

        public static AuthenticationProfile EnsureAuthTicket(AuthTicket authTicket)
        {
            if (DateTime.UtcNow >= authTicket.AccessTokenExpiration.AddSeconds(-180))
               return RefreshUserAuthTicket(authTicket);

            return null;
        }

        public static AuthenticationProfile RefreshUserAuthTicket(AuthTicket authTicket, int? id = null)
        {

            var resourceUrl = GetResourceRefreshUrl(authTicket, id);

            var client = new HttpClient { BaseAddress = new Uri(AppAuthenticator.Instance.BaseUrl) };
            AppAuthenticator.AddHeader(client);


            var stringContent = JsonConvert.SerializeObject(authTicket);
            var response = client.PutAsync(resourceUrl, new StringContent(stringContent, Encoding.UTF8, "application/json")).Result;
            ResponseHelper.EnsureSuccess(response);

           var userInfo = SetUserAuth(response.Content.ReadAsStringAsync().Result, authTicket.Scope);

            return userInfo;
        }

        public static AuthenticationProfile Authenticate(UserAuthInfo userAuthInfo, UserScope scope, int? id = null)
        {
            var resourceUrl = GetResourceUrl(scope, id); 

            var client = new HttpClient { BaseAddress = new Uri(AppAuthenticator.Instance.BaseUrl) };

            var stringContent = JsonConvert.SerializeObject(userAuthInfo);

            AppAuthenticator.AddHeader(client);

            var response = client.PostAsync(resourceUrl, new StringContent(stringContent, Encoding.UTF8, "application/json")).Result;
            ResponseHelper.EnsureSuccess(response);

            return SetUserAuth(response.Content.ReadAsStringAsync().Result, scope);
        }

        public static void Logout(AuthTicket authTicket)
        {
            var url = GetLogoutUrl(authTicket);
            var client = new HttpClient { BaseAddress = new Uri(AppAuthenticator.Instance.BaseUrl) };

            AppAuthenticator.AddHeader(client);

            var response = client.DeleteAsync(url).Result;
            ResponseHelper.EnsureSuccess(response);
        }

        private static AuthenticationProfile SetUserAuth(string response, UserScope scope)
        {
            var authenticationProfile = new AuthenticationProfile();

            authenticationProfile.AuthTicket = JsonConvert.DeserializeObject<AuthTicket>(response);
            authenticationProfile.AuthTicket.Scope = scope;

            switch (scope)
            {
                case UserScope.Tenant:
                    var tenantAdminUserAuthTicket = JsonConvert.DeserializeObject<TenantAdminUserAuthTicket>(response);
                    authenticationProfile.User = tenantAdminUserAuthTicket.User;
                    authenticationProfile.AuthorizedScopes = (from t in tenantAdminUserAuthTicket.AvailableTenants select new Scope { Id = t.Id, Name = t.Name }).ToList();
                    if (tenantAdminUserAuthTicket.Tenant != null)
                        authenticationProfile.ActiveScope = new Scope { Id = tenantAdminUserAuthTicket.Tenant.Id, Name = tenantAdminUserAuthTicket.Tenant.Name };
                    break;
                case UserScope.Developer:
                    var devAccount = JsonConvert.DeserializeObject<DeveloperAdminUserAuthTicket>(response);
                    authenticationProfile.User = devAccount.User;
                    authenticationProfile.AuthorizedScopes = (from t in devAccount.AvailableAccounts select new Scope { Id = t.Id, Name = t.Name }).ToList();
                    if (devAccount.Account != null)
                        authenticationProfile.ActiveScope = new Scope { Id = devAccount.Account.Id, Name = devAccount.Account.Name };
                    break;
                case UserScope.Shopper:
                    var userAccount = JsonConvert.DeserializeObject<UserAuthTicket>(response);
                    authenticationProfile.User = userAccount.User;
                    break;
            }

            return authenticationProfile;
        }

        private static string GetResourceRefreshUrl(AuthTicket authTicket, int? id = null)
        {
            switch (authTicket.Scope)
            {
                case UserScope.Tenant:
                    return TenantAdminUserAuthTicketUrl.RefreshAuthTicketUrl(id).Url;
                case UserScope.Shopper:
                    return UserAuthTicketUrl.RefreshUserAuthTicketUrl(authTicket.RefreshToken).Url;
                case UserScope.Developer:
                    return DeveloperAdminUserAuthTicketUrl.RefreshDeveloperAuthTicketUrl(id).Url;
                default:
                    throw new NotImplementedException();
            }
        }

        private static string GetResourceUrl(UserScope scope, int? id = null)
        {
            switch (scope)
            {
                case UserScope.Tenant:
                    return TenantAdminUserAuthTicketUrl.CreateUserAuthTicketUrl(id).Url; 
                case UserScope.Shopper:
                    return UserAuthTicketUrl.CreateUserAuthTicketUrl().Url;
                case UserScope.Developer:
                    return DeveloperAdminUserAuthTicketUrl.CreateDeveloperUserAuthTicketUrl(id).Url;
                default:
                    throw new NotImplementedException();
            }
        }
        
        private static string GetLogoutUrl(AuthTicket ticket)
        {
            switch (ticket.Scope)
            {
                case UserScope.Tenant:
                    return TenantAdminUserAuthTicketUrl.DeleteUserAuthTicketUrl(ticket.RefreshToken).Url;
                case UserScope.Developer:
                    return DeveloperAdminUserAuthTicketUrl.DeleteUserAuthTicketUrl(ticket.RefreshToken).Url;
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
