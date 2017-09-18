using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.auth.zhima.cust.certify.initial
    /// </summary>
    public class ZhimaAuthZhimaCustCertifyInitialRequest : IZmopRequest<ZhimaAuthZhimaCustCertifyInitialResponse>
    {
        /// <summary>
        /// 业务扩展属性： 来源类型source_type必传，比如： 1.web场景中，传入{“source_type”:"pc"} 2.移动端场景中，传入{“source_type”:"h5"}
        /// </summary>
        public string BizParams { get; set; }

        /// <summary>
        /// 与芝麻信用签订的合约外标，即使合约改签或续签该值不会发生变化
        /// </summary>
        public string ContractFlag { get; set; }

        /// <summary>
        /// 不同身份类型的参数列表，json字符串的key-value格式： 如： identity_type= "CERT_AND_MOBILE"; identity_param={"certNo":"xxx", "name":"张三", "certType":"IDENTITY_CARD"};
        /// </summary>
        public string IdentityParam { get; set; }

        /// <summary>
        /// 身份标识类型（后续可以扩展）： BY_CERTNO_AND_NAME:按照身份证+姓名（+手机号）进行授权
        /// </summary>
        public string IdentityType { get; set; }

        /// <summary>
        /// 当前使用的产品码
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 芝麻认证过程中的冗余字段，在认证申请时传入，在结果页面回调中原样透传给商户端。 【建议使用方式】用于商户端唯一标记发起认证的用户信息，在接收到芝麻信用认证结果回调后确定用户
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 商户传入的业务流水号。此字段由商户生成，需确保唯一性，用于定位每一次请求，后续按此流水进行对帐。生成规则: 固定30位数字串，前17位为精确到毫秒的时间
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
            return "zhima.auth.zhima.cust.certify.initial";
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
            parameters.Add("biz_params", this.BizParams);
            parameters.Add("contract_flag", this.ContractFlag);
            parameters.Add("identity_param", this.IdentityParam);
            parameters.Add("identity_type", this.IdentityType);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("state", this.State);
            parameters.Add("transaction_id", this.TransactionId);
            return parameters;
        }

        #endregion
    }
}
