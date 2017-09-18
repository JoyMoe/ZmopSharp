using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.card.limit.get
    /// </summary>
    public class ZhimaCreditCardLimitGetRequest : IZmopRequest<ZhimaCreditCardLimitGetResponse>
    {
        /// <summary>
        /// 机构ID
        /// </summary>
        public string InstId { get; set; }

        /// <summary>
        /// 芝麻开放平台OPENID
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 云产品id
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// test
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 支付宝用户ID
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
            return "zhima.credit.card.limit.get";
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
            parameters.Add("inst_id", this.InstId);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("transaction_id", this.TransactionId);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
