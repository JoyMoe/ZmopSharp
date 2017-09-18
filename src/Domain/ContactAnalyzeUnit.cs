using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// ContactAnalyzeUnit Data Structure.
    /// </summary>
    [Serializable]
    public class ContactAnalyzeUnit : ZmopObject
    {
        /// <summary>
        /// 关系人信息分析覆盖人数
        /// </summary>
        [XmlElement("coverage")]
        public string Coverage { get; set; }

        /// <summary>
        /// name 指标名称, 目前有以下三个取值： - 芝麻分均值  avg_score  - 6个月授权金融机构的平均值  avg_auth_fin_last_6m_cnt - 6个月逾期的平均值  avg_ovd_order_6m_cnt
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 关系人分析查询 name 对应属性的分析值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
