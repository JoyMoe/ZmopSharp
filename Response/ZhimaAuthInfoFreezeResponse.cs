using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaAuthInfoFreezeResponse.
    /// </summary>
    public class ZhimaAuthInfoFreezeResponse : ZmopResponse
    {
        /// <summary>
        /// 业务返回值，true代表成功
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }
    }
}
