using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditContactGetResponse.
    /// </summary>
    public class ZhimaCreditContactGetResponse : ZmopResponse
    {
        /// <summary>
        /// 返回的用户的地址信息。可能有多个地址，使用|分隔
        /// </summary>
        [XmlElement("addresses")]
        public string Addresses { get; set; }

        /// <summary>
        /// 扩展字段，目前返回null
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用户的电话号码。可能存在多个，以|分隔
        /// </summary>
        [XmlElement("mobiles")]
        public string Mobiles { get; set; }

        /// <summary>
        /// 1：返回信息多于用户传入的信息，例如，假设用户传入了一组手机/地址信息，查询返回的信息经过比对后信息多于用户传入的信息，则返回1  0：无返回信息或者返回信息和用户传入信息一致
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
