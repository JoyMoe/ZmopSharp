using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditCardPermitResponse.
    /// </summary>
    public class ZhimaCreditCardPermitResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 是否准入
        /// </summary>
        [XmlElement("is_passed")]
        public bool IsPassed { get; set; }
    }
}
