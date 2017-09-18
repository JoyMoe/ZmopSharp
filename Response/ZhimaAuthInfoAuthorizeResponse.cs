using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaAuthInfoAuthorizeResponse.
    /// </summary>
    public class ZhimaAuthInfoAuthorizeResponse : ZmopResponse
    {
        /// <summary>
        /// 用户在商户端的身份标识ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户透传的值，芝麻不做解析
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }
    }
}
