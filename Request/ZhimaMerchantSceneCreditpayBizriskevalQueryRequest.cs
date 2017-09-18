using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.merchant.scene.creditpay.bizriskeval.query
    /// </summary>
    public class ZhimaMerchantSceneCreditpayBizriskevalQueryRequest : IZmopRequest<ZhimaMerchantSceneCreditpayBizriskevalQueryResponse>
    {
        /// <summary>
        /// 二级商户应用id
        /// </summary>
        public string LinkedAppId { get; set; }

        /// <summary>
        /// 二级商户merchantId
        /// </summary>
        public string LinkedMerchantId { get; set; }

        /// <summary>
        /// openId
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        public string RuleId { get; set; }

        /// <summary>
        /// 风险评估场景码
        /// </summary>
        public string ScenceCode { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        public string UserId { get; set; }

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
            return "zhima.merchant.scene.creditpay.bizriskeval.query";
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
            parameters.Add("linked_app_id", this.LinkedAppId);
            parameters.Add("linked_merchant_id", this.LinkedMerchantId);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("rule_id", this.RuleId);
            parameters.Add("scence_code", this.ScenceCode);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
