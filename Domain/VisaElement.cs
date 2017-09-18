using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// VisaElement Data Structure.
    /// </summary>
    [Serializable]
    public class VisaElement : ZmopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 月份
        /// </summary>
        [XmlElement("month")]
        public string Month { get; set; }
    }
}
