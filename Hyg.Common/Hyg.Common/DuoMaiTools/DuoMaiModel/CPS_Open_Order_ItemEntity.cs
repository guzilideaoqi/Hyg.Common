/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : CPS_Open_Order_ItemEntity.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-19 17:36:27 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DuoMaiTools.DuoMaiModel
{
    /// <summary>
    /// 订单数据
    /// </summary>
    public class CPS_Open_Order_ItemEntity
    {
        /// <summary>
        /// 订单id
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 计划ID
        /// </summary>
        public string ads_id { get; set; }

        /// <summary>
        /// 推广位id
        /// </summary>
        public string site_id { get; set; }

        /// <summary>
        /// 推广计划链接ID
        /// </summary>
        public string link_id { get; set; }

        /// <summary>
        /// 反馈标签
        /// </summary>
        public string euid { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        public string order_sn { get; set; }

        /// <summary>
        /// 针对部分联盟存在父订单号，如阿里妈妈，此字段自2020-06-16开始有值
        /// </summary>
        public string parent_order_sn { get; set; }
        /// <summary>
        /// 订单下单时间，格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string order_time { get; set; }
        /// <summary>
        /// 订单金额，例：1.00
        /// </summary>
        public decimal orders_price { get; set; }
        /// <summary>
        /// 	订单佣金，例：1.00
        /// </summary>
        public decimal siter_commission { get; set; }
        /// <summary>
        /// 多麦联盟结算状态：-1 无效 0 未确认 1 确认 2 结算
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 确认订单金额，1.00
        /// </summary>
        public decimal confirm_price { get; set; }
        /// <summary>
        /// 确认订单佣金，1.00
        /// </summary>
        public decimal confirm_siter_commission { get; set; }
        /// <summary>
        /// 结算时间，格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string charge_time { get; set; }
        /// <summary>
        /// 	订单详情
        /// </summary>
        public List<CPS_Open_Order_Goods_ItemEntity> details { get; set; }
    }
}
