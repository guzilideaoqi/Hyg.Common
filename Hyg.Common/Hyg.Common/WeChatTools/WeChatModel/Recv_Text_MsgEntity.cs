/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Recv_Text_MsgEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:29:22 
备注说明 : 文本消息类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// 文本消息类
    /// </summary>
    public class Recv_Text_MsgEntity : BaseEntity
    {
        //@对象的id
        public string[] at_user_list { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public string msg { get; set; }
    }
}
