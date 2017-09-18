using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// TaxOweList Data Structure.
    /// </summary>
    [Serializable]
    public class TaxOweList : ZmopObject
    {
        /// <summary>
        /// 欠税信息列表
        /// </summary>
        [XmlArray("tax_owe_list")]
        [XmlArrayItem("tax_owe")]
        public List<TaxOwe> TaxOweList_ { get; set; }
    }
}
