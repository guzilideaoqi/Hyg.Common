/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Recv_Link_MsgEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:32:37 
备注说明 : 微信卡牌消息

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// 微信卡牌消息
    /// </summary>
    public class Recv_Link_MsgEntity:BaseEntity
    {
        /// <summary>
        /// 卡牌原始文案
        /// </summary>
        public string raw_msg { get; set; }
        /// <summary>
        /// 二级类别
        /// </summary>
        public int wx_sub_type { get; set; }
    }
}
