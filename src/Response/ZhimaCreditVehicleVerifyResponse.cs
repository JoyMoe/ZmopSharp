using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditVehicleVerifyResponse.
    /// </summary>
    public class ZhimaCreditVehicleVerifyResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 是否完成查询
        /// </summary>
        [XmlElement("complete")]
        public bool Complete { get; set; }

        /// <summary>
        /// 发动机号码校验结果[1：匹配；0：不匹配；-1：未输入]
        /// </summary>
        [XmlElement("engine_no_verify_code")]
        public long EngineNoVerifyCode { get; set; }

        /// <summary>
        /// 行驶证是否存在。当车牌号与车辆识别代号或发动机号码任一匹配上，即判定为存在，否则不存在
        /// </summary>
        [XmlElement("exist")]
        public bool Exist { get; set; }

        /// <summary>
        /// 所有人校验结果[1：匹配；0：不匹配；-1：未输入]
        /// </summary>
        [XmlElement("owner_verify_code")]
        public long OwnerVerifyCode { get; set; }

        /// <summary>
        /// 注册日期校验结果[1：匹配；0：不匹配；-1：未输入]
        /// </summary>
        [XmlElement("register_date_verify_code")]
        public long RegisterDateVerifyCode { get; set; }

        /// <summary>
        /// 行驶证状态。具体枚举值见产品文档
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 车辆品牌校验结果[1：匹配；0：不匹配；-1：未输入]
        /// </summary>
        [XmlElement("vehicle_brand_verify_code")]
        public long VehicleBrandVerifyCode { get; set; }

        /// <summary>
        /// 车辆型号校验结果[1：匹配；0：不匹配；-1：未输入]
        /// </summary>
        [XmlElement("vehicle_series_verify_code")]
        public long VehicleSeriesVerifyCode { get; set; }

        /// <summary>
        /// 车辆识别代码校验结果[1：匹配；0：不匹配；-1：未输入]
        /// </summary>
        [XmlElement("vin_verify_code")]
        public long VinVerifyCode { get; set; }
    }
}
