using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeLawsuitDetailGetResponse.
    /// </summary>
    public class ZhimaCreditPeLawsuitDetailGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 个人涉诉信息元素（本字段废弃，详情数据获取通过body获取）：   Map<String, Object> data = JSON.parseObject(response.getBody());         if (data != null && data.get("lawsuit_detail") != null) {             @SuppressWarnings("unchecked")             Map<String, Object> dataList = (Map<String, Object>) data.get("lawsuit_detail");             @SuppressWarnings("unchecked")             JSONArray epElementArray = (JSONArray) dataList.get("ep_element_list");              List<EpElement> epElement = JSONArray.parseArray(epElementArray.toJSONString(),                 EpElement.class);         }
        /// </summary>
        [XmlArray("lawsuit_detail")]
        [XmlArrayItem("ep_element")]
        public List<EpElement> LawsuitDetail { get; set; }
    }
}
