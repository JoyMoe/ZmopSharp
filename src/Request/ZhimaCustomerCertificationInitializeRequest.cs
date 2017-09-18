using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.customer.certification.initialize
    /// </summary>
    public class ZhimaCustomerCertificationInitializeRequest : IZmopRequest<ZhimaCustomerCertificationInitializeResponse>
    {
        /// <summary>
        /// 认证场景码，支持的场景码有： FACE：多因子活体人脸认证， SMART_FACE：多因子快捷活体人脸认证， FACE_SDK：SDK活体人脸认证 签约的协议决定了可以使用的场景
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 扩展业务参数，暂时没有用到，接口预留
        /// </summary>
        public string ExtBizParam { get; set; }

        /// <summary>
        /// 值为一个json串，无入参时值为"{}"，有入参时必须指定身份类型identity_type，不同的身份类型对应的身份信息不同 当前支持： 身份信息为证件信息，identity_type值为CERT_INFO： 证件类型为身份证cert_type值为IDENTITY_CARD，必要信息cert_name和cert_no； 身份信息为短信手机号，适用于短信认证，identity_type值为SMS_MOBILE_NO： 证件类型可以为空，当证件类型为身份证cert_type值为IDENTITY_CARD，必要信息cert_name和cert_no，mobile_no可以为空，以上信息没有传入的时候会上用户录入； 身份信息为支付宝UID，identity_type值为USER_ID: 必要信息user_id 示例：{"identity_type": "USER_ID", "user_id": "2088172637486509"}
        /// </summary>
        public string IdentityParam { get; set; }

        /// <summary>
        /// 认证商户自定义配置，支持一些商户可选的功能 need_user_authorization： 值为true或者false 当值为true时，在认证用户引导页会展示用户授权协议，在认证通过后会进行授权，但是授权是否成功不影响认证结果
        /// </summary>
        public string MerchantConfig { get; set; }

        /// <summary>
        /// 芝麻认证产品码,示例值为真实的产品码
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，32位长度的字母数字下划线组合。该标识作为对账的关键信息，商户要保证其唯一性.建议:前面几位字符是商户自定义的简称,中间可以使用一段日期,结尾可以使用一个序列
        /// </summary>
        public string TransactionId { get; set; }

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
            return "zhima.customer.certification.initialize";
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
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("ext_biz_param", this.ExtBizParam);
            parameters.Add("identity_param", this.IdentityParam);
            parameters.Add("merchant_config", this.MerchantConfig);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("transaction_id", this.TransactionId);
            return parameters;
        }

        #endregion
    }
}
