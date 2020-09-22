/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Order_Detail_GetRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-22 11:16:45 
备注说明 : 订单详情请求条件

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 订单详情请求条件
    /// </summary>
    public class Order_Detail_GetRequest
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public string order_sn { get; set; }

        /// <summary>
        /// 订单类型：1-推广订单；2-直播间订单
        /// </summary>
        public int query_order_type { get; set; }
    }
}
