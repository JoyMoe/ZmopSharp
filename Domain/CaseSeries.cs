using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// CaseSeries Data Structure.
    /// </summary>
    [Serializable]
    public class CaseSeries : ZmopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("case_series")]
        [XmlArrayItem("ep_element")]
        public List<EpElement> CaseSeries_ { get; set; }
    }
}
