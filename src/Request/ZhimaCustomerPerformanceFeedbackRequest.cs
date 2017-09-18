using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.customer.performance.feedback
    /// </summary>
    public class ZhimaCustomerPerformanceFeedbackRequest : IZmopRequest<ZhimaCustomerPerformanceFeedbackResponse>
    {
        /// <summary>
        /// 用户证件号码
        /// </summary>
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        public string CertType { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 商户反馈的某用户还款计划数据，格式：[{"repayment_id": "1234","repayment_desc": "商品名称","installments": [{"installment_id": "1234","installment_amount": "1000","installment_date": "2016-09-11 12:00:00","installment_desc": "已逾期7天","installment_status": "WAITING_REPAY","currency": "CNY"}]}]
        /// </summary>
        public string Repayments { get; set; }

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
            return "zhima.customer.performance.feedback";
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
            parameters.Add("name", this.Name);
            parameters.Add("repayments", this.Repayments);
            return parameters;
        }

        #endregion
    }
}
