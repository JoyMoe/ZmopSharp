using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.merchant.creditlife.preauth.unfreeze
    /// </summary>
    public class ZhimaMerchantCreditlifePreauthUnfreezeRequest : IZmopRequest<ZhimaMerchantCreditlifePreauthUnfreezeResponse>
    {
        /// <summary>
        /// 待解冻资金(元)
        /// </summary>
        public string PayAmount { get; set; }

        /// <summary>
        /// 预授权后产生的预授权号
        /// </summary>
        public string PreAuthNo { get; set; }

        /// <summary>
        /// 发起资金解冻原因
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 交易流水号
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
            return "zhima.merchant.creditlife.preauth.unfreeze";
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
            parameters.Add("pay_amount", this.PayAmount);
            parameters.Add("pre_auth_no", this.PreAuthNo);
            parameters.Add("remark", this.Remark);
            parameters.Add("transaction_id", this.TransactionId);
            return parameters;
        }

        #endregion
    }
}
