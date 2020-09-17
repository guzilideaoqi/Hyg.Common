/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : GroupMemberResponseEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:52:05 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// GroupMemberResponseEntity
    /// </summary>
    public class GroupMemberResponseEntity
    {
        /// <summary>
        /// 群组id
        /// </summary>
        public string group_wxid { get; set; }

        /// <summary>
        /// 群成员列表
        /// </summary>
        public List<Robot_Group_MemberInfoEntity> member_list { get; set; }

        /// <summary>
        /// 群成员数量
        /// </summary>
        public int total { get; set; }
    }
}
