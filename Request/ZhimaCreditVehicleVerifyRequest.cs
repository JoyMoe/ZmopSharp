using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.vehicle.verify
    /// </summary>
    public class ZhimaCreditVehicleVerifyRequest : IZmopRequest<ZhimaCreditVehicleVerifyResponse>
    {
        /// <summary>
        /// 发动机号码。vin与engine_no至少包含一项
        /// </summary>
        public string EngineNo { get; set; }

        /// <summary>
        /// 所有人，支持个人和机构
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public string PlateNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 注册日期，格式yyyyMMdd
        /// </summary>
        public string RegisterDate { get; set; }

        /// <summary>
        /// 商户传入的业务流水号。此字段由商户生成，需确保唯一性，用于定位每一次请求，后续按此流水进行对帐。生成规则: 固定30位数字串，前17位为精确到毫秒的时间yyyyMMddHHmmssSSS，后13位为自增数字。
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 车辆品牌（行驶证中中文部分）
        /// </summary>
        public string VehicleBrand { get; set; }

        /// <summary>
        /// 车辆型号（行驶证中英文部分）
        /// </summary>
        public string VehicleSeries { get; set; }

        /// <summary>
        /// 车辆识别代号。vin与engine_no至少包含一项
        /// </summary>
        public string Vin { get; set; }

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
            return "zhima.credit.vehicle.verify";
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
            parameters.Add("engine_no", this.EngineNo);
            parameters.Add("owner", this.Owner);
            parameters.Add("plate_no", this.PlateNo);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("register_date", this.RegisterDate);
            parameters.Add("transaction_id", this.TransactionId);
            parameters.Add("vehicle_brand", this.VehicleBrand);
            parameters.Add("vehicle_series", this.VehicleSeries);
            parameters.Add("vin", this.Vin);
            return parameters;
        }

        #endregion
    }
}
