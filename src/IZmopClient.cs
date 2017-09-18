using Zmop.Api.Request;

namespace Zmop.Api
{
    /// <summary>
    /// ZMOP客户端。
    /// </summary>
    public interface IZmopClient
    {
        /// <summary>
        /// 执行ZMOP公开API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的ZMOP API请求</param>
        /// <returns>领域对象</returns>
        T Execute<T>(IZmopRequest<T> request) where T : ZmopResponse;

        /// <summary>
        /// 执行ZMOP隐私API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的ZMOP API请求</param>
        /// <param name="session">用户会话码</param>
        /// <returns>领域对象</returns>
        T Execute<T>(IZmopRequest<T> request, string session) where T : ZmopResponse;
    }
}
