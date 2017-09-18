using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaOpenLogFeedbackResponse.
    /// </summary>
    public class ZhimaOpenLogFeedbackResponse : ZmopResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }
    }
}
