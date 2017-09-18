using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantCreditlifeRiskApplyResponse.
    /// </summary>
    public class ZhimaMerchantCreditlifeRiskApplyResponse : ZmopResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("ivs_details")]
        public string IvsDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("watchlist_detail")]
        public string WatchlistDetail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("zm_risk")]
        public string ZmRisk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("zm_score")]
        public string ZmScore { get; set; }
    }
}
