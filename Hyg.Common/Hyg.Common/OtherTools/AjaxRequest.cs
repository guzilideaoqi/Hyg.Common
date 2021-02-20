/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : AjaxRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:34:25 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.OtherTools.OtherModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Hyg.Common.OtherTools
{
    /// <summary>
    /// AjaxRequest
    /// </summary>
    public class AjaxRequest
    {
        static HttpWebResponse response = null;
        public static string HttpPost(string Url, string postDataStr, Dictionary<string, string> header = null, string cookie = "", string contenttype = "application/x-www-form-urlencoded;charset=UTF-8")
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

                if (!CommonCacheConfig.token.IsEmpty() && !request.Headers.AllKeys.Contains("token"))
                    request.Headers.Add("token", CommonCacheConfig.token);
                request.Headers.Add("timestamp", DateTimeHelper.ConvertDateTimeToInt(DateTime.Now));

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

        public static string HttpPost(string url, CookieContainer myCookieContainer, string param = null, string ContentType = "application/x-www-form-urlencoded;charset=UTF-8")
        {
            HttpWebRequest httpWebRequest;
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(AjaxRequest.CheckValidationResult);
                httpWebRequest = (WebRequest.Create(url) as HttpWebRequest);
                httpWebRequest.ProtocolVersion = HttpVersion.Version10;
            }
            else
            {
                httpWebRequest = (WebRequest.Create(url) as HttpWebRequest);
            }
            httpWebRequest.CookieContainer = myCookieContainer;
            httpWebRequest.Proxy = null;
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = ContentType;
            httpWebRequest.Accept = "*/*";
            httpWebRequest.Timeout = 15000;
            httpWebRequest.AllowAutoRedirect = false;
            string result = null;
            try
            {
                byte[] byteData = Encoding.UTF8.GetBytes(param);
                int length = byteData.Length;
                httpWebRequest.ContentLength = length;
                Stream writer = httpWebRequest.GetRequestStream();
                writer.Write(byteData, 0, length);
                writer.Close();

                /*StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
                streamWriter.Write(param);
                streamWriter.Close();*/
                WebResponse response = httpWebRequest.GetResponse();
                if (response != null)
                {
                    StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    result = streamReader.ReadToEnd();
                    streamReader.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
            }
            return result;
        }

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
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

                if (!CommonCacheConfig.token.IsEmpty() && !request.Headers.AllKeys.Contains("token"))
                    request.Headers.Add("token", CommonCacheConfig.token);

                request.Headers.Add("timestamp", DateTimeHelper.ConvertDateTimeToInt(DateTime.Now));

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
