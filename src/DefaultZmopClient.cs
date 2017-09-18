using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Zmop.Api.Parser;
using Zmop.Api.Request;
using Zmop.Api.Util;

namespace Zmop.Api
{
    /// <summary>
    /// ZMOP客户端。
    /// </summary>
    public class DefaultZmopClient : IZmopClient
    {
        public const string APP_ID = "app_id";
        public const string METHOD = "method";
        public const string VERSION = "version";
        public const string SIGN = "sign";
        public const string CHANNEL = "channel";
        public const string PLATFORM = "platform";
        public const string SCENE = "scene";
        public const string PARAMS = "params";
        public const string EXT_PARAMS="extParams";
        public const string CHARSET = "charset";

        private string version;
        private string serverUrl;
        private string appId;

        //商户私钥
        private string privateKey;

        //芝麻公钥
        private string zhimaPublicKey;

        //默认编码
        private string charset = ZhimaConstants.DEFAULT_CHARSET;

        private WebUtils webUtils;

        public string Version
        {
            get { return version != null ? version : "1.0"; }
            set { version = value; }
        }

        public string AppId
        {
            get { return appId; }
            set { appId = value; }
        }

        #region DefaultZmopClient Constructors

        public DefaultZmopClient(string serverUrl, string appId, string privateKey, string zhimaPublicKey)
        {
            this.serverUrl = serverUrl;
            this.appId = appId;
            this.privateKey = privateKey;
            this.zhimaPublicKey = zhimaPublicKey;
            this.webUtils = new WebUtils();
        }

        public DefaultZmopClient(string serverUrl, string appId, string privateKey, string zhimaPublicKey, string charset)
        {
            this.serverUrl = serverUrl;
            this.appId = appId;
            this.privateKey = privateKey;
            this.zhimaPublicKey = zhimaPublicKey;
            this.charset = charset;
            this.webUtils = new WebUtils();
        }

        public void SetTimeout(int timeout)
        {
            webUtils.Timeout = timeout;
        }

        #endregion

        #region IZmopClient Members



        public T Execute<T>(IZmopRequest<T> request) where T : ZmopResponse
        {
            return Execute<T>(request, null);
        }

        public T Execute<T>(IZmopRequest<T> request, string accessToken) where T : ZmopResponse
        {
            if (string.IsNullOrEmpty(this.charset))
            {
                this.charset = ZhimaConstants.DEFAULT_CHARSET;
            }


            ZmopDictionary sysParams = getSystemParams(request);

            // 是否需要上传文件
            string body;
            if (request is IZmopUploadRequest<T>)
            {
                IZmopUploadRequest<T> uRequest = (IZmopUploadRequest<T>)request;
                IDictionary<string, FileItem> fileParams = ZmopUtils.CleanupDictionary(uRequest.GetFileParameters());
                body = webUtils.DoPost(this.serverUrl, sysParams, fileParams, this.charset);
            }
            else
            {
                body = webUtils.DoPost(this.serverUrl, sysParams, this.charset);
            }

            string bizResponse = RSAUtil.ParseBizResponse(body, privateKey, charset);
            T rsp = null;
            IZmopParser<T> parser = null;

            //如果验签失败则抛出异常
            RSAUtil.VerifySign(body, bizResponse, this.zhimaPublicKey, charset);

            parser = new ZmopJsonParser<T>();
            rsp = parser.ParseBizObj(bizResponse, charset);


            return rsp;
        }

        /// <summary>
        /// 生成签名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public string generateSign<T>(IZmopRequest<T> request) where T : ZmopResponse
        {
            String bizParamStr = getBizParamStr(request);
            return RSAUtil.Sign(bizParamStr, privateKey, charset);
        }

        /// <summary>
        /// 生成签名并进行urlencode
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public string generateSignWithUrlEncode<T>(IZmopRequest<T> request) where T : ZmopResponse
        {
            String sign = generateSign(request);
            return WebUtility.UrlEncode(sign);
        }


        /// <summary>
        /// 生成加密后的参数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public string generateEncryptedParam<T>(IZmopRequest<T> request) where T : ZmopResponse
        {
            String bizParamStr = getBizParamStr(request);
            string encryptedAppParam = RSAUtil.Encrypt(bizParamStr, zhimaPublicKey, charset);
            return encryptedAppParam;
        }

        /// <summary>
        /// 生成加密后的参数并进行UrlEncode
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public string generateEncryptedParamWithUrlEncode<T>(IZmopRequest<T> request) where T : ZmopResponse
        {
            String encryptedParam = generateEncryptedParam(request);
            return WebUtility.UrlEncode(encryptedParam);
        }

        private string getBizParamStr<T>(IZmopRequest<T> request) where T : ZmopResponse
        {
            return WebUtils.BuildQuery(request.GetParameters(), charset);
        }

        /// <summary>
        /// 1. 先解密，再验签
        /// 2. 如果验签成功，然后返回解密后的值
        /// 3. 如果验签失败，抛出异常
        /// </summary>
        /// <param name="encryptedResponse"></param>
        /// <param name="sign"></param>
        /// <returns></returns>
        public string decryptAndVerifySign(string encryptedResponse, string sign) 
        {
            string decryptedResponse = RSAUtil.Decrypt(encryptedResponse, privateKey, charset);
            bool success = RSAUtil.Verify(decryptedResponse, sign, zhimaPublicKey, charset);

            if (success == false)
            {
                throw new ZmopException("check sign failed: " + decryptedResponse);
            }
            return decryptedResponse;
        }


        /// <summary>
        /// 对于page_redirect类型的接口调用,生成用来调用这种类型接口的url,便于在浏览器中使用
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">接口请求</param>
        /// <returns>用于在浏览器中访问的url</returns>
        public string generatePageRedirectInvokeUrl<T>(IZmopRequest<T> request) where T : ZmopResponse
        {
            ZmopDictionary sysParams = getSystemParams(request);
            string systemQueryParams = WebUtils.BuildQuery(sysParams, charset);
            string url = this.serverUrl + "?" + systemQueryParams;
            return url;
        }

        private ZmopDictionary getSystemParams<T>(IZmopRequest<T> request) where T : ZmopResponse
        {
            string apiVersion = null;
            if (!string.IsNullOrEmpty(request.GetApiVersion()))
            {
                apiVersion = request.GetApiVersion();
            }
            else
            {
                apiVersion = Version;
            }

            String appParamsQuery = WebUtils.BuildQuery(request.GetParameters(), charset);
            string encryptedAppParam = RSAUtil.Encrypt(appParamsQuery, zhimaPublicKey, charset);
            ZmopDictionary sysParams = new ZmopDictionary();
            sysParams.Add(METHOD, request.GetApiName());
            sysParams.Add(VERSION, apiVersion);
            sysParams.Add(APP_ID, appId);
            sysParams.Add(CHANNEL, request.GetChannel());
            sysParams.Add(PLATFORM, request.GetPlatform());
            sysParams.Add(SCENE, request.GetScene());
            sysParams.Add(EXT_PARAMS, request.GetExtParams());
            sysParams.Add(CHARSET, charset);
            sysParams.Add(PARAMS, encryptedAppParam);

            // 添加签名参数
            sysParams.Add(SIGN, RSAUtil.Sign(appParamsQuery, privateKey, charset));

            return sysParams;
        }

        #endregion
    }


}
