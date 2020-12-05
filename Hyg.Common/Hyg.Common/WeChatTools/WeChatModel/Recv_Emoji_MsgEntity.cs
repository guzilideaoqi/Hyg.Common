/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Recv_Emoji_MsgEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-12-05 16:52:04 
备注说明 : 接收到的emoji消息

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// 接收到的emoji消息
    /// </summary>
    public class Recv_Emoji_MsgEntity : BaseEntity
    {
        /// <summary>
        /// 卡牌原始文案
        /// </summary>
        public string raw_msg { get; set; }
        /// <summary>
        /// 二级类别
        /// </summary>
        public int wx_sub_type { get; set; }

        public string ImageUrl { get; set; }
    }
}
