using System;
using System.Globalization;
using System.Net;

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
