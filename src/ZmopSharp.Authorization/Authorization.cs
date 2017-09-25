using System;
using ZmopSharp.Core;
using AuthorizationConstants = ZmopSharp.Constants.Authorization;

namespace ZmopSharp
{
    public class Authorization
    {
        private const string AuthorizationMethod = "zhima.auth.info.authorize";
        private readonly Client _client;

        public Authorization(Client client)
        {
            _client = client;
        }

        public Authorization(string appId,string appKey, string zmopCert)
        {
            _client = new Client(appId, appKey, zmopCert);
        }

        public string GetRedirectUri(int identityType, string channelType, string identityParam, string state = "")
        {
            string authCode;
            switch (channelType)
            {
                case AuthorizationConstants.ChannelType.AppSdk:
                    authCode = AuthorizationConstants.AuthCode.AppSdk;
                    break;
                case AuthorizationConstants.ChannelType.AppPc:
                    authCode = identityType == AuthorizationConstants.IdentityType.PhoneNumber
                        ? AuthorizationConstants.AuthCode.PhoneNumberPc
                        : AuthorizationConstants.AuthCode.IdCardPc;
                    break;
                case AuthorizationConstants.ChannelType.App:
                case AuthorizationConstants.ChannelType.Api:
                case AuthorizationConstants.ChannelType.InAlipay:
                    authCode = AuthorizationConstants.AuthCode.WebView;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(channelType));
            }

            var bizParams = $"{{\"auth_code\":\"{authCode}\", \"channelType\":\"{channelType}\", \"state\":\"{state}\"}}";

            var request = new Request
            {
                Method = AuthorizationMethod,
                Params = new
                {
                    identity_type = identityType,
                    identity_param = identityParam,
                    biz_params = bizParams,
                }
            };

            return _client.GetRedirectUri(request);
        }

        public string GetOpenId(string response, string signature, string state = "")
        {
            var result = _client.ParseResponse(response, signature);

            if (result["state"].ToString() != state)
            {
                throw new Exception("state token mismatch");
            }

            return result["open_id"].ToString();
        }
    }
}