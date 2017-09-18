using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaAuthZhimaCustCertifyInitialResponse.
    /// </summary>
    public class ZhimaAuthZhimaCustCertifyInitialResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号，发起页面认证请求和认证请求结果查询接口都需要使用到该返回值作为入参。后续可以通过此业务号进行流水比对
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }
    }
}
