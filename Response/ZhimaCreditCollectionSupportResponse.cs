using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditCollectionSupportResponse.
    /// </summary>
    public class ZhimaCreditCollectionSupportResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 是否有效联系方式：有（true)／无(false)
        /// </summary>
        [XmlElement("is_matched")]
        public bool IsMatched { get; set; }

        /// <summary>
        /// 虚拟号码（阿里小号）
        /// </summary>
        [XmlElement("virtual_number")]
        public string VirtualNumber { get; set; }
    }
}
