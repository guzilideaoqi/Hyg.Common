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
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
        public static string GetNewPersonNickName(this string raw_msg)
        {
            string newPersonNickName = "";
            try
            {
                Regex re = new Regex("(?<=\").*?(?=\")", RegexOptions.None);
                MatchCollection mc = re.Matches(raw_msg);
                if (mc.Count == 1)
                {
                    newPersonNickName = mc[0].Value;
                }
                else if (mc.Count == 3)
                {
                    if (raw_msg.Contains("邀请"))
                        newPersonNickName = mc[2].Value;
                    else
                        newPersonNickName = mc[0].Value;
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
        public static string ToJsonStr(this object obj)
        {
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
    }
}
