/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_QueryPIDRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-26 17:41:38 
备注说明 : 查询PID--请求参数

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDRequest
{
    /// <summary>
    /// 查询PID--请求参数
    /// </summary>
    public class Super_QueryPIDRequest
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        public Super_QueryPID_Param pidReq { get; set; }
    }

    public class Super_QueryPID_Param {
        /// <summary>
        /// 联盟ID
        /// </summary>
        public long unionId { get; set; }

        /// <summary>
        /// 子站长ID
        /// </summary>
        public long childUnionId { get; set; }

        /// <summary>
        /// 推广类型,1APP推广 2聊天工具推广
        /// </summary>
        public int promotionType { get; set; }

        /// <summary>
        /// 子站长的推广位名称，如不存在则创建，不填则由联盟根据母账号信息创建
        /// </summary>
        public string positionName { get; set; }

        /// <summary>
        /// 媒体名称，即子站长的app应用名称，推广方式为app推广时必填，且app名称必须为已存在的app名称
        /// </summary>
        public string mediaName { get; set; }
    }
}
