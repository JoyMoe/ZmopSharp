using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// VisaBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VisaBasicInfo : ZmopObject
    {
        /// <summary>
        /// 中文生日
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 出生地
        /// </summary>
        [XmlElement("birthplace")]
        public string Birthplace { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 英文生日
        /// </summary>
        [XmlElement("en_birthday")]
        public string EnBirthday { get; set; }

        /// <summary>
        /// 英文出生地
        /// </summary>
        [XmlElement("en_birthplace")]
        public string EnBirthplace { get; set; }

        /// <summary>
        /// 英文证件号
        /// </summary>
        [XmlElement("en_cert_no")]
        public string EnCertNo { get; set; }

        /// <summary>
        /// 英文性别
        /// </summary>
        [XmlElement("en_gender")]
        public string EnGender { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
