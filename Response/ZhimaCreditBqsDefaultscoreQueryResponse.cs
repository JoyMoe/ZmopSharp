using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditBqsDefaultscoreQueryResponse.
    /// </summary>
    public class ZhimaCreditBqsDefaultscoreQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("gongzhai_score")]
        public long GongzhaiScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("passed")]
        public bool Passed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("qizha_score")]
        public long QizhaScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("wending_score")]
        public long WendingScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("zizhi_score")]
        public long ZizhiScore { get; set; }
    }
}
