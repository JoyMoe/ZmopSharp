using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantDataUploadInitializeResponse.
    /// </summary>
    public class ZhimaMerchantDataUploadInitializeResponse : ZmopResponse
    {
        /// <summary>
        /// 模板文件url地址
        /// </summary>
        [XmlElement("template_url")]
        public string TemplateUrl { get; set; }
    }
}
