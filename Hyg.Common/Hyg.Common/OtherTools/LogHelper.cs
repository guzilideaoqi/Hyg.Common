/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : LogHelper.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:01:40 
备注说明 : 日志处理类

 =====================================End=======================================================*/
using Hyg.Common.WeChatTools.WeChatModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Hyg.Common.OtherTools
{
    /// <summary>
    /// 日志处理
    /// </summary>
    public class LogHelper
    {
        static string errorInfo = "【错误类型】=>{0}\r\n【方法名称】=>{1}\r\n【请求参数】=>{2}\r\n【用户Token】=>{3}\r\n【异常消息】=>{4}\r\n【异常位置】=>{5}\r\n";
        /// <summary>
        /// 记录错误日志
        /// </summary>
        /// <param name="level">1调试  2错误  3异常 4api</param>
        /// <param name="text"></param>
        /// <param name="excuteParam"></param>
        /// <param name="isSubmitServer"></param>
        public static void WriteLog(int level, string text, bool isSubmitServer = true)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory;
                path = System.IO.Path.Combine(path, "Logs\\");

                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }
                string fileFullName = System.IO.Path.Combine(path
                , string.Format("{0}.txt", DateTime.Now.ToString("yyyyMMdd")));


                using (StreamWriter output = System.IO.File.AppendText(fileFullName))
                {
                    string baseText = DateTime.Now.ToString("【时间】=>yyyy-MM-dd HH:mm:ss fff\r\n") + text;
                    output.WriteLine(baseText);

                    output.Close();
                }

                if (isSubmitServer)
                {
                    //RequstDataOperate.SubmitLogInfo(level, text);
                }
            }
            catch (Exception)
            {
            }
        }

        public static void WriteException(string fnName, Exception ex, string excuteParam = "")
        {
            WriteLog(3, string.Format(errorInfo, "Exception", fnName, excuteParam, CommonCacheConfig.token, ex.Message, ex.StackTrace));
        }

        /// <summary>
        /// 记录接口异常信息
        /// </summary>
        /// <param name="api"></param>
        /// <param name="param"></param>
        /// <param name="httpWebResponse"></param>
        public static void WriteExceptionApi(string api, string param, WebException ex)
        {
            HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
            if (httpWebResponse.IsEmpty())
            {
                WriteLog(4, string.Format(errorInfo + "【状态码】=>无\r\n", "Exception", api, param, CommonCacheConfig.token, "【错误信息详情】" + (ex.IsEmpty() ? "未知错误" : ex.ToJsonStr()), (ex.IsEmpty() ? "接口请求异常,但无返回的错误信息" : ex.Message)));
            }
            else
            {
                WriteLog(4, string.Format(errorInfo + "【状态码】=>" + httpWebResponse.StatusCode.ToString() + "\r\n", "Exception", api, param, CommonCacheConfig.token, "【错误信息详情】" + httpWebResponse.ToJsonStr(), httpWebResponse.StatusDescription));
            }
        }

        public static void WriteLog(string fnName, string text)
        {
            WriteLog(2, string.Format(errorInfo, "Error", fnName, "", CommonCacheConfig.token, text, ""));
        }

        public static void WriteDebugLog(string fnName, string text)
        {
            WriteLog(1, string.Format(errorInfo, "Debug", fnName, "", CommonCacheConfig.token, text, ""));
        }
    }
}
