using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaAuthInfoAuthqueryResponse.
    /// </summary>
    public class ZhimaAuthInfoAuthqueryResponse : ZmopResponse
    {
        /// <summary>
        /// 用户是否对该应用授权
        /// </summary>
        [XmlElement("authorized")]
        public bool Authorized { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
