using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaAuthFaceVerifyResponse.
    /// </summary>
    public class ZhimaAuthFaceVerifyResponse : ZmopResponse
    {
        /// <summary>
        /// 业务执行结果是否成功
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 一次请求的标识token
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }
    }
}
