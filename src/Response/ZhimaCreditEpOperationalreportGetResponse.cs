using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpOperationalreportGetResponse.
    /// </summary>
    public class ZhimaCreditEpOperationalreportGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 0:表示经营报告无效 1:表示经营报告有效
        /// </summary>
        [XmlElement("is_valid")]
        public string IsValid { get; set; }

        /// <summary>
        /// 经营报告数据列表
        /// </summary>
        [XmlArray("report_data")]
        [XmlArrayItem("operational_report")]
        public List<OperationalReport> ReportData { get; set; }
    }
}
