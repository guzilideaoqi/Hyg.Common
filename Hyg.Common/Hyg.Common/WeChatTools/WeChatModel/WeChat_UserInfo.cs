/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : WeChat_UserInfo.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 15:44:20 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    public class WeChat_UserInfo
    {
        /// <summary>
        /// 头像
        /// </summary>
        public string avatar { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// 进程ID
        /// </summary>
        public int pid { get; set; }

        /// <summary>
        /// 未读消息数量
        /// </summary>
        public int unread_msg_count { get; set; }

        /// <summary>
        /// 个人信息文件夹
        /// </summary>
        public string wx_user_dir { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string wxid { get; set; }

        /// <summary>
        /// 区分客户端
        /// </summary>
        public uint wx_clientid { get; set; }
    }
}
