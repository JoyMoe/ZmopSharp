using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// CompanyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyInfo : ZmopObject
    {
        /// <summary>
        /// 企业历史变更信息
        /// </summary>
        [XmlArray("alter_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> AlterList { get; set; }

        /// <summary>
        /// 企业基本信息
        /// </summary>
        [XmlElement("basic_info")]
        public EpInfo BasicInfo { get; set; }

        /// <summary>
        /// 行政处罚历史信息
        /// </summary>
        [XmlArray("case_info_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> CaseInfoList { get; set; }

        /// <summary>
        /// 企业对外投资信息
        /// </summary>
        [XmlArray("entinv_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> EntinvList { get; set; }

        /// <summary>
        /// 企业法定代表人其他公司任职信息
        /// </summary>
        [XmlArray("fr_position_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> FrPositionList { get; set; }

        /// <summary>
        /// 企业法定代表人对外投资信息
        /// </summary>
        [XmlArray("frinv_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> FrinvList { get; set; }

        /// <summary>
        /// 企业主要管理人员信息
        /// </summary>
        [XmlArray("person_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> PersonList { get; set; }

        /// <summary>
        /// 企业股东及出资信息
        /// </summary>
        [XmlArray("share_holder_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> ShareHolderList { get; set; }
    }
}
