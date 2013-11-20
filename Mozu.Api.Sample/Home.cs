using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mozu.Api.Contracts.AppDev;
using Mozu.Api.Contracts.Core;
using Mozu.Api.Contracts.Tenant;
using Mozu.Api.Resources.Platform;
using Mozu.Api.Sample.Models;
using Mozu.Api.Security;
using System.Linq;
using UserScope = Mozu.Api.Security.UserScope;

namespace Mozu.Api.Sample
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            SetEnvironments();
        }

        private ApiContext _apiContext;
        private AuthenticationProfile _userInfo;
        private void SetEnvironments()
        {
            var environments = new List<Models.Environment>();
            environments.Add(new Models.Environment{ Key = "Sandbox", Value="https://sandbox.mozu.com"});
            environments.Add(new Models.Environment { Key = "Production", Value="https://home.mozu.com" });
            environments.Add(new Models.Environment { Key = "CI", Value = "http://home.mozu-ci.volusion.com" });
            environments.Add(new Models.Environment { Key = "Dev", Value = "http://mozu-dev.com" });
            cbEnvironment.DataSource = environments;
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            try
            {
                var appAuthInfo = new AppAuthInfo { ApplicationId = txtApplicationID.Text, SharedSecret = txtSharedSecret.Text };
                AppAuthenticator.Initialize(appAuthInfo, SelectedEnv);

                var userAuthInfo = new UserAuthInfo {EmailAddress = txtEmail.Text, Password = txtPassword.Text};
                _userInfo = UserAuthenticator.Authenticate(userAuthInfo, UserScope.Tenant);

                panelTenant.Visible = true;

                cbTenant.DataSource = _userInfo.AuthorizedScopes;
            }
            catch (ApiException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        private void AuthValuesChanged(object sender, EventArgs e)
        {
            panelTenant.Visible = false;
            panelAPI.Visible = false;
        }

        private string SelectedEnv
        {
            get { return ((Models.Environment) cbEnvironment.SelectedItem).Value; } 
        }

        private void cbTenant_changed(object sender, EventArgs e)
        {

            cbSite.DataSource = null;
            var scope = (Scope)cbTenant.SelectedItem;
            
            var tenantResource = new TenantResource();
            var tenant = tenantResource.GetTenant(scope.Id);
            var sites = tenant.Sites;
            cbSite.DataSource = sites;
            cbSite.DisplayMember = "Name";
            panelAPI.Show();
        }

        private void setContext()
        {

            var site = (Site)cbSite.SelectedItem;
            _apiContext = new ApiContext(site);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            setContext();
            var orderHome = new OrderHandler.Orders(_apiContext);
            orderHome.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            setContext();
            var productHome = new ProductHandler.Home(_apiContext);
            productHome.Show();
        }


    }
}
