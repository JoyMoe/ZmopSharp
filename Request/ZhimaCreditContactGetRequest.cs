using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.contact.get
    /// </summary>
    public class ZhimaCreditContactGetRequest : IZmopRequest<ZhimaCreditContactGetResponse>
    {
        /// <summary>
        /// 用户的地址：最多传入三组，用|分隔。地址中不能有如下特殊字符&,^,\
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 是否逾期。T表示逾期，F表示非逾期
        /// </summary>
        public string IsOverdue { get; set; }

        /// <summary>
        /// 用户手机号，最多传入三个，每个手机号之间以“|"分隔。
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 芝麻会员在商户端的身份标识。
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 逾期天数。请输入数字。
        /// </summary>
        public string OverdueDays { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户传入的业务流水号。此字段由商户生成，需确保唯一性，用于定位每一次请求，后续按此流水进行对帐。生成规则: 固定30位数字串，前17位为精确到毫秒的时间yyyyMMddhhmmssSSS，后13位为自增数字。
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
            return "zhima.credit.contact.get";
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
            parameters.Add("is_overdue", this.IsOverdue);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("overdue_days", this.OverdueDays);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("transaction_id", this.TransactionId);
            return parameters;
        }

        #endregion
    }
}
