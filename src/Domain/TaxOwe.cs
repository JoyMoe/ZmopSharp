using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// TaxOwe Data Structure.
    /// </summary>
    [Serializable]
    public class TaxOwe : ZmopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("tax_owe")]
        [XmlArrayItem("ep_element")]
        public List<EpElement> TaxOwe_ { get; set; }
    }
}
