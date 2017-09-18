using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.merchant.image.upload
    /// </summary>
    public class ZhimaMerchantImageUploadRequest : IZmopRequest<ZhimaMerchantImageUploadResponse>
    {
        /// <summary>
        /// 图片的二进制内容,最大支持2M，需要对图片的二进制流做Base64处理转化成字符串
        /// </summary>
        public string ImageContent { get; set; }

        /// <summary>
        /// 芝麻二级商户图标后缀：bmp, jpg, jpeg, png, gif
        /// </summary>
        public string ImageType { get; set; }

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
            return "zhima.merchant.image.upload";
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
            parameters.Add("image_content", this.ImageContent);
            parameters.Add("image_type", this.ImageType);
            return parameters;
        }

        #endregion
    }
}
