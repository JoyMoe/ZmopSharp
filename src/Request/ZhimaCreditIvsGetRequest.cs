using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.ivs.get
    /// </summary>
    public class ZhimaCreditIvsGetRequest : IZmopRequest<ZhimaCreditIvsGetResponse>
    {
        /// <summary>
        /// 用户地址，最多输入三个，多个地址之间用|分隔，如 杭州市西湖区天目山路266号|杭州市西湖区万塘路999号。  备注：证件号、姓名、手机号、地址、银行卡、电子邮箱至少传其中两项
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 银行卡号，最多输入两个，多个银行卡号之间用|分隔，如602436748024138|622536748024139。  备注：证件号、姓名、手机号、地址、银行卡、电子邮箱至少传其中两项
        /// </summary>
        public string BankCard { get; set; }

        /// <summary>
        /// 证件号。 备注：证件号、姓名、手机号、地址、银行卡、电子邮箱至少传其中两项
        /// </summary>
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型。 备注：证件号、姓名、手机号、地址、银行卡、电子邮箱至少传其中两项
        /// </summary>
        public string CertType { get; set; }

        /// <summary>
        /// 电子邮箱，最多传入两个，多个邮箱之间用|分隔，如jnlxhy@alitest.com|john.sss@alitest.com。  备注：证件号、姓名、手机号、地址、银行卡、电子邮箱至少传其中两项
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 国际移动设备标志
        /// </summary>
        public string Imei { get; set; }

        /// <summary>
        /// 国际移动用户识别码
        /// </summary>
        public string Imsi { get; set; }

        /// <summary>
        /// ip地址
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 物理地址
        /// </summary>
        public string Mac { get; set; }

        /// <summary>
        /// 手机号，最多传入三个，多个手机号之间用|分隔，如15256797367|18669152789。  备注：证件号、姓名、手机号、地址、银行卡、电子邮箱至少传其中两项
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名。 备注：证件号、姓名、手机号、地址、银行卡、电子邮箱至少传其中两项
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户传入的业务流水号。此字段由商户生成，需确保唯一性，用于定位每一次请求，后续按此流水进行对帐。参考生成规则: 固定30位数字串，前17位为精确到毫秒的时间yyyyMMddHHmmssSSS，后13位为自增数字。
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// wifi的物理地址
        /// </summary>
        public string Wifimac { get; set; }

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
            return "zhima.credit.ivs.get";
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
            parameters.Add("bank_card", this.BankCard);
            parameters.Add("cert_no", this.CertNo);
            parameters.Add("cert_type", this.CertType);
            parameters.Add("email", this.Email);
            parameters.Add("imei", this.Imei);
            parameters.Add("imsi", this.Imsi);
            parameters.Add("ip", this.Ip);
            parameters.Add("mac", this.Mac);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("name", this.Name);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("transaction_id", this.TransactionId);
            parameters.Add("wifimac", this.Wifimac);
            return parameters;
        }

        #endregion
    }
}
