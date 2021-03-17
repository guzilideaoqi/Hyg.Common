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

        public static string HttpGet(string Url, string postDataStr, CookieContainer myCookieContainer, string ContentType = "application/x-www-form-urlencoded;charset=UTF-8", string UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)")
        {
            string token = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);
                request.Method = "GET";
                request.ContentType = ContentType;
                request.UserAgent = UserAgent;

                request.CookieContainer = myCookieContainer;

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



        /// <summary>
        /// 获取重定向地址
        /// </summary>
        /// <param name="Url">原地址</param>
        /// <param name="type">浏览器类型（0PC/1手机）</param>
        /// <returns></returns>
        public static string GetRedirectUrl(string url, int type = 0)
        {
            string strResult = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "HEAD";
                request.AllowAutoRedirect = false;
                var UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.861.0 Safari/535.2";
                if (type > 0)
                {//模拟手机浏览器
                    UserAgent = "Mozilla/5.0 (Linux; U; Android 2.2; en-us; Nexus One Build/FRF91) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1";
                }
                request.UserAgent = UserAgent;
                request.ContentType = "application/x-www-form-urlencoded";
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                using (WebResponse response = request.GetResponse())
                {
                    strResult = response.Headers["Location"];      //重定向地址
                }
            }
            catch (Exception ex)
            {
                throw new Exception("地址重定向错误!");
            }
            return strResult;
        }

        /// <summary>
        /// 获取页面html
        /// </summary>
        /// <param name="Url">页面路径</param>
        /// <param name="type">浏览器类型（0PC/1手机）</param>
        /// <returns></returns>
        public static string GetWebContent(string Url, int type = 0)
        {
            string strResult = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                //声明一个HttpWebRequest请求 
                request.Method = "POST";
                var UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.861.0 Safari/535.2";
                if (type > 0)
                {//模拟手机浏览器
                    UserAgent = "Mozilla/5.0 (Linux; U; Android 2.2; en-us; Nexus One Build/FRF91) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1";
                }
                request.UserAgent = UserAgent;

                request.ContentType = "application/x-www-form-urlencoded";
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                strResult = sr.ReadToEnd();
                response.Close();
            }
            catch
            {
                throw new Exception("未获取到Html内容!");
            }
            return strResult;
        }

        #region FormData数据提交
        /// <summary>
        /// 使用Post方法获取字符串结果
        /// </summary>
        /// <param name="url"></param>
        /// <param name="formItems">Post表单内容</param>
        /// <param name="cookieContainer"></param>
        /// <param name="timeOut">默认20秒</param>
        /// <param name="encoding">响应内容的编码类型（默认utf-8）</param>
        /// <returns></returns>
        public static string PostForm(string url, List<FormItemModel> formItems, CookieContainer cookieContainer = null, string refererUrl = null, Encoding encoding = null, int timeOut = 20000)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            #region 初始化请求对象
            request.Method = "POST";
            request.Timeout = timeOut;
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            request.KeepAlive = true;
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36";
            if (!string.IsNullOrEmpty(refererUrl))
                request.Referer = refererUrl;
            if (cookieContainer != null)
                request.CookieContainer = cookieContainer;
            #endregion

            string boundary = "----" + DateTime.Now.Ticks.ToString("x");//分隔符
            request.ContentType = string.Format("multipart/form-data; boundary={0}", boundary);
            //请求流
            var postStream = new MemoryStream();
            #region 处理Form表单请求内容
            //是否用Form上传文件
            var formUploadFile = formItems != null && formItems.Count > 0;
            if (formUploadFile)
            {
                //文件数据模板
                string fileFormdataTemplate =
                    "\r\n--" + boundary +
                    "\r\nContent-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"" +
                    "\r\nContent-Type: application/octet-stream" +
                    "\r\n\r\n";
                //文本数据模板
                string dataFormdataTemplate =
                    "\r\n--" + boundary +
                    "\r\nContent-Disposition: form-data; name=\"{0}\"" +
                    "\r\n\r\n{1}";
                foreach (var item in formItems)
                {
                    string formdata = null;
                    if (item.IsFile)
                    {
                        //上传文件
                        formdata = string.Format(
                            fileFormdataTemplate,
                            item.Key, //表单键
                            item.FileName);
                    }
                    else
                    {
                        //上传文本
                        formdata = string.Format(
                            dataFormdataTemplate,
                            item.Key,
                            item.Value);
                    }

                    //统一处理
                    byte[] formdataBytes = null;
                    //第一行不需要换行
                    if (postStream.Length == 0)
                        formdataBytes = Encoding.UTF8.GetBytes(formdata.Substring(2, formdata.Length - 2));
                    else
                        formdataBytes = Encoding.UTF8.GetBytes(formdata);
                    postStream.Write(formdataBytes, 0, formdataBytes.Length);

                    //写入文件内容
                    if (item.FileContent != null && item.FileContent.Length > 0)
                    {
                        using (var stream = item.FileContent)
                        {
                            byte[] buffer = new byte[1024];
                            int bytesRead = 0;
                            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                            {
                                postStream.Write(buffer, 0, bytesRead);
                            }
                        }
                    }
                }
                //结尾
                var footer = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n");
                postStream.Write(footer, 0, footer.Length);

            }
            else
            {
                request.ContentType = "application/x-www-form-urlencoded";
            }
            #endregion

            request.ContentLength = postStream.Length;

            #region 输入二进制流
            if (postStream != null)
            {
                postStream.Position = 0;
                //直接写入流
                Stream requestStream = request.GetRequestStream();

                byte[] buffer = new byte[1024];
                int bytesRead = 0;
                while ((bytesRead = postStream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    requestStream.Write(buffer, 0, bytesRead);
                }

                ////debug
                //postStream.Seek(0, SeekOrigin.Begin);
                //StreamReader sr = new StreamReader(postStream);
                //var postStr = sr.ReadToEnd();
                postStream.Close();//关闭文件访问
            }
            #endregion

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (cookieContainer != null)
            {
                response.Cookies = cookieContainer.GetCookies(response.ResponseUri);
            }

            using (Stream responseStream = response.GetResponseStream())
            {
                using (StreamReader myStreamReader = new StreamReader(responseStream, encoding ?? Encoding.UTF8))
                {
                    string retString = myStreamReader.ReadToEnd();
                    return retString;
                }
            }
        }
        #endregion
    }
}
