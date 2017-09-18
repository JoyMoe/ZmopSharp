using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.merchant.creditlife.preauth.cancel
    /// </summary>
    public class ZhimaMerchantCreditlifePreauthCancelRequest : IZmopRequest<ZhimaMerchantCreditlifePreauthCancelResponse>
    {
        /// <summary>
        /// 待解冻预授权冻结资金订单号，或解冻请求流水号
        /// </summary>
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 预授权号
        /// </summary>
        public string PreAuthNo { get; set; }

        /// <summary>
        /// 取消预授权冻结资金原因
        /// </summary>
        public string Remark { get; set; }

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
            return "zhima.merchant.creditlife.preauth.cancel";
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
            parameters.Add("out_order_no", this.OutOrderNo);
            parameters.Add("pre_auth_no", this.PreAuthNo);
            parameters.Add("remark", this.Remark);
            return parameters;
        }

        #endregion
    }
}
