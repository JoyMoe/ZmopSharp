using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.merchant.enterprise.apply
    /// </summary>
    public class ZhimaMerchantEnterpriseApplyRequest : IZmopRequest<ZhimaMerchantEnterpriseApplyResponse>
    {
        /// <summary>
        /// 商户别名
        /// </summary>
        public string AliasName { get; set; }

        /// <summary>
        /// 为用户提供服务的支付宝服务窗名称，如有请填写 支付宝服务窗，微信公众号，网站地址，应用名称必须是4选1
        /// </summary>
        public string AlipayWindowName { get; set; }

        /// <summary>
        /// 为用户提供服务的手机应用，如有请填写 支付宝服务窗，微信公众号，网站地址，应用名称必须是4选1
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 用于记录本次提交信息中，那些字段有所调整
        /// </summary>
        public string ApplyMemo { get; set; }

        /// <summary>
        /// 业务授权书url，请通过zhima.merchant.image.upload上传文件；在商户类型为政府机构或者事业单位时，与证照图片二选一；在商户类型为企业时，与法人信息二选一
        /// </summary>
        public string AuthLetterUrl { get; set; }

        /// <summary>
        /// 签约芝麻信用产品的用途，最多5个场景，ISV可以自定义
        /// </summary>
        public string BizScene { get; set; }

        /// <summary>
        /// 企业地址
        /// </summary>
        public string CompanyAddress { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 数据反馈联系人邮箱地址(使用芝麻信用评分、行业关注名单时，联动解决数据问题的接口人。)
        /// </summary>
        public string DataFeedbackContractEmail { get; set; }

        /// <summary>
        /// 数据反馈联系人手机号码(使用芝麻信用评分、行业关注名单时，联动解决数据问题的接口人。)
        /// </summary>
        public string DataFeedbackContractMobile { get; set; }

        /// <summary>
        /// 数据反馈联系人姓名(使用芝麻信用评分、行业关注名单时，联动解决数据问题的接口人。)
        /// </summary>
        public string DataFeedbackContractName { get; set; }

        /// <summary>
        /// 证照结束日期 9999-12-31   代表长期
        /// </summary>
        public string EndBusinessDate { get; set; }

        /// <summary>
        /// 法人身份证号码 在商户类型为企业时，与业务授权书二选一
        /// </summary>
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法人身份证反面图片url 请通过zhima.merchant.image.upload上传文件; 在商户类型为企业时，与业务授权书二选一
        /// </summary>
        public string LegalCertNoBackImageUrl { get; set; }

        /// <summary>
        /// 法人身份证正面图片url 请通过zhima.merchant.image.upload上传文件; 在商户类型为企业时，与业务授权书二选一
        /// </summary>
        public string LegalCertNoFrontImageUrl { get; set; }

        /// <summary>
        /// 法人身份证有效期结束日期; 在商户类型为企业时，与业务授权书二选一
        /// </summary>
        public string LegalCertValidEndDate { get; set; }

        /// <summary>
        /// 法人身份证有效期开始日期; 在商户类型为企业时，与业务授权书二选一
        /// </summary>
        public string LegalCertValidStartDate { get; set; }

        /// <summary>
        /// 法人姓名 在商户类型为企业时，与业务授权书二选一
        /// </summary>
        public string LegalName { get; set; }

        /// <summary>
        /// 证照图片url，请通过zhima.merchant.image.upload上传对应证照类型的图片，在商户类型为政府机构或者事业单位时，与业务授权书二选一
        /// </summary>
        public string LicenseImageUrl { get; set; }

        /// <summary>
        /// 证照号码
        /// </summary>
        public string LicenseNo { get; set; }

        /// <summary>
        /// 证照类型： 1:普通营业执照 2:多证合一 3:组织结构代码证 4:其他证照 company_type=1时，证照类型只能选择1和2； company_type=2,3时，证照类型只能选择3和4
        /// </summary>
        public string LicenseType { get; set; }

        /// <summary>
        /// 芝麻二级商户图标的二进制流,最大100K(80*80),需要对图片的二进制流做Base64处理转化成字符串
        /// </summary>
        public string LogoImage { get; set; }

        /// <summary>
        /// 芝麻二级商户图标后缀：bmp, jpg, jpeg, png, gif
        /// </summary>
        public string LogoImageType { get; set; }

        /// <summary>
        /// 主要联系人邮箱地址(联系人将用于接收重要通知，如签约进度、技术集成、合同到期等)
        /// </summary>
        public string MajorContractEmail { get; set; }

        /// <summary>
        /// 主要联系人手机号码(联系人将用于接收重要通知，如签约进度、技术集成、合同到期等)
        /// </summary>
        public string MajorContractMobile { get; set; }

        /// <summary>
        /// 主要联系人姓名(联系人将用于接收重要通知，如签约进度、技术集成、合同到期等)
        /// </summary>
        public string MajorContractName { get; set; }

        /// <summary>
        /// 商户类型 1:企业 2:政府机构 3:事业单位
        /// </summary>
        public string MerchantType { get; set; }

        /// <summary>
        /// 异议处理联系人邮箱地址(用户对所披露的负面信息存在异议时，联动核查的接口人)
        /// </summary>
        public string ObjectionContractEmail { get; set; }

        /// <summary>
        /// 异议处理联系人手机号码(用户对所披露的负面信息存在异议时，联动核查的接口人)
        /// </summary>
        public string ObjectionContractMobile { get; set; }

        /// <summary>
        /// 异议处理联系人姓名(用户对所披露的负面信息存在异议时，联动核查的接口人)
        /// </summary>
        public string ObjectionContractName { get; set; }

        /// <summary>
        /// 芝麻商户一级行业归属，芝麻提供
        /// </summary>
        public string OneLevelMcc { get; set; }

        /// <summary>
        /// 组织结构代码证图片url,营业执照时普通类型时(废弃)
        /// </summary>
        public string OrganizationImageUrl { get; set; }

        /// <summary>
        /// 组织机构代码，营业执照时普通类型时(废弃)
        /// </summary>
        public string OrganizationNo { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 代理人身份证号码(废弃)
        /// </summary>
        public string ProxyCertNo { get; set; }

        /// <summary>
        /// 代理人身份证反面图片url(废弃)
        /// </summary>
        public string ProxyCertNoBackImageUrl { get; set; }

        /// <summary>
        /// 代理人身份证正面图片url(废弃)
        /// </summary>
        public string ProxyCertNoFrontImageUrl { get; set; }

        /// <summary>
        /// 代理人身份证有效期结束日期(废弃)
        /// </summary>
        public string ProxyCertValidEndDate { get; set; }

        /// <summary>
        /// 代理人身份证有效期开始日期(废弃)
        /// </summary>
        public string ProxyCertValidStartDate { get; set; }

        /// <summary>
        /// 代理人委托书url地址(废弃)
        /// </summary>
        public string ProxyMandateUrl { get; set; }

        /// <summary>
        /// 代理人姓名(废弃)
        /// </summary>
        public string ProxyName { get; set; }

        /// <summary>
        /// 业务许可证图片url 请通过zhima.merchant.image.upload上传文件
        /// </summary>
        public string QualificationImageUrl { get; set; }

        /// <summary>
        /// 服务联动联系人邮箱地址(联动解决用户服务相关问题的接口人。比如用户投诉或出现重大服务事件时，可以协调解决问题的联系人)
        /// </summary>
        public string ServiceContractEmail { get; set; }

        /// <summary>
        /// 服务联动联系人手机号码(联动解决用户服务相关问题的接口人。比如用户投诉或出现重大服务事件时，可以协调解决问题的联系人)
        /// </summary>
        public string ServiceContractMobile { get; set; }

        /// <summary>
        /// 服务联动联系人姓名(联动解决用户服务相关问题的接口人。比如用户投诉或出现重大服务事件时，可以协调解决问题的联系人)
        /// </summary>
        public string ServiceContractName { get; set; }

        /// <summary>
        /// 证照开始日期
        /// </summary>
        public string StartBusinessDate { get; set; }

        /// <summary>
        /// 芝麻商户二级行业归属，芝麻提供
        /// </summary>
        public string TwoLevelMcc { get; set; }

        /// <summary>
        /// 用户提供服务的微信公众号，如有请填写 支付宝服务窗，微信公众号，网站地址，应用名称必须是4选1
        /// </summary>
        public string WebchatAmount { get; set; }

        /// <summary>
        /// 为用户提供服务的网站，如有请填写 支付宝服务窗，微信公众号，网站地址，应用名称必须是4选1
        /// </summary>
        public string WebsitUrl { get; set; }

        #region IZmopRequest Members
        private string apiVersion = "1.0";
		private string channel;
		private string platform;
        private string scene;
		private string extParams;

		public void SetChannel(string channel){
            this.channel = channel;
        }

        public string GetChannel(){
            return this.channel;
        }

        public void SetPlatform(String platform){
			this.platform=platform;
		}

    	public string GetPlatform(){
    		return this.platform;
    	}

    	public void SetScene(String scene){
    		this.scene=scene;
    	}

    	public string GetScene(){
    		return this.scene;
    	}

        public void SetExtParams(String extParams){
            this.extParams=extParams;
        }

        public string GetExtParams(){
            return this.extParams;
        }

        public string GetApiName()
        {
            return "zhima.merchant.enterprise.apply";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            ZmopDictionary parameters = new ZmopDictionary();
            parameters.Add("alias_name", this.AliasName);
            parameters.Add("alipay_window_name", this.AlipayWindowName);
            parameters.Add("app_name", this.AppName);
            parameters.Add("apply_memo", this.ApplyMemo);
            parameters.Add("auth_letter_url", this.AuthLetterUrl);
            parameters.Add("biz_scene", this.BizScene);
            parameters.Add("company_address", this.CompanyAddress);
            parameters.Add("company_name", this.CompanyName);
            parameters.Add("data_feedback_contract_email", this.DataFeedbackContractEmail);
            parameters.Add("data_feedback_contract_mobile", this.DataFeedbackContractMobile);
            parameters.Add("data_feedback_contract_name", this.DataFeedbackContractName);
            parameters.Add("end_business_date", this.EndBusinessDate);
            parameters.Add("legal_cert_no", this.LegalCertNo);
            parameters.Add("legal_cert_no_back_image_url", this.LegalCertNoBackImageUrl);
            parameters.Add("legal_cert_no_front_image_url", this.LegalCertNoFrontImageUrl);
            parameters.Add("legal_cert_valid_end_date", this.LegalCertValidEndDate);
            parameters.Add("legal_cert_valid_start_date", this.LegalCertValidStartDate);
            parameters.Add("legal_name", this.LegalName);
            parameters.Add("license_image_url", this.LicenseImageUrl);
            parameters.Add("license_no", this.LicenseNo);
            parameters.Add("license_type", this.LicenseType);
            parameters.Add("logo_image", this.LogoImage);
            parameters.Add("logo_image_type", this.LogoImageType);
            parameters.Add("major_contract_email", this.MajorContractEmail);
            parameters.Add("major_contract_mobile", this.MajorContractMobile);
            parameters.Add("major_contract_name", this.MajorContractName);
            parameters.Add("merchant_type", this.MerchantType);
            parameters.Add("objection_contract_email", this.ObjectionContractEmail);
            parameters.Add("objection_contract_mobile", this.ObjectionContractMobile);
            parameters.Add("objection_contract_name", this.ObjectionContractName);
            parameters.Add("one_level_mcc", this.OneLevelMcc);
            parameters.Add("organization_image_url", this.OrganizationImageUrl);
            parameters.Add("organization_no", this.OrganizationNo);
            parameters.Add("out_order_no", this.OutOrderNo);
            parameters.Add("proxy_cert_no", this.ProxyCertNo);
            parameters.Add("proxy_cert_no_back_image_url", this.ProxyCertNoBackImageUrl);
            parameters.Add("proxy_cert_no_front_image_url", this.ProxyCertNoFrontImageUrl);
            parameters.Add("proxy_cert_valid_end_date", this.ProxyCertValidEndDate);
            parameters.Add("proxy_cert_valid_start_date", this.ProxyCertValidStartDate);
            parameters.Add("proxy_mandate_url", this.ProxyMandateUrl);
            parameters.Add("proxy_name", this.ProxyName);
            parameters.Add("qualification_image_url", this.QualificationImageUrl);
            parameters.Add("service_contract_email", this.ServiceContractEmail);
            parameters.Add("service_contract_mobile", this.ServiceContractMobile);
            parameters.Add("service_contract_name", this.ServiceContractName);
            parameters.Add("start_business_date", this.StartBusinessDate);
            parameters.Add("two_level_mcc", this.TwoLevelMcc);
            parameters.Add("webchat_amount", this.WebchatAmount);
            parameters.Add("websit_url", this.WebsitUrl);
            return parameters;
        }

        #endregion
    }
}
