using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantExpandQueryResponse.
    /// </summary>
    public class ZhimaMerchantExpandQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 浙江飞猪网络技术有限公司，企业别称请填写【飞猪】
        /// </summary>
        [XmlElement("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 为用户提供服务的支付宝服务窗名称，如有请填写 支付宝服务窗，微信公众号，网站地址，应用名称必须是4选1
        /// </summary>
        [XmlElement("alipay_window_name")]
        public string AlipayWindowName { get; set; }

        /// <summary>
        /// 为用户提供服务的手机应用，如有请填写 支付宝服务窗，微信公众号，网站地址，应用名称必须是4选1
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 审核失败的具体原因
        /// </summary>
        [XmlElement("audit_fail_reason")]
        public string AuditFailReason { get; set; }

        /// <summary>
        /// 审核状态： Y:通过 N:不通过 ING:审批中
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 签约芝麻信用产品的用途，最多5个场景，ISV可以自定义
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 数据反馈联系人邮箱地址(使用芝麻信用评分、行业关注名单时，联动解决数据问题的接口人。)
        /// </summary>
        [XmlElement("data_feedback_contract_email")]
        public string DataFeedbackContractEmail { get; set; }

        /// <summary>
        /// 数据反馈联系人手机号码(使用芝麻信用评分、行业关注名单时，联动解决数据问题的接口人。)
        /// </summary>
        [XmlElement("data_feedback_contract_mobile")]
        public string DataFeedbackContractMobile { get; set; }

        /// <summary>
        /// 数据反馈联系人姓名(使用芝麻信用评分、行业关注名单时，联动解决数据问题的接口人。)
        /// </summary>
        [XmlElement("data_feedback_contract_name")]
        public string DataFeedbackContractName { get; set; }

        /// <summary>
        /// 商户的支付宝userId
        /// </summary>
        [XmlElement("linked_merchant_id")]
        public string LinkedMerchantId { get; set; }

        /// <summary>
        /// 主要联系人邮箱地址(联系人将用于接收重要通知，如签约进度、技术集成、合同到期等)
        /// </summary>
        [XmlElement("major_contract_email")]
        public string MajorContractEmail { get; set; }

        /// <summary>
        /// 主要联系人手机号码(联系人将用于接收重要通知，如签约进度、技术集成、合同到期等)
        /// </summary>
        [XmlElement("major_contract_mobile")]
        public string MajorContractMobile { get; set; }

        /// <summary>
        /// 主要联系人姓名(联系人将用于接收重要通知，如签约进度、技术集成、合同到期等)
        /// </summary>
        [XmlElement("major_contract_name")]
        public string MajorContractName { get; set; }

        /// <summary>
        /// 异议处理联系人邮箱地址(用户对所披露的负面信息存在异议时，联动核查的接口人)
        /// </summary>
        [XmlElement("objection_contract_email")]
        public string ObjectionContractEmail { get; set; }

        /// <summary>
        /// 异议处理联系人手机号码(用户对所披露的负面信息存在异议时，联动核查的接口人)
        /// </summary>
        [XmlElement("objection_contract_mobile")]
        public string ObjectionContractMobile { get; set; }

        /// <summary>
        /// 异议处理联系人姓名(用户对所披露的负面信息存在异议时，联动核查的接口人)
        /// </summary>
        [XmlElement("objection_contract_name")]
        public string ObjectionContractName { get; set; }

        /// <summary>
        /// 芝麻特定的商户一级行业归属，比如生活行业，金融行业，政府行业
        /// </summary>
        [XmlElement("one_level_mcc")]
        public string OneLevelMcc { get; set; }

        /// <summary>
        /// 服务联动联系人邮箱地址(联动解决用户服务相关问题的接口人。比如用户投诉或出现重大服务事件时，可以协调解决问题的联系人)
        /// </summary>
        [XmlElement("service_contract_email")]
        public string ServiceContractEmail { get; set; }

        /// <summary>
        /// 服务联动联系人手机号码(联动解决用户服务相关问题的接口人。比如用户投诉或出现重大服务事件时，可以协调解决问题的联系人)
        /// </summary>
        [XmlElement("service_contract_mobile")]
        public string ServiceContractMobile { get; set; }

        /// <summary>
        /// 服务联动联系人姓名(联动解决用户服务相关问题的接口人。比如用户投诉或出现重大服务事件时，可以协调解决问题的联系人)
        /// </summary>
        [XmlElement("service_contract_name")]
        public string ServiceContractName { get; set; }

        /// <summary>
        /// 芝麻特有的商户二级行业归属，比如汽车服务
        /// </summary>
        [XmlElement("two_level_mcc")]
        public string TwoLevelMcc { get; set; }

        /// <summary>
        /// 用户提供服务的微信公众号，如有请填写 支付宝服务窗，微信公众号，网站地址，应用名称必须是4选1
        /// </summary>
        [XmlElement("webchat_amount")]
        public string WebchatAmount { get; set; }

        /// <summary>
        /// 为用户提供服务的网站，如有请填写 支付宝服务窗，微信公众号，网站地址，应用名称必须是4选1
        /// </summary>
        [XmlElement("websit_url")]
        public string WebsitUrl { get; set; }

        /// <summary>
        /// 商户在芝麻域认证状态： 1:已认证 0:未认证
        /// </summary>
        [XmlElement("zhima_certify_status")]
        public string ZhimaCertifyStatus { get; set; }

        /// <summary>
        /// 商户被芝麻冻结的原因
        /// </summary>
        [XmlElement("zhima_freeze_reason")]
        public string ZhimaFreezeReason { get; set; }

        /// <summary>
        /// 商户在芝麻域的冻结状态 1:冻结 0:未冻结
        /// </summary>
        [XmlElement("zhima_freeze_status")]
        public string ZhimaFreezeStatus { get; set; }
    }
}
