using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.customer.ep.certification.initialize
    /// </summary>
    public class ZhimaCustomerEpCertificationInitializeRequest : IZmopRequest<ZhimaCustomerEpCertificationInitializeResponse>
    {
        /// <summary>
        /// 认证场景码，支持的场景码有： EP_ALIPAY_ACCOUNT,  签约的协议决定了可以使用的场景
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 扩展业务参数，暂时没有用到，接口预留
        /// </summary>
        public string ExtBizParam { get; set; }

        /// <summary>
        /// 值为一个json串，无入参时值为"{}"，有入参时必须指定身份类型identity_type，不同的身份类型对应的身份信息不同  当前支持的身份信息为证件信息，identity_type=EP_CERT_INFO   需要输入法人证件三要素，企业证件三要素，如 {"identity_type": "EP_CERT_INFO", "cert_type": "IDENTITY_CARD", "cert_name": "收委", "cert_no":"260104197909275964", "ep_cert_type": "NATIONAL_LEGAL_MERGE", "ep_cert_name": "xxx有限公司", "ep_cert_no":"260104199909275964"}；  特别备注：  上述json串中的 ep_cert_type 属性仅支持2种类型： NATIONAL_LEGAL：工商注册号类型 NATIONAL_LEGAL_MERGE ： 社会统一信用代码类型
        /// </summary>
        public string IdentityParam { get; set; }

        /// <summary>
        /// 认证商户自定义配置，支持一些商户可选的功能,目前为预留的属性值
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
            return "zhima.customer.ep.certification.initialize";
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
