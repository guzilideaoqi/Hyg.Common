/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : Query_Open_Order_ListRequest.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-19 17:27:10 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DuoMaiTools.DuoMaiRequest
{
    /// <summary>
    /// 订单列表查询
    /// </summary>
    public class Query_Open_Order_ListRequest
    {
        /// <summary>
        /// 推广位id
        /// </summary>
        public string site_id { get; set; }

        /// <summary>
        /// 计划ID
        /// </summary>
        public string ads_id { get; set; }

        /// <summary>
        /// 反馈标签
        /// </summary>
        public string euid { get; set; }

        /// <summary>
        /// 开始时间，秒时间戳，注：时间跨度不能超过1天
        /// </summary>
        public string stime { get; set; }

        /// <summary>
        /// 结束时间，秒时间戳，注：时间跨度不能超过1天
        /// </summary>
        public string etime { get; set; }

        /// <summary>
        /// 时间维度 update_time:更新时间 charge_datatime:结算时间 order_datatime:创建时间 默认update_time
        /// </summary>
        public string order_field { get; set; }

        /// <summary>
        /// 查询在多麦联盟结算状态的订单 可选值： -1 无效 0 未确认 1 确认 2 结算
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// 页码 默认1
        /// </summary>
        public int page { get; set; }

        /// <summary>
        /// 分页大小 默认20 最大200
        /// </summary>
        public int page_size { get; set; }
    }
}
