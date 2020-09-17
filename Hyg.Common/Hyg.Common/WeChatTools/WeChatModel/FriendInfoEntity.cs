/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : FriendInfoEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 16:58:31 
备注说明 : 微信好友实体类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// 微信好友实体
    /// </summary>
    public class FriendInfoEntity
    {
        /// <summary>
        /// wxid
        /// </summary>
        public string wxid { get; set; }
        /// <summary>
        /// 微信号(有可能为空)
        /// </summary>
        public string account { get; set; }
        /// <summary>
        /// 微信昵称
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 好友备注
        /// </summary>
        public string remark { get; set; }
        /// <summary>
        /// 头像的url地址
        /// </summary>
        public string avatar { get; set; }
        /// <summary>
        /// 性别:0未知，1男,2女
        /// </summary>
        public int sex { get; set; }
        /// <summary>
        /// 祖国(可能为空)
        /// </summary>
        public string country { get; set; }
        /// <summary>
        /// 省份(可能为空)
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 城市(可能为空)
        /// </summary>
        public string city { get; set; }
    }
}
