using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerPerformanceFeedbackResponse.
    /// </summary>
    public class ZhimaCustomerPerformanceFeedbackResponse : ZmopResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("biz_success")]
        public string BizSuccess { get; set; }
    }
}
