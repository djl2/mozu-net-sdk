﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;

namespace Mozu.Api
{
   
    [Serializable]
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
            
            try
            {
                ExceptionDetail = (ExceptionDetail) info.GetValue("exceptionDetail", typeof (ExceptionDetail));
            }
            catch (Exception)
            {
                try
                {
                    ExceptionDetail = (ExceptionDetail)info.GetValue("ExceptionDetail", typeof(ExceptionDetail));
                }
                catch (Exception) { }
            }



            if (ExceptionDetail != null)
            {
                _message = ExceptionDetail.Message;
            }

            try
            {
                Items = (List<Item>) info.GetValue("items", typeof (List<Item>));
            }
            catch (Exception)
            {

                try
                {
                    Items = (List<Item>)info.GetValue("Items", typeof(List<Item>));
                }
                catch (Exception) { }
                
            }

        }

        public override string Message
        {
            get { return _message; }
        }

        public IApiContext ApiContext { get; set; }
        public String CorrelationId { get; set; }
        public ExceptionDetail ExceptionDetail;
        public List<Item> Items;
        public HttpStatusCode HttpStatusCode;

    }


    [Serializable]
    public class ApplicationErrorData
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    [Serializable]
    public class Item
    {
        public List<ApplicationErrorData> ApplicationErrorData { get; set; } 
        public String ApplicationName;
        public String ErrorCode;
        public String Message;
    }

    [Serializable]
    public class ExceptionDetail
    {
        public String Message;
        public String Source;
        public String StackTrace;
        public String TargetSite;
        public String Type;
    }

}
