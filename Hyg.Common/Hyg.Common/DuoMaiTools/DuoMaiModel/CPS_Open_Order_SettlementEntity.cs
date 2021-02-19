/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : CPS_Open_Order_SettlementEntity.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-19 17:04:35 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DuoMaiTools.DuoMaiModel
{
    /// <summary>
    /// 订单结算变更状态
    /// </summary>
    public class CPS_Open_Order_SettlementEntity
    {
        /// <summary>
        /// 订单id
        /// </summary>
        public string order_sn { get; set; }

        /// <summary>
        /// 订单下单时间
        /// </summary>
        public string order_time { get; set; }

        /// <summary>
        /// 反馈标签
        /// </summary>
        public string euid { get; set; }

        /// <summary>
        /// 历史金额，例：1.0000
        /// </summary>
        public decimal? confirm_price_old { get; set; }

        /// <summary>
        /// 变动金额，例：1.0000
        /// </summary>
        public decimal? modify_price { get; set; }

        /// <summary>
        /// 当前金额，例：1.0000
        /// </summary>
        public decimal? confirm_price { get; set; }

        /// <summary>
        /// 历史佣金，例：1.0000
        /// </summary>
        public decimal? confirm_siter_commission_old { get; set; }

        /// <summary>
        /// 变动佣金，例：1.0000
        /// </summary>
        public decimal? modify_siter_commission { get; set; }

        /// <summary>
        /// 当前佣金，例：1.0000
        /// </summary>
        public decimal? confirm_siter_commission { get; set; }

        /// <summary>
        /// 变动时间，格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string modify_at { get; set; }

        /// <summary>
        /// 计划id
        /// </summary>
        public string ads_id { get; set; }

        /// <summary>
        /// 计划名称	
        /// </summary>
        public string ads_name { get; set; }
    }
}
