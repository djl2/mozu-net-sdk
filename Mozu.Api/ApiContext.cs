using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http.Headers;
using Mozu.Api.Contracts.Tenant;
using Mozu.Api.Security;
using Mozu.Api.Utilities;

namespace Mozu.Api
{
	public interface IApiContext
	{
		int TenantId { get; }
		int? SiteId { get; }
		string TenantUrl { get; }
		string SiteUrl { get; }
		string CorrelationId { get; }
		string HMACSha256 { get; }
        string AppAuthClaim { get; set; }
		int? MasterCatalogId { get; }
		int? CatalogId { get; }
	}

    public class ApiContext : IApiContext
    {
		public int TenantId { get; protected set; }
		public int? SiteId { get; protected set; }
		public string TenantUrl { get; protected set; }
		public string SiteUrl { get; protected set; }
		public string CorrelationId { get; protected set; }
		public string HMACSha256 { get; protected set; }
		public string AppAuthClaim { get; set; }
		public int? MasterCatalogId { get; protected set; }
		public int? CatalogId { get; protected set; }
        public Tenant Tenant { get; protected set; }

		public ApiContext()
		{
		}

		public ApiContext(int tenantId, int? siteId = null, int? masterCatalogId = null, int? catalogId = null)
		{
			TenantId = tenantId;
			SiteId = siteId;
			MasterCatalogId = masterCatalogId;
			CatalogId = catalogId;
		}

		public ApiContext(Tenant tenant, Site site = null, int? masterCatalogId = null, int? catalogId = null)
		{
            Tenant = tenant;
			TenantId = tenant.Id;
			TenantUrl = tenant.Domain;
			MasterCatalogId = masterCatalogId;
			CatalogId = catalogId;

            SetBySite(site);

            if (!masterCatalogId.HasValue && Tenant.MasterCatalogs.Count == 1)
            {
                MasterCatalogId = Tenant.MasterCatalogs.First().Id;
                if (Tenant.MasterCatalogs[0].Catalogs.Count == 1)
                    CatalogId = Tenant.MasterCatalogs.First().Catalogs.First().Id;
            }

        }

		public ApiContext(Site site, int? masterCatalogId = null, int? catalogId = null)
		{
			TenantId = site.TenantId;
			MasterCatalogId = masterCatalogId;
			CatalogId = catalogId;
		    SetBySite(site);

		}

		public ApiContext(NameValueCollection headers)
		{
			TenantUrl = headers.Get(Headers.X_VOL_TENANT_DOMAIN);
			SiteUrl = headers.Get(Headers.X_VOL_SITE_DOMAIN);
			TenantId = int.Parse(headers.Get(Headers.X_VOL_TENANT));
			SiteId = int.Parse(headers.Get(Headers.X_VOL_SITE));
			CorrelationId = headers.Get(Headers.X_VOL_CORRELATION);
			HMACSha256 = headers.Get(Headers.X_VOL_HMAC_SHA256);
			var masterCatalogStr = headers.Get(Headers.X_VOL_MASTER_CATALOG);
			if (masterCatalogStr != null)
			{
				MasterCatalogId = int.Parse(masterCatalogStr);
			}

			var catalogStr = headers.Get(Headers.X_VOL_CATALOG);
			if (catalogStr != null)
			{
				CatalogId = int.Parse(catalogStr);
			}


			if (!String.IsNullOrEmpty(TenantUrl))
			{
				TenantUrl = TenantUrl;
			}

			if (!String.IsNullOrEmpty(SiteUrl))
			{
				SiteUrl = SiteUrl;
			}

		}

		public ApiContext(HttpRequestHeaders headers)
		{
			TenantUrl = GetHeaderValue(Headers.X_VOL_TENANT_DOMAIN, headers);
			SiteUrl = GetHeaderValue(Headers.X_VOL_SITE_DOMAIN, headers);
			TenantId = ParseFirstValue(Headers.X_VOL_TENANT, headers).Value;
			SiteId = ParseFirstValue(Headers.X_VOL_SITE, headers);
			CorrelationId = GetHeaderValue(Headers.X_VOL_CORRELATION, headers);
			HMACSha256 = GetHeaderValue(Headers.X_VOL_HMAC_SHA256, headers);
			MasterCatalogId = ParseFirstValue(Headers.X_VOL_MASTER_CATALOG, headers);
			CatalogId = ParseFirstValue(Headers.X_VOL_CATALOG, headers);
			

			if (!String.IsNullOrEmpty(TenantUrl))
			{
				TenantUrl = TenantUrl;
			}

			if (!String.IsNullOrEmpty(SiteUrl))
			{
				SiteUrl = SiteUrl;
			}

		}

       /* public string GetUrl(string domain)
        {
            return (AppAuthenticator.UseSSL ? "Https://" : "http://" )+domain;
            //return  "http://" + domain;
        }*/

        private void SetBySite(Site site)
        {
            if (site != null && site.Id >= 0)
            {
                SiteId = site.Id;
                SiteUrl = site.Domain;
            }
        }

        protected string GetHeaderValue(string header, HttpRequestHeaders headers)
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

        protected int? ParseFirstValue(string header, HttpRequestHeaders headers)
        {

            IEnumerable<string> value = (headers.Contains(header) ? headers.GetValues(header) : null);
            if (value != null)
            {
                var firstDataItem = value.FirstOrDefault();
                if (firstDataItem != null)
                {
                    int intVal;
                    if (int.TryParse(firstDataItem, out intVal))
                    {
                        if (intVal == 0)
                            return null;
                        return intVal;
                    }
                        
                }
            }

            return null;
        }

    }
}
