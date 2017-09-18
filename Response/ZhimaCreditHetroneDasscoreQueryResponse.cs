using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditHetroneDasscoreQueryResponse.
    /// </summary>
    public class ZhimaCreditHetroneDasscoreQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 共创das分
        /// </summary>
        [XmlElement("das_score")]
        public long DasScore { get; set; }
    }
}
