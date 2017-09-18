using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// CaseSeriesList Data Structure.
    /// </summary>
    [Serializable]
    public class CaseSeriesList : ZmopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("case_series_list")]
        [XmlArrayItem("case_series")]
        public List<CaseSeries> CaseSeriesList_ { get; set; }
    }
}
