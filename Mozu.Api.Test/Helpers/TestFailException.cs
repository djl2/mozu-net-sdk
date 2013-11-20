// ***********************************************************************
// <copyright file="TestFailException.cs" company="Volusion">
//     Copyright (c) Volusion. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics;

namespace Mozu.Api.Test.Helpers
{
    class TestFailException : TestException
    {
        /// <summary>
        /// Default constructor for generating TestFailException.
        /// </summary>
        /// <param name="actualCode"></param>
        /// <param name="methodName"></param>
        /// <param name="expectedCode"></param>
        /// <param name="msg"></param>
        public TestFailException(int actualCode, string methodName, int? expectedCode, string msg = "")
            : base(actualCode, methodName, expectedCode, msg)
        {
            Debug.WriteLine(ToString());
        }


        /// <summary>
        /// Retrun a string containing the client method call failure exception information.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Test Fails - [{0}:expected {1}] but the actual return code is {2}. {3}", ClientMethodName, ExpectedReturnCode, ActualReturnCode, Message);
        }
    }
}
