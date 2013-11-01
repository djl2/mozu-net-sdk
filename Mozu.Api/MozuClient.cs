using System;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Text;
using Mozu.Api.Contracts;
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

        public virtual MozuClient<TResult> WithBaseAddress(string baseAddress)
        {
            base.SetBaseAddress(baseAddress);
            return this;
        }

		public virtual MozuClient<TResult> WithContext(int tenantId)
        {
            base.SetContext(tenantId);
            return this;
        }

		public virtual MozuClient<TResult> WithContext(int tenantId, int? siteGroupId)
        {
            base.SetContext(tenantId, siteGroupId);
            return this;
        }

		public virtual MozuClient<TResult> WithContext(int tenantId, int? siteGroupId, int? siteId)
        {
            base.SetContext(tenantId, siteGroupId, siteId);
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

		public virtual MozuClient<TResult> WithResourceUrl(string resourceUrl)
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
		public virtual MozuClient WithBaseAddress(string baseAddress)
        {
            base.SetBaseAddress(baseAddress);
            return this;
        }

		public virtual MozuClient WithContext(int tenantId)
        {
            base.SetContext(tenantId);
            return this;
        }

		public virtual MozuClient WithContext(int tenantId, int? siteGroupId)
        {
            base.SetContext(tenantId, siteGroupId);
            return this;
        }

		public virtual MozuClient WithContext(int tenantId, int? siteGroupId, int? siteId)
        {
            base.SetContext(tenantId, siteGroupId, siteId);
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

		public virtual MozuClient WithResourceUrl(string resourceUrl)
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

        private string _baseAddress = string.Empty;
        private HttpResponseMessage _httpResponseMessage = null;
        private StringContent _httpContent = null;
        private string _verb = string.Empty;
        private string _resourceUrl = string.Empty;
        private NameValueCollection _headers = new NameValueCollection();
        private static ConcurrentDictionary<string, HttpClient> _clientsByHostName;

        static MozuClient()
        {
            _clientsByHostName = new ConcurrentDictionary<string, HttpClient>();
            /*if (!AppAuthTicketKeepAlive.IsInitialized)
            {
                throw new ApplicationException("App Authentication is not initialized");
            }*/
        }

        protected void SetBaseAddress(string baseAddress)
        {
            _baseAddress = baseAddress;
            //_httpClient.BaseAddress = new Uri(baseAddress);
        }

        protected void SetContext(int tenantId)
        {
            if (tenantId > 0)
                AddHeader(Headers.X_VOL_TENANT, tenantId.ToString());
        }

        protected void SetContext(int tenantId, int? siteGroupId)
        {
            if (tenantId > 0)
                AddHeader(Headers.X_VOL_TENANT, tenantId.ToString());
            if (siteGroupId.HasValue)
                AddHeader(Headers.X_VOL_SITEGROUP, siteGroupId.Value.ToString());
        }

        protected void SetContext(int tenantId, int? siteGroupId, int? siteId)
        {
            if (tenantId > 0)
                AddHeader(Headers.X_VOL_TENANT, tenantId.ToString());
            if (siteGroupId.HasValue)
                AddHeader(Headers.X_VOL_SITEGROUP, siteGroupId.Value.ToString());
            if (siteId.HasValue)
                AddHeader(Headers.X_VOL_SITE, siteId.Value.ToString());
        }

		public virtual void AddHeader(string header, string value)
        {
            _headers.Add(header, value);
            //_httpClient.DefaultRequestHeaders.Add(header, value);
        }

        protected void SetVerb(string verb)
        {
            _verb = verb.ToLower();
        }

        protected void SetResourceUrl(string resourceUrl)
        {
            _resourceUrl = resourceUrl;
        }

        private readonly JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
        protected void SetBody(TBody body)
        {
            var stringContent = JsonConvert.SerializeObject(body, _jsonSerializerSettings);
            SetBody(stringContent);
        }

        protected void SetBody(string body)
        {
            _httpContent = new StringContent(body, Encoding.UTF8, "application/json");
        }

        protected void ValidateRequest()
        {
            if (String.IsNullOrEmpty(_baseAddress))
                throw new ApplicationException("Base address is not provided");
        }

       

		public virtual HttpResponseMessage HttpResponse
        {
            get { return _httpResponseMessage; }
        }

        public string ResourceUrl { get { return _resourceUrl; } }

		public virtual HttpClient HttpClient
        {
            get
            {
                var client = GetHttpClient();

                client.BaseAddress = new Uri(_baseAddress);
                if (_headers[Headers.X_VOL_APP_CLAIMS] == null)
                    Authentication.AddAuthHeader(client);

                if (UserAuthentication.Instance != null)
                    UserAuthentication.AddUserAuthHeader(client);

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

        protected void ExecuteRequest()
        {
            var client = GetHttpClient();
            _httpResponseMessage = client.SendAsync(GetRequestMessage(), HttpCompletionOption.ResponseContentRead).Result;
            ResponseHelper.EnsureSuccess(_httpResponseMessage);
        }
        
        private HttpRequestMessage GetRequestMessage()
        {
            var requestMessage = new HttpRequestMessage { RequestUri = new Uri(_baseAddress+_resourceUrl) };
            requestMessage.Method = GetMethod();

            if (requestMessage.Method == HttpMethod.Post || requestMessage.Method == HttpMethod.Put)
            {
                requestMessage.Content = _httpContent;
            }

            if (_headers[Headers.X_VOL_APP_CLAIMS] == null)
                Authentication.AddAuthHeader(requestMessage);

            if (UserAuthentication.Instance != null)
                UserAuthentication.AddUserAuthHeader(requestMessage);

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
