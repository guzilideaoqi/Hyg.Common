/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Order_BaseEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-22 11:08:44 
备注说明 : 拼多多订单基类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{
    /// <summary>
    /// 拼多多订单基类
    /// </summary>
    public class Order_BaseEntity
    {
        /// <summary>
        /// 多多客工具id
        /// </summary>
        public long auth_duo_id { get; set; }

        /// <summary>
        /// 结算批次号
        /// </summary>
        public string batch_no { get; set; }

        /// <summary>
        /// 是否是 cpa 新用户，1表示是，0表示否
        /// </summary>
        public int cpa_new { get; set; }

        /// <summary>
        /// 自定义参数
        /// </summary>
        public string custom_parameters { get; set; }

        /// <summary>
        /// 订单审核失败原因
        /// </summary>
        public string fail_reason { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public long goods_id { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        public string goods_name { get; set; }

        private decimal _goods_price;
        /// <summary>
        /// 商品价格
        /// </summary>
        public decimal goods_price { get { return decimal.Parse((_goods_price/100).ToString("#0.00")); } set { _goods_price = value; } }

        /// <summary>
        /// 购买商品的数量
        /// </summary>
        public int goods_quantity { get; set; }

        /// <summary>
        /// 商品缩略图
        /// </summary>
        public string goods_thumbnail_url { get; set; }

        /// <summary>
        /// 成团编号
        /// </summary>
        public long group_id { get; set; }

        private decimal _order_amount;
        /// <summary>
        /// 实际支付金额，单位为分
        /// </summary>
        public decimal order_amount { get { return decimal.Parse((_order_amount / 100).ToString("#0.00")); } set { _order_amount = value; } }

        /// <summary>
        /// 订单生成时间，UNIX时间戳
        /// </summary>
        public long order_create_time { get; set; }

        /// <summary>
        /// 成团时间
        /// </summary>
        public long order_group_success_time { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        public string order_id { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public long order_modify_at { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        public long order_pay_time { get; set; }

        /// <summary>
        /// 确认收货时间
        /// </summary>
        public long order_receive_time { get; set; }

        /// <summary>
        /// 结算时间
        /// </summary>
        public long order_settle_time { get; set; }

        /// <summary>
        /// 推广订单编号
        /// </summary>
        public string order_sn { get; set; }

        /// <summary>
        /// 订单状态： -1 未支付; 0-已支付；1-已成团；2-确认收货；3-审核成功；4-审核失败（不可提现）；5-已经结算；8-非多多进宝商品（无佣金订单）;10-已处罚
        /// </summary>
        public int order_status { get; set; }

        /// <summary>
        /// 订单状态描述
        /// </summary>
        public string order_status_desc { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        public long order_verify_time { get; set; }

        private decimal _promotion_amount;
        /// <summary>
        /// 佣金金额，单位为分
        /// </summary>
        public decimal promotion_amount { get { return decimal.Parse((_promotion_amount / 100).ToString("#0.00")); } set { _promotion_amount = value; } }

        private decimal _promotion_rate;
        /// <summary>
        /// 佣金比例，千分比
        /// </summary>
        public decimal promotion_rate { get { return decimal.Parse((_promotion_rate / 10).ToString("#0.00")); } set { _promotion_rate = value; } }

        /// <summary>
        /// 推广位ID
        /// </summary>
        public string p_id { get; set; }

        /// <summary>
        /// 订单推广类型
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 招商多多客id
        /// </summary>
        public long zs_duo_id { get; set; }

        /// <summary>
        /// 商品一~四级类目ID列表
        /// </summary>
        public long[] cat_ids { get; set; }

        /// <summary>
        /// 是否直推 ，1表示是，0表示否
        /// </summary>
        public int is_direct { get; set; }

        /// <summary>
        /// 直播间订单推广duoId
        /// </summary>
        public long sep_duo_id { get; set; }

        /// <summary>
        /// 直播间推广佣金
        /// </summary>
        public int sep_market_fee { get; set; }

        /// <summary>
        /// 直播间订单推广位
        /// </summary>
        public string sep_pid { get; set; }

        /// <summary>
        /// 直播间推广佣金比例
        /// </summary>
        public int sep_rate { get; set; }

        /// <summary>
        /// 直播间推广自定义参数
        /// </summary>
        public string sep_parameters { get; set; }
    }
}
