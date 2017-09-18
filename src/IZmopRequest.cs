using System.Collections.Generic;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP请求接口。
    /// </summary>
    public interface IZmopRequest<T> where T : ZmopResponse
    {

        /// <summary>
        /// 获取渠道
        /// </summary>
        /// <returns>渠道</returns>
        string GetChannel();

        /// <summary>
        /// 设置渠道
        /// </summary>
        /// <returns></returns>
        void SetChannel(string channel);

        /// <summary>
        /// 获取ZMOP的API名称。
        /// </summary>
        /// <returns>API名称</returns>
        string GetApiName();

        /// <summary>
        /// 获取平台。
        /// </summary>
        /// <returns>来源平台</returns>
		string GetPlatform();

        /// <summary>
        /// 设置平台。
        /// </summary>
        /// <returns>来源平台</returns>
        void SetPlatform(string terminalType);

        /// <summary>
        /// 获取场景。
        /// </summary>
        /// <returns>场景信息</returns>
		string GetScene();

        /// <summary>
        /// 设置场景。
        /// </summary>
        /// <returns>场景信息</returns>
        void SetScene(string terminalInfo);

        /// <summary>
        /// 获取扩展参数
        /// </summary>
        /// <returns>扩展参数</returns>
        string GetExtParams();

        /// <summary>
        /// 设置扩展参数
        /// </summary>
        /// <returns>扩展参数</returns>
        void SetExtParams(string prodCode);

        /// <summary>
        /// 设置接口版本
        /// </summary>
        void SetApiVersion(string apiVersion);


        /// <summary>
        /// 返回接口版本
        /// </summary>
        /// <returns>接口版本</returns>
        string GetApiVersion();

        /// <summary>
        /// 获取所有的Key-Value形式的文本请求参数字典。其中：
        /// Key: 请求参数名
        /// Value: 请求参数文本值
        /// </summary>
        /// <returns>文本请求参数字典</returns>
        IDictionary<string, string> GetParameters();
    }
}
