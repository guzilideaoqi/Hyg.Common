/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DataConvert.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:05:02 
备注说明 : 数据转换类

 =====================================End=======================================================*/
using Hyg.Common.WeChatTools.WeChatModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Hyg.Common.OtherTools
{
    /// <summary>
    /// 数据转换工具类
    /// </summary>
    public static partial class DataConvertHelper
    {
        #region 是否为群组
        /// <summary>
        /// 是否为群组
        /// </summary>
        /// <param name="wxid"></param>
        /// <returns></returns>
        public static bool IsQun(this string wxid)
        {
            if (wxid.IsEmpty())
                return false;
            return wxid.Contains("@chatroom");
        }
        #endregion

        #region 是否为公众号
        /// <summary>
        /// 是否为公众号
        /// </summary>
        /// <param name="wxid"></param>
        /// <returns></returns>
        public static bool IsCommonAccount(this string wxid)
        {
            return wxid.StartsWith("gh_");
        }
        #endregion

        public static bool FilterMessage(this string wxid)
        {
            return CommonCacheConfig.filterList.Contains(wxid);
        }

        #region 列表中是否包含数据
        /// <summary>
        /// 列表中是否包含数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool HasData<T>(this List<T> data)
        {
            if (data == null)
                return false;
            else
            {
                return data.Count > 0;
            }
        }
        /// <summary>
        /// 列表中是否包含数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool HasData<T>(this IEnumerable<T> data)
        {
            if (data == null)
                return false;
            else
            {
                return data.Count() > 0;
            }
        }
        #endregion

        #region 字符串是否为空
        /// <summary>
        /// 字符串是否为空
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsEmpty(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
        #endregion

        #region 对象是否为空
        /// <summary>
        /// 对象是否为空
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsEmpty(this object value)
        {
            if (value != null && !string.IsNullOrEmpty(value.ToString()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region 对象转int
        /// <summary>
        /// 对象转int (为空时返回0)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToIntDefault(this object value)
        {
            if (value.IsEmpty())
                return 0;
            else
                return int.Parse(value.ToString());
        }
        #endregion

        #region 时间戳转时间字符串
        public static string GetTimeByTimeStamp(this long timestamp)
        {
            if (timestamp > 0)
            {
                DateTime dateTimeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));

                return dateTimeStart.AddSeconds(timestamp).ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                return "";
            }
        }
        #endregion

        #region 获取群欢迎新人昵称
        /// <summary>
        /// 获取欢迎新人用户昵称
        /// </summary>
        /// <param name="raw_msg"></param>
        /// <returns></returns>
        public static string GetNewPersonNickName(this string raw_msg, ref string newPersonNickName, ref string InviteNickName, ref bool IsSelf)
        {
            try
            {
                Regex re = new Regex("(?<=\").*?(?=\")", RegexOptions.None);
                MatchCollection mc = re.Matches(raw_msg);

                List<string> AllValues = new List<string>();
                for (int i = 0; i < mc.Count; i++)
                {
                    AllValues.Add(mc[i].Value);
                }

                if (mc.Count == 1)
                {
                    newPersonNickName = AllValues[0];
                    IsSelf = true;//自己邀请的
                }
                else if (mc.Count == 2)
                {
                    newPersonNickName = AllValues[0] + "\"" + AllValues[1];
                    IsSelf = true;//自己邀请的
                }
                else if (mc.Count == 3)
                {
                    if (raw_msg.Contains("邀请"))
                    {
                        newPersonNickName = AllValues[2];
                        InviteNickName = AllValues[0];
                    }
                    else
                    {
                        newPersonNickName = AllValues[0];
                        InviteNickName = AllValues[2];
                    }
                }
                else if (mc.Count > 3)
                {
                    if (raw_msg.Contains("邀请"))
                    {
                        var index = AllValues.IndexOf("邀请");//获取邀请的索引
                        for (int i = 0; i < index; i++)
                        {
                            if (InviteNickName != "")
                                InviteNickName += "\"";
                            InviteNickName += AllValues[i];
                        }
                        for (int i = index + 1; i < AllValues.Count; i++)
                        {
                            if (newPersonNickName != "")
                                newPersonNickName += "\"";
                            newPersonNickName += AllValues[i];
                        }
                    }
                    else if (raw_msg.Contains("通过扫描"))
                    {
                        var index = AllValues.IndexOf("通过扫描");//获取通过扫描的索引
                        for (int i = 0; i < index; i++)
                        {
                            if (newPersonNickName != "")
                                newPersonNickName += "\"";
                            newPersonNickName += AllValues[i];
                        }
                        for (int i = index + 1; i < AllValues.Count; i++)
                        {
                            if (InviteNickName != "")
                                InviteNickName += "\"";
                            InviteNickName += AllValues[i];
                        }
                    }
                }
            }
            catch (Exception)
            {
                newPersonNickName = "";
            }

            return newPersonNickName;
        }
        #endregion

        #region 清除特殊字符
        /// <summary>
        /// 清楚特殊字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ClearSpecialCharacter(this string str)
        {
            return str.Replace("\"", "");
        }
        #endregion

        #region Json对象转字符串
        public static string ToJsonStr(this object obj, bool IgnoreNULL = false)
        {
            if (IgnoreNULL)
                return JsonConvert.SerializeObject(obj, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            else
                return JsonConvert.SerializeObject(obj);
        }
        #endregion

        #region Json字符串转对象
        public static T ToJsonObject<T>(this string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
        #endregion

        public static bool IsSelf(this string wxid, uint ClientID)
        {
            return wxid == ClientID.GetWxidByClientID();
        }

        #region 获取微信所属人wxid
        /// <summary>
        /// 获取微信所属人wxid
        /// </summary>
        /// <param name="ClientID"></param>
        /// <returns></returns>
        public static string GetWxidByClientID(this uint ClientID)
        {
            string wxid = "";
            try
            {
                WeChat_UserInfo weChat_UserInfo = CommonCacheConfig.Login_WeChat_UserInfo.Where(t => t.wx_clientid == ClientID).FirstOrDefault();
                if (!weChat_UserInfo.IsEmpty())
                    wxid = weChat_UserInfo.wxid;
            }
            catch (Exception)
            {
            }

            return wxid;
        }
        #endregion

        #region 获取微信所属人clientid
        public static uint GetClientIDByWxid(this string wxid)
        {
            uint dwclient = 0;
            try
            {
                WeChat_UserInfo weChat_UserInfo = CommonCacheConfig.Login_WeChat_UserInfo.Where(t => t.wxid == wxid).FirstOrDefault();
                if (!weChat_UserInfo.IsEmpty())
                    dwclient = weChat_UserInfo.wx_clientid;
            }
            catch (Exception)
            {
            }

            return dwclient;
        }
        #endregion

        #region 字符串格式转换
        public static string FileUrlReplace(this string fileUrl)
        {
            return fileUrl.Replace(@"\", @"\\");
        }
        #endregion

        #region Model转字符串
        public static string ModelToUriParam<T>(this T Model, bool filternull = true)
        {
            PropertyInfo[] propertis = Model.GetType().GetProperties();
            StringBuilder sb = new StringBuilder();
            foreach (var p in propertis)
            {
                var v = p.GetValue(Model, null);
                if (filternull && v.IsEmpty())
                {
                    continue;
                }

                if (p.Name.ToLower() == "isreturncommoninfo")
                    continue;

                sb.Append(p.Name);
                sb.Append("=");
                //sb.Append(HttpUtility.UrlEncode(v.ToString()));
                if (!v.IsEmpty())
                    sb.Append(v.ToString());
                sb.Append("&");
            }

            if (sb.Length > 0)
                sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }

        public static Dictionary<string, string> ModelToUriParamByDic<T>(this T Model)
        {
            PropertyInfo[] propertis = Model.GetType().GetProperties();
            Dictionary<string, string> dic_Param = new Dictionary<string, string>();
            foreach (var p in propertis)
            {
                var v = p.GetValue(Model, null);
                if (v.IsEmpty())
                    continue;

                if (p.Name.ToLower() == "isreturncommoninfo")
                    continue;

                if (p.PropertyType.Name == "String[]")
                {
                    dic_Param.Add(p.Name, v.ToJsonStr());
                }
                else
                {
                    dic_Param.Add(p.Name, v.ToString());
                }
            }

            return dic_Param;
        }
        #endregion

        #region UrlEncode编码
        public static string ToUrlEncode(this string text, bool IsUpper = false)
        {
            if (IsUpper)
            {
                StringBuilder builder = new StringBuilder();
                foreach (char c in text)
                {
                    if (HttpUtility.UrlEncode(c.ToString()).Length > 1)
                    {
                        builder.Append(HttpUtility.UrlEncode(c.ToString()).ToUpper());
                    }
                    else
                    {
                        builder.Append(c);
                    }
                }
                return builder.ToString();
            }
            return HttpUtility.UrlEncode(text);
        }

        public static string ToUrlDecode(this string text)
        {
            return HttpUtility.UrlDecode(text);
        }
        #endregion

        public static string DownFile(this string url)
        {
            string result = "";
            try
            {
                if (File.Exists(url))
                    return url;
                string dirPath = System.IO.Directory.GetCurrentDirectory() + "\\cache\\";
                if (!Directory.Exists(dirPath))
                    Directory.CreateDirectory(dirPath);

                result = dirPath + Guid.NewGuid().ToString() + ".jpg";

                WebRequest requestPic = WebRequest.Create(url);

                WebResponse responsePic = requestPic.GetResponse();

                Image webImage = Image.FromStream(responsePic.GetResponseStream()); // Error
                webImage.Save(result);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("DownFile", ex, url);
            }
            return result;
        }

        public static string DownMp4File(this string url)
        {
            string result = "";
            try
            {
                if (File.Exists(url))
                    return url;
                string dirPath = System.IO.Directory.GetCurrentDirectory() + "\\cache\\video\\";
                if (!Directory.Exists(dirPath))
                    Directory.CreateDirectory(dirPath);

                WebClient mywebclient = new WebClient();
                byte[] Bytes = mywebclient.DownloadData(url);

                string fileName = Guid.NewGuid().ToString();

                if (Bytes.Length > 2)
                {
                    string extenValue = Bytes[0].ToString() + Bytes[1].ToString();

                    string fileUrl = dirPath + fileName + "." + Enum.GetName(typeof(FileExtension), int.Parse(extenValue));

                    using (FileStream fs = new FileStream(fileUrl, FileMode.Create, FileAccess.Write))
                    {
                        fs.Write(Bytes, 0, Bytes.Length);
                        fs.Close();
                    }

                    result = fileUrl;
                }

            }
            catch (Exception ex)
            {
                LogHelper.WriteException("DownMp4File", ex, url);
            }
            return result;
        }

        public static string DownGif(this string url)
        {
            string result = "";
            try
            {
                if (File.Exists(url))
                    return url;
                string dirPath = System.IO.Directory.GetCurrentDirectory() + "\\cache\\gif\\";
                if (!Directory.Exists(dirPath))
                    Directory.CreateDirectory(dirPath);

                result = dirPath + Guid.NewGuid().ToString() + ".gif";

                byte[] fileData;
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("Accept", "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/x-silverlight, application/x-ms-application, application/x-ms-xbap, application/vnd.ms-xpsdocument, application/xaml+xml, application/QVOD, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, */*");
                    client.Headers.Add("Accept-Encoding", "gzip, deflate");
                    client.Headers.Add("Accept-Language", "zh-cn");
                    client.Headers.Add("UserAgent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.100 Safari/537.36");
                    client.Headers.Add("UA-CPU", "x86");
                    client.Headers.Add("Referer", "https://blog.csdn.net/zhanlurbh/article/details/51066507");
                    fileData = client.DownloadData(url);
                }
                using (FileStream fs =
                      new FileStream(result, FileMode.OpenOrCreate))
                {
                    fs.Write(fileData, 0, fileData.Length);
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("DownGif", ex, url);
            }
            return result;
        }

        #region Url参数解析
        public static string ToUrlParam(this string url, string paramname)
        {
            string result = "";
            try
            {
                Uri uri = new Uri(url);
                string queryString = uri.Query;
                NameValueCollection col = GetQueryString(queryString);
                if (col.HasKeys())
                {
                    result = col[paramname];
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("ToUrlParam", ex, url);
            }
            return result;
        }

        /// <summary>
        /// 将查询字符串解析转换为名值集合.
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        static NameValueCollection GetQueryString(string queryString)
        {
            return GetQueryString(queryString, null, true);
        }

        /// <summary>
        /// 将查询字符串解析转换为名值集合.
        /// </summary>
        /// <param name="queryString"></param>
        /// <param name="encoding"></param>
        /// <param name="isEncoded"></param>
        /// <returns></returns>
        static NameValueCollection GetQueryString(string queryString, Encoding encoding, bool isEncoded)
        {
            queryString = queryString.Replace("?", "");
            NameValueCollection result = new NameValueCollection(StringComparer.OrdinalIgnoreCase);
            if (!string.IsNullOrEmpty(queryString))
            {
                int count = queryString.Length;
                for (int i = 0; i < count; i++)
                {
                    int startIndex = i;
                    int index = -1;
                    while (i < count)
                    {
                        char item = queryString[i];
                        if (item == '=')
                        {
                            if (index < 0)
                            {
                                index = i;
                            }
                        }
                        else if (item == '&')
                        {
                            break;
                        }
                        i++;
                    }
                    string key = null;
                    string value = null;
                    if (index >= 0)
                    {
                        key = queryString.Substring(startIndex, index - startIndex);
                        value = queryString.Substring(index + 1, (i - index) - 1);
                    }
                    else
                    {
                        key = queryString.Substring(startIndex, i - startIndex);
                    }
                    if (isEncoded)
                    {
                        result[MyUrlDeCode(key, encoding)] = MyUrlDeCode(value, encoding);
                    }
                    else
                    {
                        result[key] = value;
                    }
                    if ((i == (count - 1)) && (queryString[i] == '&'))
                    {
                        result[key] = string.Empty;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 解码URL.
        /// </summary>
        /// <param name="encoding">null为自动选择编码</param>
        /// <param name="str"></param>
        /// <returns></returns>
        static string MyUrlDeCode(string str, Encoding encoding)
        {
            if (encoding == null)
            {
                Encoding utf8 = Encoding.UTF8;
                //首先用utf-8进行解码                     
                string code = HttpUtility.UrlDecode(str.ToUpper(), utf8);
                //将已经解码的字符再次进行编码.
                string encode = HttpUtility.UrlEncode(code, utf8).ToUpper();
                if (str == encode)
                    encoding = Encoding.UTF8;
                else
                    encoding = Encoding.GetEncoding("gb2312");
            }
            return HttpUtility.UrlDecode(str, encoding);
        }
        #endregion
    }
}
