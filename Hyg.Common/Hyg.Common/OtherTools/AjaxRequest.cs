/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : AjaxRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:34:25 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Hyg.Common.OtherTools
{
    /// <summary>
    /// AjaxRequest
    /// </summary>
    public class AjaxRequest
    {
        static HttpWebResponse response = null;
        public static string HttpPost(string Url, string postDataStr, Dictionary<string, string> header = null, string cookie = "",string contenttype= "application/x-www-form-urlencoded;charset=UTF-8")
        {
            string token = "";
            try
            {
                System.Net.ServicePointManager.Expect100Continue = false;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                request.Method = "POST";
                request.ContentType = contenttype;
                //request.ContentLength = postDataStr.Length;
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)";

                if (header == null)
                {
                    header = new Dictionary<string, string>();
                }

                foreach (KeyValuePair<string, string> item in header)
                {
                    request.Headers.Add(item.Key, item.Value);
                    if (item.Key == "token")
                        token = item.Value;
                }

                byte[] byteData = Encoding.UTF8.GetBytes(postDataStr);
                int length = byteData.Length;
                request.ContentLength = length;
                Stream writer = request.GetRequestStream();
                writer.Write(byteData, 0, length);
                writer.Close();

                /*StreamWriter write = new StreamWriter(request.GetRequestStream(), Encoding.ASCII);
                write.Write(postDataStr);
                write.Flush();*/
                response = (HttpWebResponse)request.GetResponse();

                string encoding = response.ContentEncoding; if (encoding == null || encoding.Length < 1)
                {
                    encoding = "UTF-8";
                }
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
                string retstring = reader.ReadToEnd();

                return retstring;
            }
            catch (WebException ex)
            {
                LogHelper.WriteException("HttpPost", ex);
                return "";
            }

        }

        public static string HttpGet(string Url, string postDataStr, Dictionary<string, string> header = null, bool parseLogin = true)
        {
            string token = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);
                request.Method = "GET";
                request.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)";

                if (header == null)
                {
                    header = new Dictionary<string, string>();
                }

                foreach (KeyValuePair<string, string> item in header)
                {
                    request.Headers.Add(item.Key, item.Value);
                    if (item.Key == "token")
                        token = item.Value;
                }
                response = (HttpWebResponse)request.GetResponse();

                //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();

                return retString;
            }
            catch (WebException ex)
            {
                LogHelper.WriteException("HttpGet", ex);
                return "";
            }

        }
    }
}
