using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.merchant.expand.apply
    /// </summary>
    public class ZhimaMerchantExpandApplyRequest : IZmopRequest<ZhimaMerchantExpandApplyResponse>
    {
        /// <summary>
        /// 浙江飞猪网络技术有限公司，企业别称请填写【飞猪】
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
        /// 签约芝麻信用产品的用途，最多5个场景，ISV可以自定义
        /// </summary>
        public string BizScene { get; set; }

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
        /// 商户logo的图片内容，把图片的二进制转化成String传递过来 ，最大2M
        /// </summary>
        public string LogoImage { get; set; }

        /// <summary>
        /// 商户图标类型，只支持如下格式：bmp, jpg, jpeg, png, gif
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
        /// 芝麻特定的商户一级行业归属，比如生活行业，金融行业，政府行业
        /// </summary>
        public string OneLevelMcc { get; set; }

        /// <summary>
        /// 商户业务许可证图片内容，把图片的二进制转化成String传递过来 ，最大2M
        /// </summary>
        public string QualificationImage { get; set; }

        /// <summary>
        /// 商户业务许可证图片类型，只支持如下格式：bmp, jpg, jpeg, png, gif
        /// </summary>
        public string QualificationImageType { get; set; }

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
        /// 芝麻特有的商户二级行业归属，比如汽车服务
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
            return "zhima.merchant.expand.apply";
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
            parameters.Add("biz_scene", this.BizScene);
            parameters.Add("data_feedback_contract_email", this.DataFeedbackContractEmail);
            parameters.Add("data_feedback_contract_mobile", this.DataFeedbackContractMobile);
            parameters.Add("data_feedback_contract_name", this.DataFeedbackContractName);
            parameters.Add("logo_image", this.LogoImage);
            parameters.Add("logo_image_type", this.LogoImageType);
            parameters.Add("major_contract_email", this.MajorContractEmail);
            parameters.Add("major_contract_mobile", this.MajorContractMobile);
            parameters.Add("major_contract_name", this.MajorContractName);
            parameters.Add("objection_contract_email", this.ObjectionContractEmail);
            parameters.Add("objection_contract_mobile", this.ObjectionContractMobile);
            parameters.Add("objection_contract_name", this.ObjectionContractName);
            parameters.Add("one_level_mcc", this.OneLevelMcc);
            parameters.Add("qualification_image", this.QualificationImage);
            parameters.Add("qualification_image_type", this.QualificationImageType);
            parameters.Add("service_contract_email", this.ServiceContractEmail);
            parameters.Add("service_contract_mobile", this.ServiceContractMobile);
            parameters.Add("service_contract_name", this.ServiceContractName);
            parameters.Add("two_level_mcc", this.TwoLevelMcc);
            parameters.Add("webchat_amount", this.WebchatAmount);
            parameters.Add("websit_url", this.WebsitUrl);
            return parameters;
        }

        #endregion
    }
}
