using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.merchant.creditlife.fund.refund
    /// </summary>
    public class ZhimaMerchantCreditlifeFundRefundRequest : IZmopRequest<ZhimaMerchantCreditlifeFundRefundResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public string BizProduct { get; set; }

        /// <summary>
        /// 商户发起扣款时的订单号
        /// </summary>
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        public string PayAmount { get; set; }

        /// <summary>
        /// 交易信息说明(退款原因)
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
            return "zhima.merchant.creditlife.fund.refund";
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
            parameters.Add("biz_product", this.BizProduct);
            parameters.Add("out_order_no", this.OutOrderNo);
            parameters.Add("pay_amount", this.PayAmount);
            parameters.Add("remark", this.Remark);
            return parameters;
        }

        #endregion
    }
}
