using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaProfileStatusFeedbackResponse.
    /// </summary>
    public class ZhimaProfileStatusFeedbackResponse : ZmopResponse
    {
        /// <summary>
        /// 业务处理结果
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }
    }
}
