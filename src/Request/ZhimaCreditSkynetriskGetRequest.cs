using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.skynetrisk.get
    /// </summary>
    public class ZhimaCreditSkynetriskGetRequest : IZmopRequest<ZhimaCreditSkynetriskGetResponse>
    {
        /// <summary>
        /// 支付宝登陆号
        /// </summary>
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string CertNo { get; set; }

        /// <summary>
        /// 合约外标，服务标识。签约过后将会收到含有该服务标识的邮件，或者向协同您签约的芝麻合作人员索取。
        /// </summary>
        public string ContractFlag { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 主体类型和对应参数 使用身份证信息查询填cert，对应cert_no和name参数必填； 使用支付宝登陆账号查询填alipayLogonId，对应alipay_logon_id参数必填； 使用支付宝用户ID查询填userId，对应user_id参数必填； 使用手机号查询填mobile，对应mobile参数必填
        /// </summary>
        public string PrincipalType { get; set; }

        /// <summary>
        /// 产品码，固定为w1010100000000001000
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// transaction_id是代表一笔请求的唯一标志，该标识作为对账的关键信息，对于用户使用相同transaction_id的查询，芝麻在一天（86400秒）内返回首次查询数据，超过有效期的查询即为无效并返回异常（错误码xxxx），有效期内的重复查询不重新计费。 transaction_id 推荐生成方式是：30位，（其中17位时间值（精确到毫秒）：yyyyMMddHHmmssSSS）加上（13位自增数字：1234567890123）
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 支付宝账号ID
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
            return "zhima.credit.skynetrisk.get";
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
            parameters.Add("alipay_logon_id", this.AlipayLogonId);
            parameters.Add("cert_no", this.CertNo);
            parameters.Add("contract_flag", this.ContractFlag);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("name", this.Name);
            parameters.Add("principal_type", this.PrincipalType);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("transaction_id", this.TransactionId);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
