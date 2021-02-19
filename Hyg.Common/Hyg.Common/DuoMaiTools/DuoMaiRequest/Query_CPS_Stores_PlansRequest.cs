/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : Query_CPS_Stores_PlansRequest.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-19 9:44:04 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DuoMaiTools.DuoMaiRequest
{
    /// <summary>
    /// 查询推广计划请求参数
    /// </summary>
    public class Query_CPS_Stores_PlansRequest
    {
        /// <summary>
        /// 关键词
        /// </summary>
        public string query { get; set; }

        /// <summary>
        /// 所属商城ID，来自商城列表的id
        /// </summary>
        public string store_id { get; set; }

        /// <summary>
        /// 1查询已申请的计划  0查询全部
        /// </summary>
        public int is_apply { get; set; } = 0;

        /// <summary>
        /// 页码 默认1
        /// </summary>
        public int page { get; set; } = 1;

        /// <summary>
        /// 分页大小  默认20  最大200
        /// </summary>
        public int page_size { get; set; } = 20;
    }
}
