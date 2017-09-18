using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantImageUploadResponse.
    /// </summary>
    public class ZhimaMerchantImageUploadResponse : ZmopResponse
    {
        /// <summary>
        /// 图片在芝麻存储中的url地址
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }
    }
}
