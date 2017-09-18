using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantOrderConfirmResponse.
    /// </summary>
    public class ZhimaMerchantOrderConfirmResponse : ZmopResponse
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 身份证签发机关
        /// </summary>
        [XmlElement("cert_city")]
        public string CertCity { get; set; }

        /// <summary>
        /// 身份证有效期
        /// </summary>
        [XmlElement("cert_indate")]
        public string CertIndate { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 常驻城市
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 单位地址
        /// </summary>
        [XmlElement("company_address")]
        public string CompanyAddress { get; set; }

        /// <summary>
        /// 单位电话
        /// </summary>
        [XmlElement("company_contact")]
        public string CompanyContact { get; set; }

        /// <summary>
        /// 单位名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 单位性质
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 父母、配偶、子女、兄弟／姐妹、其他
        /// </summary>
        [XmlElement("contact_relation")]
        public string ContactRelation { get; set; }

        /// <summary>
        /// 任职部门
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 直亲关系
        /// </summary>
        [XmlElement("direct_relation")]
        public string DirectRelation { get; set; }

        /// <summary>
        /// 直亲手机号
        /// </summary>
        [XmlElement("direct_relation_mobile")]
        public string DirectRelationMobile { get; set; }

        /// <summary>
        /// 直亲姓名
        /// </summary>
        [XmlElement("direct_relation_name")]
        public string DirectRelationName { get; set; }

        /// <summary>
        /// 教育程度
        /// </summary>
        [XmlElement("education_degree")]
        public string EducationDegree { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 住宅地址
        /// </summary>
        [XmlElement("house")]
        public string House { get; set; }

        /// <summary>
        /// 住宅性质
        /// </summary>
        [XmlElement("house_type")]
        public string HouseType { get; set; }

        /// <summary>
        /// 行业类型
        /// </summary>
        [XmlElement("industry_type")]
        public string IndustryType { get; set; }

        /// <summary>
        /// ivs产品明细数据
        /// </summary>
        [XmlElement("ivs_details")]
        public string IvsDetails { get; set; }

        /// <summary>
        /// 邮寄地址 1：住宅地址 2：工作地址
        /// </summary>
        [XmlElement("mailing_address")]
        public string MailingAddress { get; set; }

        /// <summary>
        /// 婚姻状况
        /// </summary>
        [XmlElement("marriage_status")]
        public string MarriageStatus { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 姓名拼音
        /// </summary>
        [XmlElement("name_spell")]
        public string NameSpell { get; set; }

        /// <summary>
        /// 职业说明
        /// </summary>
        [XmlElement("occupation")]
        public string Occupation { get; set; }

        /// <summary>
        /// 用户在商端的身份标识 如果在接口的入参中存在该参数，芝麻网关会自动转化成roleId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 护照号
        /// </summary>
        [XmlElement("passport_no")]
        public string PassportNo { get; set; }

        /// <summary>
        /// 职位级别
        /// </summary>
        [XmlElement("position_level")]
        public string PositionLevel { get; set; }

        /// <summary>
        /// 税后年收入
        /// </summary>
        [XmlElement("taxed_income")]
        public string TaxedIncome { get; set; }

        /// <summary>
        /// 支付宝userid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 签证报告数据
        /// </summary>
        [XmlElement("visa_report")]
        public string VisaReport { get; set; }

        /// <summary>
        /// 行业关注名单产品明细数据
        /// </summary>
        [XmlElement("watchlist_detail")]
        public string WatchlistDetail { get; set; }

        /// <summary>
        /// 现单位工作年限
        /// </summary>
        [XmlElement("worked_years")]
        public string WorkedYears { get; set; }

        /// <summary>
        /// 人脸核身结果
        /// </summary>
        [XmlElement("zm_face")]
        public string ZmFace { get; set; }

        /// <summary>
        /// 人脸验证拍摄的图片
        /// </summary>
        [XmlElement("zm_face_pic")]
        public string ZmFacePic { get; set; }

        /// <summary>
        /// 芝麻风控产品集联合结果
        /// </summary>
        [XmlElement("zm_risk")]
        public string ZmRisk { get; set; }

        /// <summary>
        /// 芝麻分
        /// </summary>
        [XmlElement("zm_score")]
        public string ZmScore { get; set; }
    }
}
