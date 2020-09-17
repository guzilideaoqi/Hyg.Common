/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Recv_System_MsgEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:32:59 
备注说明 : 微信系统消息

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// 微信系统消息
    /// </summary>
    public class Recv_System_MsgEntity:BaseEntity
    {
        /// <summary>
        /// 原始文本
        /// </summary>
        public string raw_msg { get; set; }
    }
}
