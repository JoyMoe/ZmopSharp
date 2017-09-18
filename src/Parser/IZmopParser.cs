using System;
using Zmop.Api.Request;

namespace Zmop.Api.Parser
{
    /// <summary>
    /// ZMOP API响应解释器接口。响应格式可以是XML, JSON等等。
    /// </summary>
    /// <typeparam name="T">领域对象</typeparam>
    public interface IZmopParser<T> where T : ZmopResponse
    {        
        /// <summary>
        /// 把响应字符串解释成相应的领域对象。
        /// </summary>
        /// <param name="body">响应字符串</param>
        /// <returns>领域对象</returns>
        T Parse(string body,string charset);

        T ParseBizObj(string bizResponse, string charset);

        SignItem GetSignItem(IZmopRequest<T> request, T response);
    }
}
