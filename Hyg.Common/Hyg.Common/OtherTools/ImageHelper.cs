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

        #region 删除指定时间之前的图片
        public static void DeleteExpireImage(string strFolderPath, DateTime ExpireTime)
        {//删除两个小时之前的图片
            DirectoryInfo dyInfo = new DirectoryInfo(strFolderPath);

            //获取文件夹下所有的文件
            foreach (FileInfo feInfo in dyInfo.GetFiles())
            {
                //if (feInfo.Name == "quan.png")
                //    continue;
                //判断文件日期是否小于今天，是则删除
                if (feInfo.CreationTime < ExpireTime)
                    feInfo.Delete();
            }
        }
        #endregion
    }
}
