using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.customer.borrow.scan
    /// </summary>
    public class ZhimaCustomerBorrowScanRequest : IZmopRequest<ZhimaCustomerBorrowScanResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public string GoodsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ScenceCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ShopCode { get; set; }

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
            return "zhima.customer.borrow.scan";
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
            parameters.Add("goods_id", this.GoodsId);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("scence_code", this.ScenceCode);
            parameters.Add("shop_code", this.ShopCode);
            return parameters;
        }

        #endregion
    }
}
