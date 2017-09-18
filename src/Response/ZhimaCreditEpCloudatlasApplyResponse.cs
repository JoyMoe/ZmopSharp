using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCloudatlasApplyResponse.
    /// </summary>
    public class ZhimaCreditEpCloudatlasApplyResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 云图编码
        /// </summary>
        [XmlElement("cloudatlas_code")]
        public string CloudatlasCode { get; set; }
    }
}
