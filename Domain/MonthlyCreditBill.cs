using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// MonthlyCreditBill Data Structure.
    /// </summary>
    [Serializable]
    public class MonthlyCreditBill : ZmopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("cr_monthly_count_list")]
        [XmlArrayItem("credit_record_monthly_count")]
        public List<CreditRecordMonthlyCount> CrMonthlyCountList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlElement("month")]
        public string Month { get; set; }

        /// <summary>
        /// 芝麻分及其变动情况
        /// </summary>
        [XmlElement("zm_score_info")]
        public ZmScoreInfo ZmScoreInfo { get; set; }
    }
}
