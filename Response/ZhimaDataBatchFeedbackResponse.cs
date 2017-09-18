using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaDataBatchFeedbackResponse.
    /// </summary>
    public class ZhimaDataBatchFeedbackResponse : ZmopResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("biz_success")]
        public string BizSuccess { get; set; }
    }
}
