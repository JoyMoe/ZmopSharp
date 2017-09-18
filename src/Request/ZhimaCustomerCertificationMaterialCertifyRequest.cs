using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.customer.certification.material.certify
    /// </summary>
    public class ZhimaCustomerCertificationMaterialCertifyRequest : IZmopRequest<ZhimaCustomerCertificationMaterialCertifyResponse>
    {
        /// <summary>
        /// 认证场景码，支持的场景码有：  FACE_API：通过接口进行人脸识别 签约的协议决定了可以使用的场景
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 扩展业务参数，暂时没有用到，接口预留
        /// </summary>
        public string ExtBizParam { get; set; }

        /// <summary>
        /// 值为一个json串，必须指定身份类型identity_type，不同的身份类型对应的身份信息不同 当前支持： 身份信息为证件信息，identity_type值为CERT_INFO: 证件类型为身份证cert_type值为IDENTITY_CARD,必要信息cert_type，cert_name和cert_no； 身份信息为个人正面照片，identity_type值为FACIAL_PICTURE_FRONT: 必要信息cert_type，cert_name和cert_no和FACIAL_PICTURE_FRONT 示例：{"identity_type": "FACIAL_PICTURE_FRONT", "cert_type": "IDENTITY_CARD", "cert_name": "收委", "cert_no": "260104197909275964", "FACIAL_PICTURE_FRONT": "/9j/4AAQSkZJR"}
        /// </summary>
        public string IdentityParam { get; set; }

        /// <summary>
        /// 认证过程中需要的认证材料，不同认证场景需要的材料不同 biz_code值为FACE_API时需要材料FACIAL_PICTURE_FRONT
        /// </summary>
        public string Materials { get; set; }

        /// <summary>
        /// 认证商户自定义配置，支持一些商户可选的功能
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
            return "zhima.customer.certification.material.certify";
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
            parameters.Add("materials", this.Materials);
            parameters.Add("merchant_config", this.MerchantConfig);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("transaction_id", this.TransactionId);
            return parameters;
        }

        #endregion
    }
}
