using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using Mozu.Api.Resources.Commerce.Settings;
using Mozu.Api.Security;
using Newtonsoft.Json;
using Mozu.Api.Contracts.Event;
using Mozu.Api.Config.Event;
using System.Configuration;
using System.Reflection;

namespace Mozu.Api.Events
{
    /// <summary>
    /// 
    /// </summary>
    public class HttpHandler: IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //create http objects used to read request 
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;

            //get file path to use as comparison and determine when to take action on event
            //load headers into apicontext
			var apiContext = new ApiContext(request.Headers);

            //read request into stream
            string jsonRequest = string.Empty;
            request.InputStream.Position = 0;
            using (var inputStream = new StreamReader(request.InputStream))
            {
                jsonRequest = inputStream.ReadToEnd();
            }

            response.Clear();
            response.ClearHeaders();


            if (Crypto.GetHash(AppAuthenticator.Instance.AppAuthInfo.SharedSecret, jsonRequest) !=
                apiContext.HMACSha256)
            {
                response.StatusCode = 403;
            }
            else
            {
                //get payload from json request
                var eventPayload = JsonConvert.DeserializeObject<Event>(jsonRequest);

              
                try
                {
                    //create and invoke user defined assembly and method
                    InvokeEvent(apiContext, eventPayload);


                    response.StatusCode = 200;
                    response.StatusDescription = "OK";

                }
                catch (Exception exc)
                {
                    response.StatusCode = 500;
                    response.StatusDescription = exc.Message;
                    response.ContentType = context.Request.ContentType;
                    if (exc.InnerException != null)
                        response.Write(JsonConvert.SerializeObject(exc.InnerException));
                    else
                        response.Write(JsonConvert.SerializeObject(exc));
                }
            }

            response.Flush();
            context.ApplicationInstance.CompleteRequest();


        }

        //--commented out to change web.config section--
        public void InvokeEvent(ApiContext apiContext, Event eventPayLoad)
        {
            EventSection eventConfigSection = ConfigurationManager.GetSection("eventSection") as EventSection;

            var eventType = eventPayLoad.Topic.Split('.');

            var topic = eventType[0];
            var action = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(eventType[1]);


            //Get the external assembly, and invoke the correpsonding method by 
            foreach (EntityConfigElement entityEvent in eventConfigSection.Events)
            {
                if (entityEvent.Name.Equals(topic, StringComparison.InvariantCultureIgnoreCase))
                {
                    string name = entityEvent.Name;
                    string type = entityEvent.Type;
                    string assembly = entityEvent.AssemblyName;
                    InvokeMethod(type, action, apiContext, eventPayLoad);
                }

            }
        }

        private void InvokeMethod(string type, string action, ApiContext apiContext, Event mzEvent)
        {
            Type assemblyType = Type.GetType(type);

            ConstructorInfo typeConstructor = assemblyType.GetConstructor(Type.EmptyTypes);

            object typeObject = typeConstructor.Invoke(new Object[] { });

            MethodInfo methodInfo = assemblyType.GetMethod(action);

            if (methodInfo == null)
                throw new Exception("Method : "+action+" not found in " +type );
            methodInfo.Invoke(typeObject, new Object[] { apiContext, mzEvent });

        }
    }
}
