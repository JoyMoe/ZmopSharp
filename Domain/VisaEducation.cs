using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// VisaEducation Data Structure.
    /// </summary>
    [Serializable]
    public class VisaEducation : ZmopObject
    {
        /// <summary>
        /// 学历
        /// </summary>
        [XmlElement("degree")]
        public string Degree { get; set; }

        /// <summary>
        /// 英文学历
        /// </summary>
        [XmlElement("en_degree")]
        public string EnDegree { get; set; }

        /// <summary>
        /// 英文毕业时间
        /// </summary>
        [XmlElement("en_graduate")]
        public string EnGraduate { get; set; }

        /// <summary>
        /// 英文毕业学校
        /// </summary>
        [XmlElement("en_school")]
        public string EnSchool { get; set; }

        /// <summary>
        /// 毕业时间
        /// </summary>
        [XmlElement("graduate")]
        public string Graduate { get; set; }

        /// <summary>
        /// 毕业学校
        /// </summary>
        [XmlElement("school")]
        public string School { get; set; }
    }
}
