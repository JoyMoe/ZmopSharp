using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// Edge Data Structure.
    /// </summary>
    [Serializable]
    public class Edge : ZmopObject
    {
        /// <summary>
        /// 认缴出资比例
        /// </summary>
        [XmlElement("funded_ratio")]
        public string FundedRatio { get; set; }

        /// <summary>
        /// 节点I的ID
        /// </summary>
        [XmlElement("i_node_id")]
        public string INodeId { get; set; }

        /// <summary>
        /// 边表ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 节点J的ID
        /// </summary>
        [XmlElement("j_node_id")]
        public string JNodeId { get; set; }

        /// <summary>
        /// 强弱程度
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 强弱程度指数
        /// </summary>
        [XmlElement("level_index")]
        public string LevelIndex { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("reg_cap_cur")]
        public string RegCapCur { get; set; }

        /// <summary>
        /// 关系类型
        /// </summary>
        [XmlElement("relation_type")]
        public string RelationType { get; set; }

        /// <summary>
        /// 认缴出资额
        /// </summary>
        [XmlElement("sub_conam")]
        public string SubConam { get; set; }
    }
}
