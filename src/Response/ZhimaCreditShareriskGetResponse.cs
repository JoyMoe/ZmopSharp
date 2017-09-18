using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditShareriskGetResponse.
    /// </summary>
    public class ZhimaCreditShareriskGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用户详细信息
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("share_risk_detail")]
        public List<ShareRiskDetail> Details { get; set; }

        /// <summary>
        /// 最近30天该用户被查询次数
        /// </summary>
        [XmlElement("stat_month")]
        public long StatMonth { get; set; }

        /// <summary>
        /// 最近90天该用户被查询次数
        /// </summary>
        [XmlElement("stat_quarter")]
        public long StatQuarter { get; set; }

        /// <summary>
        /// 最近3天该用户被查询次数
        /// </summary>
        [XmlElement("stat_three_day")]
        public long StatThreeDay { get; set; }

        /// <summary>
        /// 最近7天该用户被查询次数
        /// </summary>
        [XmlElement("stat_week")]
        public long StatWeek { get; set; }
    }
}
