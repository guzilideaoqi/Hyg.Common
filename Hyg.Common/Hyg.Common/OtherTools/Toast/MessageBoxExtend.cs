/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : MessageBoxExtend.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-24 16:20:45 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hyg.Common.OtherTools.Toast
{
    /// <summary>
    /// MessageBoxExtend
    /// </summary>
    public class MessageBoxExtend
    {
        /// <summary>
        /// 错误消息
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DialogResult ErrorMessage(string text) {
           return MessageBox.Show(text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 警告消息
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DialogResult WarningMessage(string text)
        {
            return MessageBox.Show(text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 错误消息
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DialogResult SuccessMessage(string text)
        {
            return MessageBox.Show(text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
