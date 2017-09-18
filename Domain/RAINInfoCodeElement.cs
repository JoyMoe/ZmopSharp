using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// RAINInfoCodeElement Data Structure.
    /// </summary>
    [Serializable]
    public class RAINInfoCodeElement : ZmopObject
    {
        /// <summary>
        /// 风险代码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 风险解释
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 风险名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
