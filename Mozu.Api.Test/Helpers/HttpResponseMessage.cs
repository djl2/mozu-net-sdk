﻿// ***********************************************************************
// <copyright file="HttpResponseMessage.cs" company="Volusion">
//     Copyright (c) Volusion. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Globalization;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozu.Api.Test.Helpers
{
    public static class ResponseMessageFactory
    {
        public static bool CheckResponseCodes(HttpStatusCode statusCode, int expectedCode, int baseCode)
        {
             try
             {
                var code = (int)statusCode;

                if (code != expectedCode)
                {
                   throw (new TestFailException(code, System.Reflection.MethodBase.GetCurrentMethod().Name.ToString(CultureInfo.InvariantCulture),
                        expectedCode));
                }
                return (expectedCode == baseCode);
             }
             catch (TestFailException)
             {
                 throw;
             }
             catch (Exception)
             {
                 return false;
//                 throw;
             }
        }
    }
}
