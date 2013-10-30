using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http.Headers;
using Mozu.Api.Contracts.Tenant;

namespace Mozu.Api
{
    public class ApiContext
    {

        public string BaseUrl { get; set; }

        public int TenantId = 0;
        public int? SiteGroupId = null;
        public int? SiteId = null;
        public string TenantUrl { get; set; }
        public string SiteUrl { get; set; }
        public string CorrelationId { get; internal set; }
        public string HMACSha256 { get; set; }
        public string AppAuthTicket { get; set; }

        public static string GetUrl(Domain domain)
        {
            return "Http://" + domain.DomainName;
        }

        public void SetContext(Tenant tenant)
        {
            TenantId = tenant.Id;
            TenantUrl = GetUrl(tenant.Domain);

            if (SiteId != null && SiteId.Value >= 0)
            {
                var site = tenant.SiteGroups.SelectMany(x => x.Sites).SingleOrDefault(x => x.Id == SiteId.Value);
                SiteGroupId = site.SiteGroupId;
                SiteUrl = GetUrl(site.Domains.SingleOrDefault(x => x.IsSystemAssigned == true));
            }
                
        }

        public void SetContext(Site site)
        {
            SiteId = site.Id;
            SiteGroupId = site.SiteGroupId;
            TenantId = site.TenantId;

            var siteDomain = site.Domains.SingleOrDefault(x => x.IsSystemAssigned == true);
            if (siteDomain != null)
                SiteUrl = siteDomain.DomainName;
        }

        public void SetContextFromHeaders(NameValueCollection headers, string rootMozuUrl)
        {
            TenantUrl = headers.Get(Headers.X_VOL_TENANT_DOMAIN);
            SiteUrl = headers.Get(Headers.X_VOL_SITE_DOMAIN);
            TenantId = int.Parse(headers.Get(Headers.X_VOL_TENANT));
            SiteId = int.Parse(headers.Get(Headers.X_VOL_SITE));
            SiteGroupId = int.Parse(headers.Get(Headers.X_VOL_SITEGROUP));
            CorrelationId =headers.Get(Headers.X_VOL_CORRELATION);
            HMACSha256 = headers.Get(Headers.X_VOL_HMAC_SHA256);
            if (!String.IsNullOrEmpty(TenantUrl))
                TenantUrl = string.Format("Http://{0}", TenantUrl);

            if (!String.IsNullOrEmpty(SiteUrl))
                SiteUrl = String.Format("http://{0}", SiteUrl);
        }

        public void SetContextFromHeaders(HttpRequestHeaders headers, string rootMozuUrl)
        {
            TenantUrl = GetHeaderValue(Headers.X_VOL_TENANT_DOMAIN, headers);
            SiteUrl = GetHeaderValue(Headers.X_VOL_SITE_DOMAIN, headers);
            TenantId = ParseFirstValue(Headers.X_VOL_TENANT, headers).Value;
            SiteId = ParseFirstValue(Headers.X_VOL_SITE, headers);
            SiteGroupId = ParseFirstValue(Headers.X_VOL_SITEGROUP, headers);
            CorrelationId = GetHeaderValue(Headers.X_VOL_CORRELATION, headers);
            HMACSha256 = GetHeaderValue(Headers.X_VOL_HMAC_SHA256, headers);
            if (!String.IsNullOrEmpty(TenantUrl))
                TenantUrl = string.Format("Http://{0}", TenantUrl);

            if (!String.IsNullOrEmpty(SiteUrl))
                SiteUrl = String.Format("http://{0}", SiteUrl);
        }

        private static string GetHeaderValue(string header, HttpRequestHeaders headers)
        {


            var retVal = String.Empty;
            IEnumerable<string> value = (headers.Contains(header) ? headers.GetValues(header) : null);

            if (value != null && !Equals(value, Enumerable.Empty<string>()))
            {
                var str = value.FirstOrDefault();
                return str ?? String.Empty;
            }
            return retVal;
        }

        protected static int? ParseFirstValue(string header, HttpRequestHeaders headers)
        {

            IEnumerable<string> value = (headers.Contains(header) ? headers.GetValues(header) : null);
            if (value != null)
            {
                var firstDataItem = value.FirstOrDefault();
                if (firstDataItem != null)
                {
                    int intVal;
                    if (int.TryParse(firstDataItem, out intVal))
                        return intVal;
                }
            }

            return null;
        }
    }
}
