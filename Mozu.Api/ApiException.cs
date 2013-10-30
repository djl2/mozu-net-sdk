using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;

namespace Mozu.Api
{
   
    public class ApiException : Exception
    {
        private string _message;

        public ApiException(string message) : base(message)
        {
            
        }
        public ApiException(string message, Exception innerException) : base(message, innerException)
        {
            
        }

        public ApiException(SerializationInfo info, StreamingContext context)
        {
            ExceptionDetail = (ExceptionDetail) info.GetValue("ExceptionDetail", typeof (ExceptionDetail));
            if (ExceptionDetail != null)
            {
                _message = ExceptionDetail.Message;
            }           
            Items = (List<Item>)info.GetValue("Items", typeof(List<Item>));
            //_message = info.GetString("Message");
            //ErrorCode = info.GetString("ErrorCode");
        }

        public override string Message
        {
            get { return _message; }
        }

        public string ErrorCode { get; set; }
        public ExceptionDetail ExceptionDetail;
        public List<Item> Items;
        public HttpStatusCode HttpStatusCode;

    }

    public class ApplicationErrorData
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class Item
    {
        public List<ApplicationErrorData> ApplicationErrorData { get; set; } 
        public String ApplicationName;
        public String ErrorCode;
        public String Message;
    }

    public class ExceptionDetail
    {
        public String Message;
        public String Source;
        public String StackTrace;
        public String TargetSite;
        public String Type;
    }

}
