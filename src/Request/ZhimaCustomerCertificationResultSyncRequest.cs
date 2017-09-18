using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.customer.certification.result.sync
    /// </summary>
    public class ZhimaCustomerCertificationResultSyncRequest : IZmopRequest<ZhimaCustomerCertificationResultSyncResponse>
    {
        /// <summary>
        /// 一次认证的唯一标识,在商户调用认证初始化接口的时候获取
        /// </summary>
        public string BizNo { get; set; }

        /// <summary>
        /// 各渠道认证状态,失败原因,材料等信息
        /// </summary>
        public string ChannelStatuses { get; set; }

        /// <summary>
        /// 认证失败的错误码
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// 认证失败的错误信息
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 扩展业务参数
        /// </summary>
        public string ExtBizParam { get; set; }

        /// <summary>
        /// 识别后的主体信息,入参有传就和入参的certify_identity一致
        /// </summary>
        public string IdentifiedPrincipal { get; set; }

        /// <summary>
        /// 商户id,商户在芝麻的唯一标识
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 认证是否通过
        /// </summary>
        public string Passed { get; set; }

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
            return "zhima.customer.certification.result.sync";
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
            parameters.Add("biz_no", this.BizNo);
            parameters.Add("channel_statuses", this.ChannelStatuses);
            parameters.Add("error_code", this.ErrorCode);
            parameters.Add("error_message", this.ErrorMessage);
            parameters.Add("ext_biz_param", this.ExtBizParam);
            parameters.Add("identified_principal", this.IdentifiedPrincipal);
            parameters.Add("merchant_id", this.MerchantId);
            parameters.Add("passed", this.Passed);
            return parameters;
        }

        #endregion
    }
}
