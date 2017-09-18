using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// IvsDetail Data Structure.
    /// </summary>
    [Serializable]
    public class IvsDetail : ZmopObject
    {
        /// <summary>
        /// 风险因素code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 风险描述说明
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }
    }
}
