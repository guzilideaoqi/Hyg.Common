/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Robot_Group_MemberInfoEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:51:39 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// Robot_Group_MemberInfoEntity
    /// </summary>
    public class Robot_Group_MemberInfoEntity
    {
        /// <summary>
        /// 群组ID
        /// </summary>
        public string group_id { get; set; }
        /// <summary>
        /// 群成员账号
        /// </summary>
        public string account { get; set; }

        /// <summary>
        /// 群成员头像
        /// </summary>
        public string avatar { get; set; }

        /// <summary>
        /// 群成员昵称
        /// </summary>
        public string nickname { get; set; }

        /// <summary>
        /// 群成员备注信息
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 群成员wxid
        /// </summary>
        public string wxid { get; set; }
    }
}
