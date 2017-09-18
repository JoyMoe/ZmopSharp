using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaAuthFaceInitResponse.
    /// </summary>
    public class ZhimaAuthFaceInitResponse : ZmopResponse
    {
        /// <summary>
        /// 请求返回的加密串
        /// </summary>
        [XmlElement("auth_msg")]
        public string AuthMsg { get; set; }
    }
}
