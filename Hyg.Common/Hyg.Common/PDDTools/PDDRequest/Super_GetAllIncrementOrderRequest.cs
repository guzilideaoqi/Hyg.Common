/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_GetAllIncrementOrderRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 9:12:36 
备注说明 : 查询所有授权的多多客订单--请求参数

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 查询所有授权的多多客订单--请求参数
    /// </summary>
    public class Super_GetAllIncrementOrderRequest
    {
        /// <summary>
        /// 查询结束时间，和开始时间相差不能超过24小时。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
        /// </summary>
        public string end_update_time { get; set; }

        /// <summary>
        /// 第几页，从1到10000，默认1，注：使用最后更新时间范围增量同步时，必须采用倒序的分页方式（从最后一页往回取）才能避免漏单问题。
        /// </summary>
        public int page { get; set; } = 1;

        /// <summary>
        /// 返回的每页结果订单数，默认为100，范围为10到100，建议使用40~50，可以提高成功率，减少超时数量。
        /// </summary>
        public int page_size { get; set; } = 100;

        /// <summary>
        /// 最近90天内多多进宝商品订单更新时间--查询时间开始。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
        /// </summary>
        public string start_update_time { get; set; }

        /// <summary>
        /// 订单类型：1-推广订单；2-直播间订单
        /// </summary>
        public int query_order_type { get; set; }
    }
}
