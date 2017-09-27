using System;
using System.Net.Http;
using Xunit;

namespace ZmopSharp.Core.Test
{
    public class RequestTests
    {
        [Fact]
        public void Request_Can_Convert_To_HttpContent()
        {
            var request = new Request
            {
                AppId = "000000000",
                Method = "zhima.customer.certification.initialize",
                Params = "parameters",
                Sign = "signature",
            };
            
            Assert.IsType<FormUrlEncodedContent>(request.ToHttpContent());
        }
    }
}