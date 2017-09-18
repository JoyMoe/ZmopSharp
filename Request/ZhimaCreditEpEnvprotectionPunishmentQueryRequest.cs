using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.ep.envprotection.punishment.query
    /// </summary>
    public class ZhimaCreditEpEnvprotectionPunishmentQueryRequest : IZmopRequest<ZhimaCreditEpEnvprotectionPunishmentQueryResponse>
    {
        /// <summary>
        /// 查询企业，不需要填写证件号。 查询个人，必须填入证件号。
        /// </summary>
        public string CertNo { get; set; }

        /// <summary>
        /// 查询个人的时候必填，填入IDENTITY_CARD。目前支持内地身份证。
        /// </summary>
        public string CertType { get; set; }

        /// <summary>
        /// 枚举值 1:个人 2:企业
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// 企业名称或个人姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// transaction_id是代表一笔请求的唯一标志，该标识作为对账的关键信息，对于用户使用相同transaction_id的查询，芝麻在一天（86400秒）内返回首次查询数据，超过有效期的查询即为无效并返回异常（错误码xxxx），有效期内的重复查询不重新计费。 transaction_id 推荐生成方式是：30位，（其中17位时间值（精确到毫秒）：yyyyMMddHHmmssSSS）加上（13位自增数字：1234567890123）
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
            return "zhima.credit.ep.envprotection.punishment.query";
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
            parameters.Add("data_type", this.DataType);
            parameters.Add("name", this.Name);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("transaction_id", this.TransactionId);
            return parameters;
        }

        #endregion
    }
}
