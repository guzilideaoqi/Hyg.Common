/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : BaseEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:29:59 
备注说明 : 微信消息基类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// 微信消息基类
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// 发消息的成员
        /// </summary>
        public string from_wxid { get; set; }

        /// <summary>
        /// 消息来源(0非pc端  1pc端)
        /// </summary>
        public int is_pc { get; set; }

        /// <summary>
        /// 消息id
        /// </summary>
        public string msgid { get; set; }

        /// <summary>
        /// 群ID
        /// </summary>
        public string room_wxid { get; set; }

        /// <summary>
        /// 消息记录时间
        /// </summary>
        public long timestamp { get; set; }

        /// <summary>
        /// 接受对象  (如果包含chatroom  则是群组   否则为私聊)
        /// </summary>
        public string to_wxid { get; set; }

        /// <summary>
        /// 微信原始消息类型
        /// </summary>
        public int wx_type { get; set; }

        public uint dw_clientid { get; set; }
    }
}
