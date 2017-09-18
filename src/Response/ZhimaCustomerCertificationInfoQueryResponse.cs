using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerCertificationInfoQueryResponse.
    /// </summary>
    public class ZhimaCustomerCertificationInfoQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 认证场景码,有如下几种场景: －“FACE_SDK”：认证严格度适中，建议对应各类对身份顶替风险容忍度较低的业务场景，比如各类与资金或密码没有关系的场景 －“FACE_SDK_STRICT”：认证严格度高，建议对应各类对身份顶替风险容忍度极低的业务场景，比如修改密码、大额交易、资金管理
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 要认证的身份信息，包含证件类型、证件名、证件号
        /// </summary>
        [XmlElement("certify_identity")]
        public string CertifyIdentity { get; set; }

        /// <summary>
        /// 要认证的商户信息
        /// </summary>
        [XmlElement("certify_merchant")]
        public string CertifyMerchant { get; set; }

        /// <summary>
        /// 扩展业务信息
        /// </summary>
        [XmlElement("ext_biz_info")]
        public string ExtBizInfo { get; set; }

        /// <summary>
        /// 认证是否已经通过
        /// </summary>
        [XmlElement("passed")]
        public string Passed { get; set; }

        /// <summary>
        /// 商户回调地址
        /// </summary>
        [XmlElement("return_url")]
        public string ReturnUrl { get; set; }
    }
}
