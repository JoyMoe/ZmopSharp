using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// ZmScoreInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmScoreInfo : ZmopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlElement("zm_score")]
        public string ZmScore { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlElement("zm_score_change")]
        public string ZmScoreChange { get; set; }
    }
}
