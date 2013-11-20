using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mozu.Api.Contracts.AppDev;
using Mozu.Api.Security;
using System.Configuration;
using Mozu.Api.Test.Helpers;
using Newtonsoft.Json;

namespace Mozu.Api.Test.Helpers
{
    public class BaseDataFactory
    {
        // Fields for every Factory
        #region Fields
            //public static RefreshInterval RefreshInterval = new RefreshInterval (5000, 60000);
            public static string AppId = "";
            public static string SharedSecret = "";
            public static string BaseAuthAppUrl = "";
            public static Environments Environment;
            public static string DevOwnerId = "";
            public static string DevOwnerEmail = "";
            public static string DevOwnerPassword = "";
        #endregion

        static BaseDataFactory() //constructor for every Factory
        {

            Environment = Helpers.Environment.GetConfigEnvironment();
            SetSdKparameters();
        }

        public static void SetSdKparameters()
        {
            if (AppId.Length == 0) // hasn't been set yet.
            {
                AppId = Helpers.Environment.GetConfigValueByEnvironment(Environment, "AppId");
            }
            if (SharedSecret.Length == 0) // hasn't been set yet.
            {
                SharedSecret = Helpers.Environment.GetConfigValueByEnvironment(Environment,
                                                                               "SharedSecret");
            }
            if (BaseAuthAppUrl.Length == 0) // hasn't been set yet.
            {
                BaseAuthAppUrl = Helpers.Environment.GetConfigValueByEnvironment(Environment,
                                                                                 "BaseAuthAppUrl");
            }
            if (DevOwnerId.Length == 0) // hasn't been set yet.
            {
                DevOwnerId = Helpers.Environment.GetConfigValueByEnvironment(Environment,
                                                                             "devOwnerId");
            }
            if (DevOwnerEmail.Length == 0) // hasn't been set yet.
            {
                DevOwnerEmail = Helpers.Environment.GetConfigValueByEnvironment(Environment,
                                                                                "devOwnerEmail");
            }
            if (DevOwnerPassword.Length == 0) // hasn't been set yet.
            {
                DevOwnerPassword = Helpers.Environment.GetConfigValueByEnvironment(Environment,
                                                                                   "devOwnerPassword");
            }
            if (SharedSecret.Length > 0 && BaseAuthAppUrl.Length > 0 && AppId.Length > 0)
            {
                AppAuthenticator.Initialize(
                    appAuthInfo: new AppAuthInfo()
                        {
                            ApplicationId = AppId,
                            SharedSecret = SharedSecret
                        },
                    baseAppAuthUrl: BaseAuthAppUrl);
            }



        }

        public static void ResetSdKparameters()
        {

            AppId = Helpers.Environment.GetConfigValueByEnvironment(Environment, "AppId");

            SharedSecret = Helpers.Environment.GetConfigValueByEnvironment(Environment,
                                                                                            "SharedSecret");
            BaseAuthAppUrl = Helpers.Environment.GetConfigValueByEnvironment(Environment,
                                                                                              "BaseAuthAppUrl");
            DevOwnerId = Helpers.Environment.GetConfigValueByEnvironment(Environment,
                                                                                          "devOwnerId");
            DevOwnerEmail = Helpers.Environment.GetConfigValueByEnvironment(Environment,
                                                                                             "devOwnerEmail");
            DevOwnerPassword = Helpers.Environment.GetConfigValueByEnvironment(Environment,
                                                                                                "devOwnerPassword");
        }

       //  JsonConvert.DeserializeObject<CardCollection>(JsonConvert.SerializeObject(result));
        public static T ConvertClass<T>(object input)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(input));
            }
            catch (Exception)
            {
                throw new Exception("Conversion of the Mozu Type did not work: " + input.GetType().ToString());
            }

        }
    }
}
