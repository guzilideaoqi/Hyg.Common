/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Md5Helper.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:37:22 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Hyg.Common.OtherTools
{
    /// <summary>
    /// Md5Helper
    /// </summary>
    public class Md5Helper
    {
        public static string Md5(string value)
        {
            var result = string.Empty;
            if (string.IsNullOrEmpty(value)) return result;
            using (var md5 = MD5.Create())
            {
                result = GetMd5Hash(md5, value);
            }
            return result;
        }


        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();
            foreach (byte t in data)
            {
                sBuilder.Append(t.ToString("x2"));
            }
            return sBuilder.ToString();
        }
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            var hashOfInput = GetMd5Hash(md5Hash, input);
            var comparer = StringComparer.OrdinalIgnoreCase;
            return 0 == comparer.Compare(hashOfInput, hash);
        }

        public static string Md5Hex(string data)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dataHash = md5.ComputeHash(Encoding.UTF8.GetBytes(data));
            StringBuilder sb = new StringBuilder();
            foreach (byte b in dataHash)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
}
