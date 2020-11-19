/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : FileHelper.cs
创建人员 : Mr.Hu
创建时间 : 2020-11-13 13:40:14 
备注说明 : 文件处理

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Hyg.Common.OtherTools
{
    /// <summary>
    /// 文件处理
    /// </summary>
    public class FileHelper
    {
        /// <summary>
        /// 删除指定时间之前的文件并排除不删除的文件
        /// </summary>
        /// <param name="strFolderPath">文件所属目录</param>
        /// <param name="after_DateTime">删除某个时间点之前的文件</param>
        public static void DeleteImage(string strFolderPath, DateTime after_DateTime, List<string> ExceptFile = null)
        {
            try
            {
                DirectoryInfo dyInfo = new DirectoryInfo(strFolderPath);

                //获取文件夹下所有的文件
                foreach (FileInfo feInfo in dyInfo.GetFiles())
                {
                    if (!ExceptFile.IsEmpty() && ExceptFile.Contains(feInfo.Name))
                        continue;
                    //判断文件日期是否小于今天，是则删除
                    if (feInfo.CreationTime < after_DateTime)
                        feInfo.Delete();
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("DeleteImage", ex);
            }
        }

        /// <summary>
        /// 删除所有文件
        /// </summary>
        /// <param name="strFolderPath"></param>
        public static void DeleteImage(string strFolderPath)
        {
            DeleteImage(strFolderPath, DateTime.Now);
        }

        /// <summary>
        /// 删除指定时间点之前的文件
        /// </summary>
        /// <param name="strFolderPath"></param>
        /// <param name="after_DateTime"></param>
        public static void DeleteImage(string strFolderPath, DateTime after_DateTime)
        {
            DeleteImage(strFolderPath, after_DateTime,null);
        }
    }
}
