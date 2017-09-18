using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.risk.evaluate.rule.query
    /// </summary>
    public class ZhimaCreditRiskEvaluateRuleQueryRequest : IZmopRequest<ZhimaCreditRiskEvaluateRuleQueryResponse>
    {
        /// <summary>
        /// 签约产品标示，唯一对应一个产品
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 可选参数，传值则标示只查询对应规则配置值，不传则输出所有规则配置值
        /// </summary>
        public List<string> RuleCode { get; set; }

        /// <summary>
        /// 1000806 【规则标识，使用APPID】 如果是ISV商户： 传入二级商户APPID 如果是普通商户：传入自己调用APPID
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
            return "zhima.credit.risk.evaluate.rule.query";
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
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("rule_code", this.RuleCode);
            parameters.Add("rule_id", this.RuleId);
            parameters.Add("scene_code", this.SceneCode);
            parameters.Add("transaction_id", this.TransactionId);
            return parameters;
        }

        #endregion
    }
}
