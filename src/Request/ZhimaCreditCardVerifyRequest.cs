using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.card.verify
    /// </summary>
    public class ZhimaCreditCardVerifyRequest : IZmopRequest<ZhimaCreditCardVerifyResponse>
    {
        /// <summary>
        /// 用户地址. 1. 如传入，则进行有效性校验，输出地址有效性等级； 2. 如不传，则不进行地址有效性校验，输出地址有效性等级为未知；
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        public string InstId { get; set; }

        /// <summary>
        /// 芝麻用户的身份标志，openid
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 云产品ID
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户传入的业务流水号。此字段由商户生成，需确保唯一性，用于定位每一次请求，后续按此流水进行对帐。生成规则: 固定30位数字串，前17位为精确到毫秒的时间yyyyMMddhhmmssSSS，后13位为自增数字。
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
            return "zhima.credit.card.verify";
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
            parameters.Add("address", this.Address);
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
