using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaDataFeedbackurlQueryResponse.
    /// </summary>
    public class ZhimaDataFeedbackurlQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 数据反馈模板
        /// </summary>
        [XmlElement("feedback_url")]
        public string FeedbackUrl { get; set; }
    }
}
