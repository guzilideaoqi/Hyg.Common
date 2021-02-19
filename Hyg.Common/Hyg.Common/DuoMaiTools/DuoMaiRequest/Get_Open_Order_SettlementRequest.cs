/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : Get_Open_Order_SettlementRequest.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-19 16:54:04 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DuoMaiTools.DuoMaiRequest
{
    /// <summary>
    /// 结算变动查询请求参数
    /// </summary>
    public class Get_Open_Order_SettlementRequest
    {
        /// <summary>
        /// 下单开始时间，秒时间戳，注：时间跨度不能超过1天
        /// </summary>
        public string stime { get; set; }

        /// <summary>
        /// 下单结束时间，秒时间戳，注：时间跨度不能超过1天
        /// </summary>
        public string etime { get; set; }

        /// <summary>
        /// 计划id
        /// </summary>
        public string ads_id { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string order_sn { get; set; }

        /// <summary>
        /// 反馈标签
        /// </summary>
        public string euid { get; set; }

        /// <summary>
        /// 页码 默认1
        /// </summary>
        public int page { get; set; } = 1;

        /// <summary>
        /// 分页大小 默认20 最大200
        /// </summary>
        public int page_size { get; set; } = 20;
    }
}
