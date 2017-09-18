using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditXuejiVerifyResponse.
    /// </summary>
    public class ZhimaCreditXuejiVerifyResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 学历类别验证结果。 CE1000 表示未知或无数据 CE1001 表示正确 CE1002 表示错误
        /// </summary>
        [XmlElement("edu_category_verify_result")]
        public string EduCategoryVerifyResult { get; set; }

        /// <summary>
        /// 院校名称验证结果。  CE1000 表示未知或无数据  CE1001 表示正确  CE1002 表示错误
        /// </summary>
        [XmlElement("edu_college_verify_result")]
        public string EduCollegeVerifyResult { get; set; }

        /// <summary>
        /// 学习层次验证结果。  CE1000 表示未知或无数据 CE1001 表示正确 CE1002 表示错误
        /// </summary>
        [XmlElement("edu_degree_verify_result")]
        public string EduDegreeVerifyResult { get; set; }

        /// <summary>
        /// 入学年份验证结果。 CE1000 表示未知或无数据  CE1001 表示正确  CE1002 表示错误
        /// </summary>
        [XmlElement("edu_enrollment_year_verify_result")]
        public string EduEnrollmentYearVerifyResult { get; set; }

        /// <summary>
        /// 毕业年份验证结果。  CE1000 表示未知或无数据 CE1001 表示正确 CE1002 表示错误
        /// </summary>
        [XmlElement("edu_graduate_year_verify_result")]
        public string EduGraduateYearVerifyResult { get; set; }

        /// <summary>
        /// 学籍是否存在 true 存在 false 不存在
        /// </summary>
        [XmlElement("exist")]
        public bool Exist { get; set; }

        /// <summary>
        /// 毕业年份。只有当学籍存在，且各项校验值都正确的情况下，才会返回该字段。
        /// </summary>
        [XmlElement("graduate_year")]
        public string GraduateYear { get; set; }
    }
}
