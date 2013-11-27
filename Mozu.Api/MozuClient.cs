using System;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Mozu.Api.Contracts;
using Mozu.Api.Resources.Platform;
using Mozu.Api.Security;
using Mozu.Api.Utilities;
using Newtonsoft.Json;

namespace Mozu.Api
{

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public class MozuClient<TResult> : MozuClient<object, TResult>
    {

        public virtual MozuClient<TResult> WithUserAuth(AuthTicket authTicket)
        {
            base.SetUserClaims(authTicket);
            return this;
        }

		public virtual MozuClient<TResult> WithContext(IApiContext apiContext)
		{
			base.SetContext(apiContext);
			return this;
		}

        public virtual MozuClient<TResult> WithBaseAddress(string baseAddress)
        {
            base.SetBaseAddress(baseAddress);
            return this;
        }

		public virtual MozuClient<TResult> WithHeader(string header, string value)
        {
            base.AddHeader(header, value);
            return this;
        }

		public virtual MozuClient<TResult> WithVerb(string verb)
        {
            base.SetVerb(verb);
            return this;
        }

		public virtual MozuClient<TResult> WithResourceUrl(MozuUrl resourceUrl)
        {
            base.SetResourceUrl(resourceUrl);
            return this;
        }

		public virtual MozuClient<TResult> WithBody<TBody>(TBody body)
        {
            SetBody(body);
            return this;
        }

		public virtual MozuClient<TResult> WithBody(string stringContent)
        {
            base.SetBody(stringContent);
            return this;
        }

        public virtual MozuClient<TResult> WithBody(Stream body)
        {
            base.SetBody(body);
            return this;
        }


		public virtual MozuClient<TResult> Execute()
        {
            base.ExecuteRequest();
            return this;
        }
       
    }

    /// <summary>
    /// 
    /// </summary>
    public class MozuClient : MozuClient<object, object>
    {

        public virtual MozuClient WithUserAuth(AuthTicket authTicket)
        {
            base.SetUserClaims(authTicket);
            return this;
        }

		public virtual MozuClient WithContext(IApiContext apiContext)
		{
			base.SetContext(apiContext);
			return this;
		}

		public virtual MozuClient WithBaseAddress(string baseAddress)
        {
            base.SetBaseAddress(baseAddress);
            return this;
        }

		public virtual MozuClient WithHeader(string header, string value)
        {
            base.AddHeader(header, value);
            return this;
        }

		public virtual MozuClient WithVerb(string verb)
        {
            base.SetVerb(verb);
            return this;
        }

		public virtual MozuClient WithResourceUrl(MozuUrl resourceUrl)
        {
            base.SetResourceUrl(resourceUrl);
            return this;
        }

		public virtual MozuClient WithBody<T>(T body)
        {
            var stringContent = JsonConvert.SerializeObject(body);
            base.SetBody(stringContent);
            return this;
        }

		public virtual MozuClient WithBody(string body)
        {
            base.SetBody(body);
            return this;
        }

        public virtual MozuClient WithBody(Stream body)
        {
            base.SetBody(body);
            return this;
        }

		public virtual MozuClient Execute()
        {
            base.ExecuteRequest();
            return this;
        }

       
    }

    /// <summary>
    /// 
    /// </summary>
    public class MozuClient<TBody,TResult>
    {
		private IApiContext _apiContext = null;
        private string _baseAddress = string.Empty;
        private HttpResponseMessage _httpResponseMessage = null;
        private StringContent _httpContent = null;
        private StreamContent _streamContent = null;
        private string _verb = string.Empty;
		private MozuUrl _resourceUrl = new MozuUrl() { Url = "", Location = MozuUrl.UrlLocation.TENANT_POD };
        private NameValueCollection _headers = new NameValueCollection();
        private static ConcurrentDictionary<string, HttpClient> _clientsByHostName;

        static MozuClient()
        {
            _clientsByHostName = new ConcurrentDictionary<string, HttpClient>();
        }

        protected virtual void SetUserClaims(AuthTicket authTicket)
        {
            var userInfo = UserAuthenticator.EnsureAuthTicket(authTicket);
            if (userInfo != null)
            {
                authTicket.AccessToken = userInfo.AuthTicket.AccessToken;
                authTicket.AccessTokenExpiration = userInfo.AuthTicket.AccessTokenExpiration;
            }
                
            _headers.Add(Headers.X_VOL_USER_CLAIMS, authTicket.AccessToken);
        }

		protected virtual void SetContext(IApiContext apiContext)
		{
			_apiContext = apiContext;

			if (_apiContext.TenantId > 0)
			{
				AddHeader(Headers.X_VOL_TENANT, _apiContext.TenantId.ToString());
			}

			if (_apiContext.SiteId.HasValue && _apiContext.SiteId.Value > 0)
			{
				AddHeader(Headers.X_VOL_SITE, _apiContext.SiteId.Value.ToString());
			}

            if (_apiContext.MasterCatalogId.HasValue && _apiContext.MasterCatalogId.Value > 0)
			{
				AddHeader(Headers.X_VOL_MASTER_CATALOG, _apiContext.MasterCatalogId.Value.ToString());
			}

            if (_apiContext.CatalogId.HasValue && _apiContext.CatalogId.Value > 0)
			{
				AddHeader(Headers.X_VOL_CATALOG, _apiContext.CatalogId.Value.ToString());
			}

		}

        protected void SetBaseAddress(string baseAddress)
        {
            _baseAddress = baseAddress;
        }

		public virtual void AddHeader(string header, string value)
        {
            _headers.Add(header, value);
        }

        protected void SetVerb(string verb)
        {
            _verb = verb.ToLower();
        }

        protected void SetResourceUrl(MozuUrl resourceUrl)
        {
            _resourceUrl = resourceUrl;
        }

        private readonly JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
        protected void SetBody(TBody body)
        {
            var stringContent = JsonConvert.SerializeObject(body, _jsonSerializerSettings);
            SetBody(stringContent);
            
        }

        protected void SetBody(Stream stream)
        {
            _streamContent = new StreamContent(stream);

        }

        protected void SetBody(string body)
        {
            _httpContent = new StringContent(body, Encoding.UTF8, "application/json");
        }

		public virtual HttpResponseMessage HttpResponse
        {
            get { return _httpResponseMessage; }
        }

        public MozuUrl ResourceUrl { get { return _resourceUrl; } }

		public virtual HttpClient HttpClient
        {
            get
            {
                var client = GetHttpClient();

                client.BaseAddress = new Uri(_baseAddress);

                if (_headers[Headers.X_VOL_APP_CLAIMS] == null)
                    AppAuthenticator.AddHeader(client);

                AddHeader(Headers.X_VOL_VERSION, Version.ApiVersion);

                foreach (var key in _headers.AllKeys)
                {
                    client.DefaultRequestHeaders.Add(key, _headers[key]);
                }


                return client;
            }
        }

		public virtual HttpRequestMessage RequestMessage
        {
            get { return GetRequestMessage(); }
        }

		public virtual ApiException ApiException { get; set; }

		public virtual TResult Result()
        {
            return JsonConvert.DeserializeObject<TResult>(HttpResponse.Content.ReadAsStringAsync().Result);
        }

		protected void ValidateContext()
		{
			if (_resourceUrl.Location == MozuUrl.UrlLocation.TENANT_POD)
			{
				if (_apiContext.TenantId < 0)
					throw new ApiException("TenantId is missing");

				if (string.IsNullOrEmpty(_apiContext.TenantUrl))
				{
					var tenantResource = new TenantResource();
					var tenant = tenantResource.GetTenant(_apiContext.TenantId);

					if (tenant == null)
						throw new ApiException("Tenant " + _apiContext.TenantId + " Not found");
                    _baseAddress = _apiContext.GetUrl(tenant.Domain);
				}
                else
                    _baseAddress = _apiContext.TenantUrl;
			}
			else
			{
				if (string.IsNullOrEmpty(AppAuthenticator.Instance.BaseUrl))
					throw new ApiException("Authentication.Instance.BaseUrl is missing");

			    _baseAddress = AppAuthenticator.Instance.BaseUrl;
			}
		}

        protected void ExecuteRequest()
        {
			ValidateContext();
            var client = GetHttpClient();
            _httpResponseMessage = client.SendAsync(GetRequestMessage(), HttpCompletionOption.ResponseContentRead).Result;
            ResponseHelper.EnsureSuccess(_httpResponseMessage);
        }
        
        private HttpRequestMessage GetRequestMessage()
        {
            var requestMessage = new HttpRequestMessage { RequestUri = new Uri(_baseAddress+_resourceUrl.Url) };
            requestMessage.Method = GetMethod();

            if (requestMessage.Method == HttpMethod.Post || requestMessage.Method == HttpMethod.Put)
            {
                if (_httpContent != null)
                    requestMessage.Content = _httpContent;
                else
                    requestMessage.Content =  _streamContent;
                
            }

            if (_headers[Headers.X_VOL_APP_CLAIMS] == null)
                AppAuthenticator.AddHeader(requestMessage);

            AddHeader(Headers.X_VOL_VERSION, Version.ApiVersion);

            foreach (var key in _headers.AllKeys)
            {
                requestMessage.Headers.Add(key, _headers[key]);
            }

            return requestMessage;
        }

        private HttpMethod GetMethod()
        {
            switch (_verb.ToUpper())
            {
                case "GET":
                    return HttpMethod.Get;
                case "POST":
                    return HttpMethod.Post;
                case "PUT":
                    return HttpMethod.Put;
                case "DELETE":
                    return HttpMethod.Delete;
                case "HEAD":
                    return HttpMethod.Head;
            }

            return HttpMethod.Get;
        }
 
        private HttpClient GetHttpClient()
        {
            Uri uri = new Uri(_baseAddress);
            var client = GetActualClient(uri);
            return client;
        }

        private HttpClient GetActualClient(Uri u)
        {
            string key = u.Host;
            if (!u.IsDefaultPort)
            {
                key = string.Format("{0}:{1}", key, u.Port.ToString());
            }

            if (!_clientsByHostName.ContainsKey(key))
            {
                var client = new HttpClient(new HttpClientHandler
                {
                    AllowAutoRedirect = false,
                    UseCookies = false,
                    AutomaticDecompression = DecompressionMethods.GZip
                        | DecompressionMethods.Deflate
                });


                client.MaxResponseContentBufferSize = int.MaxValue;
                _clientsByHostName[key] = client;
            }

            return _clientsByHostName[key];
        }

    }
}
