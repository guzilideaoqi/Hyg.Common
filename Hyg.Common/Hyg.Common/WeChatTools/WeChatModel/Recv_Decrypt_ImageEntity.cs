/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Recv_Decrypt_ImageEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:35:59 
备注说明 : 微信加密图片消息

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// 微信加密图片消息
    /// </summary>
    public class Recv_Decrypt_ImageEntity
    {
        /// <summary>
        /// 解析结果   1解密成功，0解密失败
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// 微信加密图片路径
        /// </summary>
        public string src_file { get; set; }

        /// <summary>
        /// 解密后文件路径
        /// </summary>
        public string dest_file { get; set; }
    }
}
