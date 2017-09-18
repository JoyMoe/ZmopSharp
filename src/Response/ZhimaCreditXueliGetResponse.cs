using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditXueliGetResponse.
    /// </summary>
    public class ZhimaCreditXueliGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 院校名称
        /// </summary>
        [XmlElement("college_name")]
        public string CollegeName { get; set; }

        /// <summary>
        /// 学历类别：普通，研究生，成人，高等教育自学考试，网络教育，开放教育，不详
        /// </summary>
        [XmlElement("education_category")]
        public string EducationCategory { get; set; }

        /// <summary>
        /// 学历层次： 博士研究生，硕士研究生，研究生班， 第二学士学位，本科，高升本，专升本，第二本科 专科，专科(高职)，第二专科，夜大电大函大普通班，大学
        /// </summary>
        [XmlElement("education_degree")]
        public string EducationDegree { get; set; }

        /// <summary>
        /// 是否有学历。有，返回true，无，返回false
        /// </summary>
        [XmlElement("exist")]
        public bool Exist { get; set; }

        /// <summary>
        /// 毕业日期
        /// </summary>
        [XmlElement("graduate_year")]
        public string GraduateYear { get; set; }

        /// <summary>
        /// 专业名称
        /// </summary>
        [XmlElement("major_name")]
        public string MajorName { get; set; }
    }
}
