using System;
using System.Globalization;
using System.Net;
using System.Web;
using System.IO;
using Mozu.Api.Security;
using Newtonsoft.Json;
using Mozu.Api.Contracts.Event;
using Mozu.Api.Config.Event;
using System.Configuration;
using System.Reflection;

namespace Mozu.Api.HttpModules
{
    public class EventModule : IHttpModule
    {

        public String ModuleName
        {
            get { return "MozuEventModule"; }
        }

        public void Init(HttpApplication application)
        {
            application.BeginRequest += (new EventHandler(this.Application_BeginRequest));
        }

        private void Application_BeginRequest(Object source,EventArgs e)
        {
            //create http objects used to read request 
            HttpApplication application = (HttpApplication)source;
            HttpContext context = application.Context;
            HttpRequest request = context.Request;

            //get file path to use as comparison and determine when to take action on event
            string filePath = context.Request.FilePath;
            string fileExtension = VirtualPathUtility.GetExtension(filePath);
  
            if (filePath.EndsWith("/api/mozu/events") && request.RequestType == "POST")
            {
                //load headers into apicontext
				var apiContext = new ApiContext(request.Headers);

                //read request into stream
                string jsonRequest = string.Empty;
                request.InputStream.Position = 0;
                using (var inputStream = new StreamReader(request.InputStream))
                {
                   jsonRequest = inputStream.ReadToEnd();
                }

                if (Crypto.GetHash(AppAuthenticator.Instance.AppAuthInfo.SharedSecret, jsonRequest) !=
                    apiContext.HMACSha256)
                {
                    context.Response.StatusCode = 403;
                }
                else
                {
                    //get payload from json request
                    var eventPayload = JsonConvert.DeserializeObject<Event>(jsonRequest);

                    context.Response.Clear();
                    context.Response.ClearHeaders();

                    try
                    {
                        //create and invoke user defined assembly and method
                        InvokeEvent(apiContext, eventPayload);


                        context.Response.StatusCode = 200;
                        context.Response.StatusDescription = "OK";

                    }
                    catch (Exception exc)
                    {
                        context.Response.StatusCode = 500;
                        context.Response.StatusDescription = exc.Message;
                        context.Response.ContentType = context.Request.ContentType;
                        context.Response.Write(JsonConvert.SerializeObject(exc));
                    }
                }

                context.Response.Flush();
                HttpContext.Current.ApplicationInstance.CompleteRequest();

            }

        }


      

        public void Dispose() { }

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
                if (entityEvent.Name.Equals(topic, StringComparison.InvariantCultureIgnoreCase)) {
                    string name = entityEvent.Name;
                    string type = entityEvent.Type;
                    string assembly = entityEvent.AssemblyName;
                    InvokeMethod(assembly, type, action, apiContext, eventPayLoad);
                }
                
            }
        }

        private void InvokeMethod(string assemblyName, string type, string action, ApiContext apiContext, Event mzEvent)
        {
            Type assemblyType = Assembly.Load(assemblyName).GetType(type);

            ConstructorInfo typeConstructor = assemblyType.GetConstructor(Type.EmptyTypes);

            object typeObject = typeConstructor.Invoke(new Object[] { });

            MethodInfo methodInfo = assemblyType.GetMethod(action);
            if (methodInfo == null)
                throw new Exception("Method : " + action + " not found in " + type);
            methodInfo.Invoke(typeObject, new Object[] { apiContext, mzEvent });

        }

    }
}