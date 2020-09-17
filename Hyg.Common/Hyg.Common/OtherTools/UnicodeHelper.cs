/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : UnicodeHelper.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 15:46:02 
备注说明 : Unicode编码处理类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Hyg.Common.OtherTools
{
    public class UnicodeHelper
    {
        /// <summary>
        /// Unicode编码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string EnUnicode(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if ((int)text[i] > 32 && (int)text[i] < 127)
                {
                    result += text[i].ToString();
                }
                else
                    result += string.Format("\\u{0:x4}", (int)text[i]);
            }
            return result;
        }

        /// <summary>
        /// Unicode解码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string DeUnicode(string str)
        {
            //最直接的方法Regex.Unescape(str);
            Regex reg = new Regex(@"(?i)\\[uU]([0-9a-f]{4})");
            return reg.Replace(str, delegate (Match m) { return ((char)Convert.ToInt32(m.Groups[1].Value, 16)).ToString(); });
        }
    }
}
