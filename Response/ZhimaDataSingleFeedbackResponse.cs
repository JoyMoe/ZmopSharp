using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaDataSingleFeedbackResponse.
    /// </summary>
    public class ZhimaDataSingleFeedbackResponse : ZmopResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }
    }
}
