using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantCreditlifePreauthUnfreezeResponse.
    /// </summary>
    public class ZhimaMerchantCreditlifePreauthUnfreezeResponse : ZmopResponse
    {
        /// <summary>
        /// true:解冻成功;false:失败
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 资金解冻时间
        /// </summary>
        [XmlElement("unfreeze_time")]
        public string UnfreezeTime { get; set; }
    }
}
