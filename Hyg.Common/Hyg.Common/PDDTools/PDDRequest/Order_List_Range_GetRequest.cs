/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Order_List_Range_GetRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-22 15:06:40 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// Order_List_Range_GetRequest
    /// </summary>
    public class Order_List_Range_GetRequest
    {
        /// <summary>
        /// 支付结束时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string end_time { get; set; }

        /// <summary>
        /// 支付起始时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string start_time { get; set; }

        /// <summary>
        /// 上一次的迭代器id(第一次不填)
        /// </summary>
        public string last_order_id { get; set; }

        /// <summary>
        /// 每次请求多少条，建议300
        /// </summary>
        public int page_size { get; set; } = 300;

        /// <summary>
        /// 订单类型：1-推广订单；2-直播间订单
        /// </summary>
        public int query_order_type { get; set; } = 1;
    }
}
