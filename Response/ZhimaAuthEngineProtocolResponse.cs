using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaAuthEngineProtocolResponse.
    /// </summary>
    public class ZhimaAuthEngineProtocolResponse : ZmopResponse
    {
        /// <summary>
        /// 27位openId，用于标识芝麻会员在商户端的身份标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
