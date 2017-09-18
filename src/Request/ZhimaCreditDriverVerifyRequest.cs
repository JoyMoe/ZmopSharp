using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.driver.verify
    /// </summary>
    public class ZhimaCreditDriverVerifyRequest : IZmopRequest<ZhimaCreditDriverVerifyResponse>
    {
        /// <summary>
        /// 驾驶证档案编号
        /// </summary>
        public string ArchiveNo { get; set; }

        /// <summary>
        /// 初次领证日期，格式为yyyyMMdd
        /// </summary>
        public string IssueDate { get; set; }

        /// <summary>
        /// 驾驶证号码
        /// </summary>
        public string LicenseNo { get; set; }

        /// <summary>
        /// 驾驶证上的姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 芝麻业务凭证，详见https://b.zmxy.com.cn/technology/openDoc.htm?id=334
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 准驾车型，多个车型之间以 || 隔开，如C1 || C2 || B2
        /// </summary>
        public string VehicleClass { get; set; }

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
            return "zhima.credit.driver.verify";
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
            parameters.Add("archive_no", this.ArchiveNo);
            parameters.Add("issue_date", this.IssueDate);
            parameters.Add("license_no", this.LicenseNo);
            parameters.Add("name", this.Name);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("transaction_id", this.TransactionId);
            parameters.Add("vehicle_class", this.VehicleClass);
            return parameters;
        }

        #endregion
    }
}
