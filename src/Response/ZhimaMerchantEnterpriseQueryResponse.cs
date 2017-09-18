using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantEnterpriseQueryResponse.
    /// </summary>
    public class ZhimaMerchantEnterpriseQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 审核失败的具体原因
        /// </summary>
        [XmlElement("audit_fail_reason")]
        public string AuditFailReason { get; set; }

        /// <summary>
        /// 审核状态： Y:通过 N:不通过 ING:审批中
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 二级商户标识
        /// </summary>
        [XmlElement("linked_merchant_id")]
        public string LinkedMerchantId { get; set; }

        /// <summary>
        /// 商户认证状态： 1:未认证 3:已认证
        /// </summary>
        [XmlElement("merchant_status")]
        public string MerchantStatus { get; set; }

        /// <summary>
        /// 商户在芝麻域认证状态： 1:已认证 0:未认证
        /// </summary>
        [XmlElement("zhima_certify_status")]
        public string ZhimaCertifyStatus { get; set; }

        /// <summary>
        /// 商户被芝麻冻结的原因
        /// </summary>
        [XmlElement("zhima_freeze_reason")]
        public string ZhimaFreezeReason { get; set; }

        /// <summary>
        /// 商户在芝麻域的冻结状态 1:冻结 0:未冻结
        /// </summary>
        [XmlElement("zhima_freeze_status")]
        public string ZhimaFreezeStatus { get; set; }
    }
}
