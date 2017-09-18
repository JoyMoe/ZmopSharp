using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditXueliVerifyResponse.
    /// </summary>
    public class ZhimaCreditXueliVerifyResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 学历类别验证结果。 CE1000 表示未知或无数据  CE1001 表示正确  CE1002 表示错误
        /// </summary>
        [XmlElement("edu_category_verify_result")]
        public string EduCategoryVerifyResult { get; set; }

        /// <summary>
        /// 院校名称验证结果。 CE1000 表示未知或无数据  CE1001 表示正确  CE1002 表示错误
        /// </summary>
        [XmlElement("edu_college_verify_result")]
        public string EduCollegeVerifyResult { get; set; }

        /// <summary>
        /// 学习层次验证结果。 CE1000 表示未知或无数据 CE1001 表示正确 CE1002 表示错误
        /// </summary>
        [XmlElement("edu_degree_verify_result")]
        public string EduDegreeVerifyResult { get; set; }

        /// <summary>
        /// 毕业年份验证结果。 CE1000 表示未知或无数据  CE1001 表示正确  CE1002 表示错误
        /// </summary>
        [XmlElement("edu_graduate_year_verify_result")]
        public string EduGraduateYearVerifyResult { get; set; }
    }
}
