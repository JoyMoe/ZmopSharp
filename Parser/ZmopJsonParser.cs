using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Serialization;
using Jayrock.Json.Conversion;
using Zmop.Api.Request;

namespace Zmop.Api.Parser
{
    /// <summary>
    /// ZMOP JSON响应通用解释器。
    /// </summary>
    public class ZmopJsonParser<T> : IZmopParser<T> where T : ZmopResponse
    {
        private static readonly Dictionary<string, Dictionary<string, ZmopAttribute>> attrs = new Dictionary<string, Dictionary<string, ZmopAttribute>>();

        #region IZmopParser<T> Members
        public T Parse(string body,string charset)
        {
            T rsp = null;

            IDictionary json = JsonConvert.Import(body) as IDictionary;
            if (json != null)
            {
                IDictionary data = null;

                // 忽略根节点的名称
                foreach (object key in json.Keys)
                {
                    data = json[key] as IDictionary;
                    if (data != null && data.Count > 0)
                    {
                        break;
                    }
                }

                if (data != null)
                {
                    IZmopReader reader = new ZmopJsonReader(data);
                    rsp = (T)ZmopJsonConvert(reader, typeof(T));
                }
            }

            if (rsp == null)
            {
                rsp = Activator.CreateInstance<T>();
            }

            if (rsp != null)
            {
                rsp.Body = body;
            }

            return rsp;
        }


        public T ParseBizObj(string bizResponse, string charset)
        {
            T rsp = null;
            if(bizResponse != null)
            {
                IDictionary json = JsonConvert.Import(bizResponse) as IDictionary;
                if (json != null)
                {
                    IZmopReader reader = new ZmopJsonReader(json);
                    rsp = (T)ZmopJsonConvert(reader, typeof(T));
                }
            }

            if (rsp == null)
            {
                rsp = Activator.CreateInstance<T>();
            }

            if (rsp != null)
            {
                rsp.Body = bizResponse;
            }

            return rsp;
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

        private static Dictionary<string, ZmopAttribute> GetZmopAttributes(Type type)
        {
            Dictionary<string, ZmopAttribute> tas = null;
            bool inc = attrs.TryGetValue(type.FullName, out tas);

            if (inc && tas != null) // 从缓存中获取类属性元数据
            {
                return tas;
            }
            else // 创建新的类属性元数据缓存
            {
                tas = new Dictionary<string, ZmopAttribute>();
            }

            PropertyInfo[] pis = type.GetProperties();
            foreach (PropertyInfo pi in pis)
            {
                ZmopAttribute ta = new ZmopAttribute();
                ta.Method = pi.GetSetMethod();

                // 获取对象属性名称
                XmlElementAttribute[] xeas = pi.GetCustomAttributes(typeof(XmlElementAttribute), true) as XmlElementAttribute[];
                if (xeas != null && xeas.Length > 0)
                {
                    ta.ItemName = xeas[0].ElementName;
                }

                // 获取列表属性名称
                if (ta.ItemName == null)
                {
                    XmlArrayItemAttribute[] xaias = pi.GetCustomAttributes(typeof(XmlArrayItemAttribute), true) as XmlArrayItemAttribute[];
                    if (xaias != null && xaias.Length > 0)
                    {
                        ta.ItemName = xaias[0].ElementName;
                    }
                    XmlArrayAttribute[] xaas = pi.GetCustomAttributes(typeof(XmlArrayAttribute), true) as XmlArrayAttribute[];
                    if (xaas != null && xaas.Length > 0)
                    {
                        ta.ListName = xaas[0].ElementName;
                    }
                    if (ta.ListName == null)
                    {
                        continue;
                    }
                }

                // 获取属性类型
                if (pi.PropertyType.IsGenericType)
                {
                    Type[] types = pi.PropertyType.GetGenericArguments();
                    ta.ListType = types[0];
                }
                else
                {
                    ta.ItemType = pi.PropertyType;
                }

                tas.Add(pi.Name + ta.ItemType + ta.ListType, ta);
            }

            attrs[type.FullName] = tas;
            return tas;
        }

        protected static readonly DZmopConvert ZmopJsonConvert = delegate(IZmopReader reader, Type type)
        {
            object rsp = null;
            Dictionary<string, ZmopAttribute> pas = GetZmopAttributes(type);

            Dictionary<string, ZmopAttribute>.Enumerator em = pas.GetEnumerator();
            while (em.MoveNext())
            {
                KeyValuePair<string, ZmopAttribute> kvp = em.Current;
                ZmopAttribute ta = kvp.Value;
                string itemName = ta.ItemName;
                string listName = ta.ListName;

                if (!reader.HasReturnField(itemName) && (string.IsNullOrEmpty(listName) || !reader.HasReturnField(listName)))
                {
                    continue;
                }

                object value = null;
                if (ta.ListType != null)
                {
                    value = reader.GetListObjects(listName, itemName, ta.ListType, ZmopJsonConvert);
                }
                else
                {
                    if (typeof(string) == ta.ItemType)
                    {
                        object tmp = reader.GetPrimitiveObject(itemName);
                        if (tmp != null)
                        {
                            value = tmp.ToString();
                        }
                    }
                    else if (typeof(long) == ta.ItemType)
                    {
                        object tmp = reader.GetPrimitiveObject(itemName);
                        if (tmp != null)
                        {
                            value = ((IConvertible)tmp).ToInt64(null);
                        }
                    }
                    else if (typeof(bool) == ta.ItemType)
                    {
                        value = reader.GetPrimitiveObject(itemName);
                    }
                    else
                    {
                        value = reader.GetReferenceObject(itemName, ta.ItemType, ZmopJsonConvert);
                    }
                }

                if (value != null)
                {
                    if (rsp == null)
                    {
                        rsp = Activator.CreateInstance(type);
                    }
                    ta.Method.Invoke(rsp, new object[] { value });
                }
            }

            return rsp;
        };

        private static string GetSign(string body)
        {
            IDictionary json = JsonConvert.Import(body) as IDictionary;
            Console.WriteLine(json);
            return (string)json["sign"];
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
            int signDataStartIndex = indexOfRootNode + rootNode.Length + 2;
            int indexOfSign = body.IndexOf("\"" + ZhimaConstants.SIGN + "\"");
            if (indexOfSign < 0)
            {
                return null;
            }

            int signDataEndIndex = indexOfSign - 1;
            int length = signDataEndIndex - signDataStartIndex;

            return body.Substring(signDataStartIndex, length);
        }
    }
}
