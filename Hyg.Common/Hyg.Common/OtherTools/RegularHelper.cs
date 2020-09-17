/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : RegularHelper.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 18:31:01 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Hyg.Common.OtherTools
{
    /// <summary>
    /// RegularHelper
    /// </summary>
    public class RegularHelper
    {
        public const string tb_rule = "((http|https)(://detail.tmall.com|://item.taobao.com|://chaoshi.detail.tmall.com)|[^a-zA-Z=/\\d@<\\u4E00-\\u9FA5]([a-zA-Z0-9]{11})[^a-zA-Z=.\\d@>\\u4E00-\\u9FA5])";
        public const string jd_rule = "(http|https)(://item.jd.com|://item.m.jd.com|://m.yiyaojd.com|://mitem.jkcsjd.com|://u.jd.com)";
        public const string pdd_rule = "((http|https)(://mobile.yangkeduo.com|://p.pinduoduo.com))";


        #region 商品类正则校验
        /// <summary>
        /// 淘宝商品正则校验
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static bool GoodRegularParseByTB(string content, ref string result, ref string itemid, ref string activityId, ref bool ispwd)
        {
            bool returnStatus = false;
            try
            {
                if (!string.IsNullOrWhiteSpace(tb_rule))
                {
                    //正则中包含口令和链接的判断
                    string str = getValue(tb_rule, content);

                    if (!string.IsNullOrWhiteSpace(str))
                    {
                        if (str.StartsWith("http"))
                        {
                            #region 把文本内容按行隔开
                            string[] rowData = content.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                            foreach (var item in rowData)
                            {
                                if (item.Contains("activityId=") && string.IsNullOrEmpty(activityId))//只获取第一个优惠券id
                                {
                                    activityId = getValue("(?<=(activityId=)).*?(?=(\n|$))", item).Replace("\r", "");//优惠券ID
                                    continue;
                                }
                                if (string.IsNullOrWhiteSpace(itemid))
                                {
                                    itemid = getValue("(?<=(id=))[0-9]{5,}", item);
                                    if (!string.IsNullOrWhiteSpace(itemid))
                                        continue;
                                }

                                if (result != "")
                                    result += "\r";
                                result += item;
                            }
                            #endregion


                            if (!string.IsNullOrWhiteSpace(itemid))
                                returnStatus = true;
                        }
                        else
                        {
                            result = str;//淘口令信息
                            returnStatus = true;
                            ispwd = true;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GoodRegularParseByTB", ex);
            }

            return returnStatus;
        }

        /// <summary>
        /// 京东商品正则校验
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static bool GoodRegularParseByJD(ref string content, ref string result, ref string itemid, ref string activityId, ref bool isneedapiparse)
        {
            bool returnStatus = false;
            try
            {
                if (!string.IsNullOrWhiteSpace(jd_rule))
                {
                    string str = getValue(jd_rule, content);
                    if (!str.IsEmpty())
                    {
                        result = getValue(@"(https://u.jd.com/[a-zA-Z0-9]{6})", content);//获取商品短链接
                        #region 判断是否为京东短链接
                        if (!result.IsEmpty())
                        {
                            returnStatus = true;
                            isneedapiparse = true;//是否需要api解析
                        }
                        else
                        {
                            List<string> url_result_list = getValues(@"(https?|ftp|file)://[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]", content);
                            if (url_result_list.Count > 1)
                            {
                                string[] rowData = content.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                                content = "";
                                foreach (var item in rowData)
                                {
                                    if (string.IsNullOrWhiteSpace(activityId))
                                    {
                                        activityId = getValue("(?<=(key=)).*?(?=(&|\n|$))", item).Replace("\r", "");//优惠券ID
                                        if (!string.IsNullOrWhiteSpace(activityId))
                                            continue;
                                    }


                                    if (string.IsNullOrWhiteSpace(itemid))
                                    {
                                        itemid = getValue(@"(?<=(wareId=))([1-9]\d*\.?\d*)|\d+(?=(.html))", item);//获取商品ID
                                        if (!string.IsNullOrWhiteSpace(itemid))
                                            continue;
                                    }

                                    if (content != "")
                                        content += "\r";
                                    content += item;
                                }
                                if (!itemid.IsEmpty())
                                {
                                    returnStatus = true;
                                    result = "[领券地址]";
                                    content += "\r领券地址:[领券地址]";
                                }
                            }
                            else
                            {
                                if (url_result_list.Count == 1)
                                {
                                    result = url_result_list[0];//获取文案中的url
                                    activityId = getValue("(?<=(key=)).*?(?=(&|\n|$))", result).Replace("\r", "");//优惠券ID

                                    itemid = getValue(@"(?<=(wareId=))([1-9]\d*\.?\d*)|\d+(?=(.html))", result);//获取商品ID
                                    if (!itemid.IsEmpty())
                                        returnStatus = true;
                                }
                            }
                        }
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GoodRegularParseByJD", ex);
            }

            return returnStatus;
        }

        /// <summary>
        /// 拼多多商品正则校验
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static bool GoodRegularParseByPDD(ref string content, ref string result, ref string itemid, ref string activityId, ref bool isneedapiparse)
        {
            bool returnStatus = false;
            try
            {
                if (!string.IsNullOrWhiteSpace(pdd_rule))
                {
                    string str = getValue(pdd_rule, content);
                    if (!str.IsEmpty())
                    {
                        result = getValue(@"(https://p.pinduoduo.com/[a-zA-Z0-9]{8})", content);//获取商品短链接
                        #region 判断是否为拼多多短链接
                        if (!result.IsEmpty())
                        {
                            returnStatus = true;
                            isneedapiparse = true;//是否需要api解析
                        }
                        else
                        {
                            List<string> url_result_list = getValues(@"(https?|ftp|file)://[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]", content);
                            if (url_result_list.Count > 1)
                            {
                                string[] rowData = content.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                                foreach (var item in rowData)
                                {
                                    if (string.IsNullOrWhiteSpace(itemid))
                                    {
                                        itemid = getValue(@"(?<=goods_id=)([0-9]{6,15})", item);//获取商品ID
                                        if (!string.IsNullOrWhiteSpace(itemid))
                                            continue;
                                    }

                                    if (content != "")
                                        content += "\r";
                                    content += item;
                                }
                                if (!itemid.IsEmpty())
                                {
                                    returnStatus = true;
                                    result = "[领券地址]";
                                    content += "\r领券地址:[领券地址]";
                                }
                            }
                            else
                            {
                                result = getValue(@"(https?|ftp|file)://[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]", content);//获取文案中的url

                                itemid = getValue(@"(?<=goods_id=)([0-9]{6,15})", result);//获取商品ID
                                if (!itemid.IsEmpty())
                                    returnStatus = true;
                            }
                        }
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GoodRegularParseByPDD", ex);
            }

            return returnStatus;
        }
        #endregion

        #region QQ消息正则判断
        public static bool RegularParseByQQ(string content, ref string textcontent, ref string fileurl)
        {
            bool returnStatus = false;
            try
            {
                string imageUrl = getValue("(?<=(CQ:image,file=)).*?(?=(]))", content);
                if (string.IsNullOrWhiteSpace(imageUrl))
                    return returnStatus;
                string fullPath = "[CQ:image,file=" + imageUrl + "]";
                imageUrl = imageUrl + ".cqimg";
                imageUrl = System.AppDomain.CurrentDomain.BaseDirectory + @"KQAir\data\image\" + imageUrl;
                //if (File.Exists(imageUrl)) //2020-09-01 暂时屏蔽
                //    fileurl = IniHelper.GetIniKeyValueByFullFileName(imageUrl, "image", "url");

                textcontent = content.Replace(fullPath, "").Trim(); ;
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("RegularParseByQQ", ex);
            }

            return returnStatus;
        }
        #endregion

        /// <summary>
        /// 执行正则表达式并返回值
        /// </summary>
        /// <param name="parn"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string getValue(string parn, string content)
        {
            Regex reg = new Regex(parn);
            return reg.Match(content).Value;
        }

        public static List<string> getValues(string parn, string content)
        {
            List<string> values = new List<string>();
            Regex reg = new Regex(parn);
            MatchCollection matchCollection = reg.Matches(content);
            foreach (Match m in matchCollection)
            {
                values.Add(m.Value);
            }
            return values;
        }
    }
}
