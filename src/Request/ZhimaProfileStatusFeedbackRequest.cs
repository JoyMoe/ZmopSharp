using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.profile.status.feedback
    /// </summary>
    public class ZhimaProfileStatusFeedbackRequest : IZmopRequest<ZhimaProfileStatusFeedbackResponse>
    {
        /// <summary>
        /// 业务号
        /// </summary>
        public string BizNo { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 当前为BANK或者ACCUFUND
        /// </summary>
        public string DataSource { get; set; }

        /// <summary>
        /// 数据抓取code
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// 更新备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 数据采集机构
        /// </summary>
        public string OrgCode { get; set; }

        /// <summary>
        /// 数据状态
        /// </summary>
        public string Status { get; set; }

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
            return "zhima.profile.status.feedback";
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
            parameters.Add("biz_type", this.BizType);
            parameters.Add("data_source", this.DataSource);
            parameters.Add("item_code", this.ItemCode);
            parameters.Add("memo", this.Memo);
            parameters.Add("org_code", this.OrgCode);
            parameters.Add("status", this.Status);
            return parameters;
        }

        #endregion
    }
}
