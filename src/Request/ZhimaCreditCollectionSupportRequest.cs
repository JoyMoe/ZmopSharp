using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.collection.support
    /// </summary>
    public class ZhimaCreditCollectionSupportRequest : IZmopRequest<ZhimaCreditCollectionSupportResponse>
    {
        /// <summary>
        /// 证件号码。当前仅支持身份证。请输入身份证号码
        /// </summary>
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型。当前只支持身份证：IDENTITY_CARD
        /// </summary>
        public string CertType { get; set; }

        /// <summary>
        /// 要查询的用户姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 使用过的无效联系号码及状态列表。每一项格式为：${号码}|${状态};${号码}|${状态}。例如：18604020393|A;18604020394|B
        /// </summary>
        public string NumberStatus { get; set; }

        /// <summary>
        /// 云产品id
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
            return "zhima.credit.collection.support";
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
            parameters.Add("number_status", this.NumberStatus);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("transaction_id", this.TransactionId);
            return parameters;
        }

        #endregion
    }
}
