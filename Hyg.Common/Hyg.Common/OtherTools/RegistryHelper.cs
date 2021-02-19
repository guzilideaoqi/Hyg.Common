/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : RegistryHelper.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-18 10:47:11 
备注说明 : 

 =====================================End=======================================================*/
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.OtherTools
{
    /// <summary>
    /// 注册表管理工具类
    /// </summary>
    public class RegistryHelper
    {
        /// <summary>
        /// 写入内容到注册表
        /// </summary>
        /// <param name="registryHive">注册表模块</param>
        /// <param name="address">注册表路径</param>
        /// <param name="key">写入内容名称</param>
        /// <param name="content">写入内容</param>
        public static void WriteContent(RegistryHive registryHive, string address, string key, string content)
        {
            try
            {
                RegistryKey localKey = GetBaseRegistryKey(registryHive);
                RegistryKey rk2 = localKey.CreateSubKey(address);
                rk2.SetValue(key, content, RegistryValueKind.String);
                rk2.Close();
                localKey.Close();
            }
            catch (Exception)
            {
                throw new Exception("注册表写入失败!");
            }
        }

        /// <summary>
        /// 读取注册表内容
        /// </summary>
        /// <param name="registryHive">注册表模块</param>
        /// <param name="address">注册表路径</param>
        /// <param name="key">读取内容名称</param>
        public static string ReadContent(RegistryHive registryHive, string address, string key)
        {
            string content = "";
            try
            {
                RegistryKey localKey = GetBaseRegistryKey(registryHive);
                RegistryKey rk2 = localKey.CreateSubKey(address);
                object val = rk2.GetValue(address);
                if (!val.IsEmpty())
                {
                    content = val.ToString();
                }

                rk2.Close();
                localKey.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("注册表读取失败:" + ex.Message);
            }

            return content;
        }

        /// <summary>
        /// 删除注册表项
        /// </summary>
        /// <param name="registryHive">注册表模块</param>
        /// <param name="address">注册表路径</param>
        /// <param name="key">删除内容名称</param>
        public static void DeleteContent(RegistryHive registryHive, string address, string key)
        {
            try
            {
                RegistryKey localKey = GetBaseRegistryKey(registryHive);
                RegistryKey rk2 = localKey.CreateSubKey(address);
                rk2.DeleteValue(key);
                rk2.Close();
                localKey.Close();
            }
            catch (Exception)
            {
                throw new Exception("注册表删除失败!");
            }
        }

        static RegistryKey GetBaseRegistryKey(RegistryHive registryHive)
        {
            RegistryKey localKey;
            if (Environment.Is64BitOperatingSystem)
                localKey = RegistryKey.OpenBaseKey(registryHive, RegistryView.Registry64);
            else
                localKey = RegistryKey.OpenBaseKey(registryHive, RegistryView.Registry32);

            return localKey;
        }
    }
}
