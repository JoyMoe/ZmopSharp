using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// ShareRiskDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ShareRiskDetail : ZmopObject
    {
        /// <summary>
        /// 公司类型
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 当前是否逾期180+
        /// </summary>
        [XmlElement("now_overdue_half_year")]
        public bool NowOverdueHalfYear { get; set; }

        /// <summary>
        /// 当前是否逾期90+
        /// </summary>
        [XmlElement("now_overdue_quarter")]
        public bool NowOverdueQuarter { get; set; }

        /// <summary>
        /// 曾经是否逾期180+
        /// </summary>
        [XmlElement("once_overdue_half_year")]
        public bool OnceOverdueHalfYear { get; set; }

        /// <summary>
        /// 曾经是否逾期90+
        /// </summary>
        [XmlElement("once_overdue_quarter")]
        public bool OnceOverdueQuarter { get; set; }

        /// <summary>
        /// 逾期金额
        /// </summary>
        [XmlElement("overdue_amt")]
        public string OverdueAmt { get; set; }

        /// <summary>
        /// 风险代码 借贷逾期对应的风险代码为： 01  逾期91-120天 02  逾期121-150天 03  逾期151-180天 04  逾期180天以上
        /// </summary>
        [XmlElement("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 风险名单类型 R001 借贷逾期
        /// </summary>
        [XmlElement("risk_type")]
        public string RiskType { get; set; }

        /// <summary>
        /// 报送日期
        /// </summary>
        [XmlElement("submit_date")]
        public string SubmitDate { get; set; }
    }
}
