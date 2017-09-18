using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Zmop.Api.Request;

namespace Zmop.Api.Parser
{
    /// <summary>
    /// ZMOP XML响应通用解释器。
    /// </summary>
    public class ZmopXmlParser<T> : IZmopParser<T> where T : ZmopResponse
    {
        private static Regex regex = new Regex("<(\\w+?)[ >]", RegexOptions.Compiled);
        private static Dictionary<string, XmlSerializer> parsers = new Dictionary<string, XmlSerializer>();

        #region IZmopParser<T> Members

        public T Parse(string body, string charset)
        {
            XmlSerializer serializer = null;
            string rootTagName = GetRootElement(body);

            bool inc = parsers.TryGetValue(rootTagName, out serializer);
            if (!inc || serializer == null)
            {
                XmlAttributes rootAttrs = new XmlAttributes();
                rootAttrs.XmlRoot = new XmlRootAttribute(rootTagName);

                XmlAttributeOverrides attrOvrs = new XmlAttributeOverrides();
                attrOvrs.Add(typeof(T), rootAttrs);

                serializer = new XmlSerializer(typeof(T), attrOvrs);
                parsers[rootTagName] = serializer;
            }

            object obj = null;
            Encoding encoding = null;
            if (string.IsNullOrEmpty(charset))
            {
                encoding = Encoding.UTF8;
            }
            else
            {
                encoding = Encoding.GetEncoding(charset);
            }
            using (Stream stream = new MemoryStream(encoding.GetBytes(body)))
            {
                obj = serializer.Deserialize(stream);
            }

            T rsp = (T)obj;
            if (rsp != null)
            {
                rsp.Body = body;
            }
            return rsp;
        }

        public T ParseBizObj(string bizResponse, string charset) 
        {
            return null;
        }

        public SignItem GetSignItem(IZmopRequest<T> request, T response)
        {
            string body = response.Body;
            if (string.IsNullOrEmpty(body))
            {
                return null;
            }

            SignItem signItem = new SignItem();
            string sign = GetSign(body);
            signItem.Sign = sign;

            string signSourceData = GetSignSourceData(request, body);
            signItem.SignSourceDate = signSourceData;

            return signItem;
        }

        #endregion

        /// <summary>
        /// 获取XML响应的根节点名称
        /// </summary>
        private string GetRootElement(string body)
        {
            Match match = regex.Match(body);
            if (match.Success)
            {
                return match.Groups[1].ToString();
            }
            else
            {
                throw new ZmopException("Invalid XML response format!");
            }
        }

        private static string GetSign(string body)
        {
            string signNodeName = "<" + ZhimaConstants.SIGN + ">";
            string signEndNodeName = "</" + ZhimaConstants.SIGN + ">";

            int indexOfSignNode = body.IndexOf(signNodeName);
            int indexOfSignEndNode = body.IndexOf(signEndNodeName);

            if (indexOfSignNode < 0 || indexOfSignEndNode < 0)
            {
                return null;
            }

            //  签名
            int startPos = indexOfSignNode + signNodeName.Length;
            return body.Substring(startPos, indexOfSignEndNode - startPos);
        }

        private static string GetSignSourceData(IZmopRequest<T> request, string body)
        {
            string rootNode = request.GetApiName().Replace(".", "_") + ZhimaConstants.RESPONSE_SUFFIX;
            string errorRootNode = ZhimaConstants.ERROR_RESPONSE;

            int indexOfRootNode = body.IndexOf(rootNode);
            int indexOfErrorRoot = body.IndexOf(errorRootNode);

            string result = null;
            if (indexOfRootNode > 0)
            {
                result = ParseSignSourceData(body, rootNode, indexOfRootNode);
            }
            else if (indexOfErrorRoot > 0)
            {
                result = ParseSignSourceData(body, errorRootNode, indexOfErrorRoot);
            }

            return result;
        }

        private static string ParseSignSourceData(string body, string rootNode, int indexOfRootNode)
        {

            //  第一个字母+长度+>
            int signDataStartIndex = indexOfRootNode + rootNode.Length + 1;
            int indexOfSign = body.IndexOf("<" + ZhimaConstants.SIGN);
            if (indexOfSign < 0)
            {
                return null;
            }

            // 签名前减去
            int signDataEndIndex = indexOfSign;

            return body.Substring(signDataStartIndex, signDataEndIndex - signDataStartIndex);
        }

    }
}
