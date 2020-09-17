/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Class1.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:40:37 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// Class1
    /// </summary>
    public class NewFriendInfo
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string wxid { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 用户号
        /// </summary>
        public string alias { get; set; }
        /// <summary>
        /// v1参数
        /// </summary>
        public string v1 { get; set; }
        /// <summary>
        /// v2参数
        /// </summary>
        public string v2 { get; set; }
        /// <summary>
        /// 高清大图
        /// </summary>
        public string bigheadimgurl { get; set; }
        /// <summary>
        /// 缩略小图
        /// </summary>
        public string smallheadimgurl { get; set; }

        /// <summary>
        /// 所属微信的wxid
        /// </summary>
        public string sourcewxid { get; set; }

        /// <summary>
        /// 上级用户wxid
        /// </summary>
        public string parent_wxid { get; set; }

        /// <summary>
        /// 上级用户昵称
        /// </summary>
        public string parent_nickname { get; set; }
    }
}
