using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditDriverVerifyResponse.
    /// </summary>
    public class ZhimaCreditDriverVerifyResponse : ZmopResponse
    {
        /// <summary>
        /// 档案编号校验结果[1：匹配；0：不匹配；-1：未输入]
        /// </summary>
        [XmlElement("archive_no_verify_code")]
        public long ArchiveNoVerifyCode { get; set; }

        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 数据当前是否已经获取到
        /// </summary>
        [XmlElement("complete")]
        public bool Complete { get; set; }

        /// <summary>
        /// 驾驶证是否存在
        /// </summary>
        [XmlElement("exist")]
        public bool Exist { get; set; }

        /// <summary>
        /// 初次领证日期校验结果[1：匹配；0：不匹配；-1：未输入]
        /// </summary>
        [XmlElement("issue_date_verify_code")]
        public long IssueDateVerifyCode { get; set; }

        /// <summary>
        /// 姓名校验结果[1：匹配；0：不匹配；-1：未输入]
        /// </summary>
        [XmlElement("name_verify_code")]
        public long NameVerifyCode { get; set; }

        /// <summary>
        /// 驾驶证状态。具体枚举值见产品文档
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 准驾车型校验结果[1：匹配；0：不匹配；-1：未输入]
        /// </summary>
        [XmlElement("vehicle_class_verify_code")]
        public long VehicleClassVerifyCode { get; set; }
    }
}
