/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_QueryPositionRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-26 15:41:02 
备注说明 : 查询推广位【申请】

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDRequest
{
    /// <summary>
    /// 查询推广位【申请】
    /// </summary>
    public class Super_QueryPositionRequest
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public Super_QueryPosition_Param positionReq { get; set; }
    }

    public class Super_QueryPosition_Param
    {
        /// <summary>
        /// 需要查询的目标联盟id
        /// </summary>
        public long unionId { get; set; }

        /// <summary>
        /// 推客unionid对应的“授权Key”，在联盟官网-我的工具-我的API中查询，授权Key具有唯一性，有效期365天，删除或创建新的授权Key后原有的授权Key自动失效
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// 3：私域推广位，上限5000个，不在联盟后台展示，无对应 PID；4：联盟后台推广位，上限500个，会在推客联盟后台展示，可用于内容平台推广
        /// </summary>
        public int unionType { get; set; }

        /// <summary>
        /// 页码，上限100
        /// </summary>
        public int pageIndex { get; set; } = 1;

        /// <summary>
        /// 每页条数，上限100
        /// </summary>
        public int pageSize { get; set; } = 20;
    }
}
