
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Platform.Developer
{
	public partial class ApplicationVersionUrl 
	{

		/// <summary>
        /// Get Resource Url for GetAllApplications
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAllApplicationsUrl()
		{
			var url = "/api/platform/developer/applications/";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetApplication
        /// </summary>
        /// <param name="applicationId">Unique identifier of the application.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetApplicationUrl(int? applicationId)
		{
			var url = "/api/platform/developer/applications/{applicationId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationId", applicationId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetApplicationVersion
        /// </summary>
        /// <param name="applicationVersionId">Unique identifier of the application version. Application version IDs are unique across all applications associated with a developer account.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetApplicationVersionUrl(int applicationVersionId)
		{
			var url = "/api/platform/developer/applications/applicationVersions/{applicationVersionId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationVersionId", applicationVersionId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPackages
        /// </summary>
        /// <param name="applicationVersionId">Unique identifier of the application version. Application version IDs are unique across all applications associated with a developer account.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPackagesUrl(int applicationVersionId)
		{
			var url = "/api/platform/developer/applications/applicationVersions/{applicationVersionId}/packages";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationVersionId", applicationVersionId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPackage
        /// </summary>
        /// <param name="applicationVersionId">Unique identifier of the application version associated with the package. Application version IDs are unique across all applications associated with the developer account.</param>
        /// <param name="packageId">Unique identifier of the package to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPackageUrl(int applicationVersionId, int packageId)
		{
			var url = "/api/platform/developer/applications/applicationVersions/{applicationVersionId}/packages/{packageId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationVersionId", applicationVersionId);
			mozuUrl.FormatUrl( "packageId", packageId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPackageItemsMetadata
        /// </summary>
        /// <param name="applicationVersionId">Unique identifier of the application version. Application version IDs are unique across all applications associated with a developer account.</param>
        /// <param name="packageId">Unique identifier of the package.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPackageItemsMetadataUrl(int applicationVersionId, int packageId)
		{
			var url = "/api/platform/developer/applications/applicationVersions/{applicationVersionId}/packages/{packageId}/files";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationVersionId", applicationVersionId);
			mozuUrl.FormatUrl( "packageId", packageId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPackageItemMetadata
        /// </summary>
        /// <param name="applicationVersionId">Unique identifier of the application version. Application version IDs are unique across all applications associated with a developer account.</param>
        /// <param name="itempath">Complete file directory location and name of the item in the package to retrieve metadata.</param>
        /// <param name="packageId">Unique identifier of the package.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPackageItemMetadataUrl(int applicationVersionId, string itempath, int packageId)
		{
			var url = "/api/platform/developer/applications/applicationVersions/{applicationVersionId}/packages/{packageId}/files/?itemPath={itempath}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationVersionId", applicationVersionId);
			mozuUrl.FormatUrl( "itempath", itempath);
			mozuUrl.FormatUrl( "packageId", packageId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPackageFilesZip
        /// </summary>
        /// <param name="applicationVersionId"></param>
        /// <param name="packageId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPackageFilesZipUrl(int applicationVersionId, int packageId)
		{
			var url = "/api/platform/developer/applications/applicationVersions/{applicationVersionId}/packages/{packageId}/zip";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationVersionId", applicationVersionId);
			mozuUrl.FormatUrl( "packageId", packageId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddPackage
        /// </summary>
        /// <param name="applicationVersionId">Unique identifier of the application version. Application version IDs are unique across all applications associated with the developer account.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddPackageUrl(int applicationVersionId)
		{
			var url = "/api/platform/developer/applications/applicationVersions/{applicationVersionId}/packages";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationVersionId", applicationVersionId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for ChangePackageFileNameOrPath
        /// </summary>
        /// <param name="applicationVersionId"></param>
        /// <param name="packageId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ChangePackageFileNameOrPathUrl(int applicationVersionId, int packageId)
		{
			var url = "/api/platform/developer/applications/applicationVersions/{applicationVersionId}/packages/{packageId}/files/change-name-or-path";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationVersionId", applicationVersionId);
			mozuUrl.FormatUrl( "packageId", packageId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for AddPackageFile
        /// </summary>
        /// <param name="applicationVersionId">Unique identifier of the application version. Application version IDs are unique across all applications associated with a developer account.</param>
        /// <param name="filepath">The file location to which to add the package file.</param>
        /// <param name="packageId">Unique identifier of the package.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddPackageFileUrl(int applicationVersionId, string filepath, int packageId)
		{
			var url = "/api/platform/developer/applications/applicationVersions/{applicationVersionId}/packages/{packageId}/files?filePath={filepath}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationVersionId", applicationVersionId);
			mozuUrl.FormatUrl( "filepath", filepath);
			mozuUrl.FormatUrl( "packageId", packageId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdatePackageFile
        /// </summary>
        /// <param name="applicationVersionId">Unique identifier of the application version. Application version IDs are unique across all applications associated with a developer account.</param>
        /// <param name="filepath">The location path and name that identifies the package file to update.</param>
        /// <param name="packageId">The unique identifier of the package.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdatePackageFileUrl(int applicationVersionId, string filepath, int packageId)
		{
			var url = "/api/platform/developer/applications/applicationVersions/{applicationVersionId}/packages/{packageId}/files?filePath={filepath}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationVersionId", applicationVersionId);
			mozuUrl.FormatUrl( "filepath", filepath);
			mozuUrl.FormatUrl( "packageId", packageId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeletePackageFile
        /// </summary>
        /// <param name="applicationVersionId">Unique identifier of the application version.</param>
        /// <param name="filepath">The file path and name of the file location to delete from the package.</param>
        /// <param name="packageId">Unique identifier of the package.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeletePackageFileUrl(int applicationVersionId, string filepath, int packageId)
		{
			var url = "/api/platform/developer/applications/applicationVersions/{applicationVersionId}/packages/{packageId}/files?filePath={filepath}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationVersionId", applicationVersionId);
			mozuUrl.FormatUrl( "filepath", filepath);
			mozuUrl.FormatUrl( "packageId", packageId);
			return mozuUrl;
		}

		
	}
}

