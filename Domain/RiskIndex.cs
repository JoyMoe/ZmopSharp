using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// RiskIndex Data Structure.
    /// </summary>
    [Serializable]
    public class RiskIndex : ZmopObject
    {
        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 一级行业代码
        /// </summary>
        [XmlElement("industry_code_one")]
        public string IndustryCodeOne { get; set; }

        /// <summary>
        /// 二级行业代码
        /// </summary>
        [XmlElement("industry_code_two")]
        public string IndustryCodeTwo { get; set; }

        /// <summary>
        /// 从201401开始，每月对应的风险指数
        /// </summary>
        [XmlArray("month_risk_index")]
        [XmlArrayItem("month_risk_index")]
        public List<MonthRiskIndex> MonthRiskIndex { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }
    }
}
