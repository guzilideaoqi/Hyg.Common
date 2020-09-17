/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Recv_Accept_Friend_MsgEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:30:59 
备注说明 : 微信新好友消息

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// 微信新好友消息
    /// </summary>
    public class Recv_Accept_Friend_MsgEntity:BaseEntity
    {
        public string raw_msg { get; set; }
    }
}
