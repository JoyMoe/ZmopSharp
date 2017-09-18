using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.risk.evaluate.query
    /// </summary>
    public class ZhimaCreditRiskEvaluateQueryRequest : IZmopRequest<ZhimaCreditRiskEvaluateQueryResponse>
    {
        /// <summary>
        /// 证件号， 与cert_type值相对应
        /// </summary>
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型 目前支持两种IDENTITY_CARD(身份证),ALIPAY_USER_ID(支付宝uid)
        /// </summary>
        public string CertType { get; set; }

        /// <summary>
        /// 拓展参数，供提供更多信息给规则引擎做风险判断。以json字符串形式配置
        /// </summary>
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 姓名，当传入cert_type类型为IDENTITY_CARD时该值为必传项
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 签约产品标示，唯一对应一个产品
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// ISV商户传入二级商户APPID 普通商户传入自身APPID
        /// </summary>
        public string RuleId { get; set; }

        /// <summary>
        /// 标识对接业务场景，业务场景下商户可做自定义策略配置
        /// </summary>
        public string SceneCode { get; set; }

        /// <summary>
        /// 唯一标示商户每一笔请求
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
            return "zhima.credit.risk.evaluate.query";
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
            parameters.Add("cert_no", this.CertNo);
            parameters.Add("cert_type", this.CertType);
            parameters.Add("extend_info", this.ExtendInfo);
            parameters.Add("name", this.Name);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("rule_id", this.RuleId);
            parameters.Add("scene_code", this.SceneCode);
            parameters.Add("transaction_id", this.TransactionId);
            return parameters;
        }

        #endregion
    }
}
