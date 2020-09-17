/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : ChatRoomInfoEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:26:39 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// ChatRoomInfoEntity
    /// </summary>
    public class ChatRoomInfoEntity
    {
        /// <summary>
        /// wxid
        /// </summary>
        public string wxid { get; set; }
        /// <summary>
        /// 微信昵称
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 头像的url地址
        /// </summary>
        public string avatar { get; set; }
        /// <summary>
        /// 群主的wxid
        /// </summary>
        public string manager_wxid { get; set; }
        /// <summary>
        /// 该群成员总数
        /// </summary>
        public int total_member { get; set; }
        /// <summary>
        /// 自己是否为群主:0不是，1是
        /// </summary>
        public int is_manager { get; set; }
        /// <summary>
        /// 群成员ID
        /// </summary>
        public string[] member_list { get; set; }
    }
}
