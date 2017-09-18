using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// Vertex Data Structure.
    /// </summary>
    [Serializable]
    public class Vertex : ZmopObject
    {
        /// <summary>
        /// 证件名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 企业注册号
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 企业地址
        /// </summary>
        [XmlElement("dom")]
        public string Dom { get; set; }

        /// <summary>
        /// 企业的状态
        /// </summary>
        [XmlElement("ent_status")]
        public string EntStatus { get; set; }

        /// <summary>
        /// 企业类型
        /// </summary>
        [XmlElement("ent_type")]
        public string EntType { get; set; }

        /// <summary>
        /// 点表的ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 是否在关注名单内
        /// </summary>
        [XmlElement("in_black_list")]
        public string InBlackList { get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [XmlElement("reg_cap")]
        public string RegCap { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("reg_cap_cur")]
        public string RegCapCur { get; set; }

        /// <summary>
        /// 登记单位
        /// </summary>
        [XmlElement("reg_org")]
        public string RegOrg { get; set; }

        /// <summary>
        /// 关联层级
        /// </summary>
        [XmlElement("relation_level")]
        public string RelationLevel { get; set; }

        /// <summary>
        /// 风险指数
        /// </summary>
        [XmlElement("risk_index")]
        public string RiskIndex { get; set; }
    }
}
