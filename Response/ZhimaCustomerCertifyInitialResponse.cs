using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerCertifyInitialResponse.
    /// </summary>
    public class ZhimaCustomerCertifyInitialResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻认证每一次请求返回的令牌，发起页面认证请求和认证请求结果查询接口都需要使用到该返回值作为入参
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }
    }
}
