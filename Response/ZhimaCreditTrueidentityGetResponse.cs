using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditTrueidentityGetResponse.
    /// </summary>
    public class ZhimaCreditTrueidentityGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 加密后的银行卡号
        /// </summary>
        [XmlElement("encrypted_card_no")]
        public string EncryptedCardNo { get; set; }

        /// <summary>
        /// 未返回真身id的原因  枚举：EMPTY_RESULT（默认值，真身id为空）           BINDED_CARD_IS_NULL （用户未绑卡）           IDENTITY_INFO_NOT_MATCH  （持卡人证件号与姓名与支付宝信息不完全匹配）           CARDHOLDER_HAS_NO_MOBILE（持卡人无手机号信息）           CERT_TYPE_INVALID（持卡人证件类型不支持）
        /// </summary>
        [XmlElement("info_code")]
        public string InfoCode { get; set; }

        /// <summary>
        /// 真身核实ID。
        /// </summary>
        [XmlElement("true_identity_id")]
        public string TrueIdentityId { get; set; }
    }
}
