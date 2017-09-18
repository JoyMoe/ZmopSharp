using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaAuthEngineMultiauthResponse.
    /// </summary>
    public class ZhimaAuthEngineMultiauthResponse : ZmopResponse
    {
        /// <summary>
        /// 用户在商端的身份标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
