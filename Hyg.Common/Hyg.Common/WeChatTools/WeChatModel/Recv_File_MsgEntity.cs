/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Recv_File_MsgEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:31:30 
备注说明 : 微信文件消息

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// 微信文件消息
    /// </summary>
    public class Recv_File_MsgEntity:BaseEntity
    {
        /// <summary>
        /// 文件地址
        /// </summary>
        public string file { get; set; }
        /// <summary>
        /// 原始文本
        /// </summary>
        public string raw_msg { get; set; }

        /// <summary>
        /// 二级类别
        /// </summary>
        public int wx_sub_type { get; set; }
    }
}
