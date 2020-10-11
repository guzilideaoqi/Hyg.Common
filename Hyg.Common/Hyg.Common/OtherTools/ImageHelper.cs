/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : ImageHelper.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-25 17:16:18 
备注说明 : 图片助手类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Hyg.Common.OtherTools
{
    /// <summary>
    /// 图片助手类
    /// </summary>
    public class ImageHelper
    {
        #region 下载图片
        /// <summary>
        /// 下载图片
        /// </summary>
        /// <param name="HttpUrl">网络图片地址</param>
        /// <returns></returns>
        public static Image DownImage(string HttpUrl)
        {
            Image O_Image = null;
            try
            {
                O_Image = Image.FromStream(WebRequest.Create(HttpUrl).GetResponse().GetResponseStream());
                return O_Image;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("", ex.Message);
            }
            return O_Image;
        }
        #endregion

        #region 下载图片并保存
        /// <summary>
        /// 下载图片并保存
        /// </summary>
        /// <param name="HttpUrl"></param>
        /// <param name="fileName"></param>
        /// <param name="LocalUrl">本地文件夹地址</param>
        /// <returns></returns>
        public static Image SaveDownImage(string HttpUrl, string FileName, string LocalDir)
        {
            Image O_Image = null;
            try
            {
                string fileFullName = "";
                if (LocalDir.IsEmpty())
                    LocalDir = System.AppDomain.CurrentDomain.BaseDirectory + @"cache\";
                if (FileName.IsEmpty())
                    FileName = Guid.NewGuid().ToString();

                if (!Directory.Exists(LocalDir))
                    Directory.CreateDirectory(LocalDir);

                fileFullName = LocalDir + FileName + ".png";

                O_Image = DownImage(HttpUrl);

                O_Image.Save(fileFullName);
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("", ex.Message);
            }

            return O_Image;
        }
        #endregion

        #region 读取本地图片
        /// <summary>
        /// 读取本地图片
        /// </summary>
        /// <param name="localUrl"></param>
        /// <returns></returns>
        public static Image ReadLocalImage(string LocalUrl)
        {
            Image O_Image = null;
            try
            {
                O_Image = Image.FromFile(LocalUrl);
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("", ex.Message);
            }

            return O_Image;
        }
        #endregion
    }
}
