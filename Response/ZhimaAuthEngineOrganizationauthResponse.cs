using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaAuthEngineOrganizationauthResponse.
    /// </summary>
    public class ZhimaAuthEngineOrganizationauthResponse : ZmopResponse
    {
        /// <summary>
        /// 27位openId，用于标识芝麻会员在
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
