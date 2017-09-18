using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditReportVisaGetResponse.
    /// </summary>
    public class ZhimaCreditReportVisaGetResponse : ZmopResponse
    {
        /// <summary>
        /// 资产模块
        /// </summary>
        [XmlArray("balance")]
        [XmlArrayItem("visa_element")]
        public List<VisaElement> Balance { get; set; }

        /// <summary>
        /// 用户基本信息
        /// </summary>
        [XmlElement("basic")]
        public VisaBasicInfo Basic { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [XmlElement("contact")]
        public VisaContact Contact { get; set; }

        /// <summary>
        /// 消费水平模块
        /// </summary>
        [XmlArray("cost")]
        [XmlArrayItem("visa_element")]
        public List<VisaElement> Cost { get; set; }

        /// <summary>
        /// 信贷等级模块
        /// </summary>
        [XmlElement("credit")]
        public VisaCredit Credit { get; set; }

        /// <summary>
        /// 教育信息
        /// </summary>
        [XmlElement("education")]
        public VisaEducation Education { get; set; }

        /// <summary>
        /// 缴费模块
        /// </summary>
        [XmlArray("fee")]
        [XmlArrayItem("visa_element")]
        public List<VisaElement> Fee { get; set; }

        /// <summary>
        /// 还款模块
        /// </summary>
        [XmlArray("repay")]
        [XmlArrayItem("visa_element")]
        public List<VisaElement> Repay { get; set; }

        /// <summary>
        /// 报告日期
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 芝麻分模块
        /// </summary>
        [XmlElement("score")]
        public VisaScore Score { get; set; }
    }
}
