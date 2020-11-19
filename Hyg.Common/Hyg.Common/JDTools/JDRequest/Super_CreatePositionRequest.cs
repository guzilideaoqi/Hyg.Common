/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_CreatePositionRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-26 16:36:33 
备注说明 : 创建推广位【申请】--请求参数

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDRequest
{
    /// <summary>
    /// 创建推广位【申请】--请求参数
    /// </summary>
    public class Super_CreatePositionRequest
    {
        /// <summary>
        /// 创建推广位请求参数
        /// </summary>
        public Super_CreatePosition_Param positionReq { get; set; }
    }

    public class Super_CreatePosition_Param
    {
        /// <summary>
        /// 需要创建的目标联盟id
        /// </summary>
        public long unionId { get; set; }

        /// <summary>
        /// 推客unionid对应的“授权Key”，在联盟官网-我的工具-我的API中查询，授权Key具有唯一性，有效期365天，删除或创建新的授权Key后原有的授权Key自动失效
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// 3：私域推广位，上限5000个，不在联盟后台展示，无对应 PID；4：联盟后台推广位，上限500个，会在推客联盟后台展示，自动生成对应PID，可用于内容平台推广
        /// </summary>
        public int unionType { get; set; }

        /// <summary>
        /// 站点类型 1.网站推广位2.APP推广位3.导购媒体推广位4.聊天工具推广位
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 推广位名称集合，英文,分割；上限50
        /// </summary>
        public string[] spaceNameList { get; set; }

        /// <summary>
        /// 站点ID：网站的ID/app ID/snsID 。当type非4(聊天工具)时，siteId必填
        /// </summary>
        public long? siteId { get; set; }
    }
}
