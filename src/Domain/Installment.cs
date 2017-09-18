using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// Installment Data Structure.
    /// </summary>
    [Serializable]
    public class Installment : ZmopObject
    {
        /// <summary>
        /// 账期描述,描述状态或逾期天数
        /// </summary>
        [XmlElement("installment_desc")]
        public string InstallmentDesc { get; set; }

        /// <summary>
        /// 客户在合作伙伴处的某一个分期id,由合作伙伴根据自身业 务定义
        /// </summary>
        [XmlElement("installment_id")]
        public string InstallmentId { get; set; }

        /// <summary>
        /// 用户在合作伙伴处的某一分期状态:  WAITING_REPAY:待还款 OVERDUE:已逾期 REPAID_WAITING_CONFIRM :已还款,待商户确认 CONFIRM_COMPLETE:已销账 CONFIRM_FAILED:销账失败
        /// </summary>
        [XmlElement("installment_status")]
        public string InstallmentStatus { get; set; }
    }
}
