using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// TaxInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaxInfo : ZmopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("tax_invoice")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> TaxInvoice { get; set; }
    }
}
