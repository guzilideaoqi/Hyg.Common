/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : Recv_MINIAPP_MsgEntity.cs
创建人员 : Mr.Hu
创建时间 : 2021-03-22 17:47:01 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// 小程序消息
    /// </summary>
    public class Recv_MINIAPP_MsgEntity : BaseEntity
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
