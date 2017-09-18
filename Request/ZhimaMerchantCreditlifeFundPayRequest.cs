using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.merchant.creditlife.fund.pay
    /// </summary>
    public class ZhimaMerchantCreditlifeFundPayRequest : IZmopRequest<ZhimaMerchantCreditlifeFundPayResponse>
    {
        /// <summary>
        /// 代扣协议号(代扣扣款时必须提供)
        /// </summary>
        public string AgreementNo { get; set; }

        /// <summary>
        /// 扣款类型(withholding_pay:代扣扣款,preauth_pay:预授权转支付)
        /// </summary>
        public string FundPayType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string GoodsTitle { get; set; }

        /// <summary>
        /// 商品类型(0:虚拟物品,1:实物)
        /// </summary>
        public string GoodsType { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        public string PayAmount { get; set; }

        /// <summary>
        /// 预授权号(付款方式为预授权转支付时必须提供)
        /// </summary>
        public string PreAuthNo { get; set; }

        /// <summary>
        /// 芝麻用户id
        /// </summary>
        public string RoleId { get; set; }

        /// <summary>
        /// 收款方支付宝id
        /// </summary>
        public string SellerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 支付宝用户id（付款方id）
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
            return "zhima.merchant.creditlife.fund.pay";
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
            parameters.Add("agreement_no", this.AgreementNo);
            parameters.Add("fund_pay_type", this.FundPayType);
            parameters.Add("goods_title", this.GoodsTitle);
            parameters.Add("goods_type", this.GoodsType);
            parameters.Add("out_order_no", this.OutOrderNo);
            parameters.Add("pay_amount", this.PayAmount);
            parameters.Add("pre_auth_no", this.PreAuthNo);
            parameters.Add("role_id", this.RoleId);
            parameters.Add("seller_id", this.SellerId);
            parameters.Add("transaction_id", this.TransactionId);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
