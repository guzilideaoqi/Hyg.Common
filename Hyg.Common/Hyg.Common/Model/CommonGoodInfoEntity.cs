/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : CommonGoodInfoEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-11-02 9:27:10 
备注说明 : 公用的商品字段信息

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.Model
{
    /// <summary>
    /// 公用的商品字段信息
    /// </summary>
    public class CommonGoodInfoEntity
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public string skuid { get; set; }
        /// <summary>
        /// 商品标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 优惠券金额
        /// </summary>
        public string coupon_price { get; set; }
        /// <summary>
        /// 商品原件
        /// </summary>
        public string origin_price { get; set; }
        /// <summary>
        /// 券后价
        /// </summary>
        public string coupon_after_price { get; set; }
        /// <summary>
        /// 所属平台  1淘宝  3京东  4拼多多
        /// </summary>
        public int PlaformType { get; set; }

        public string image { get; set; }

        public string[] images { get; set; }
        /// <summary>
        /// 优惠券开始时间
        /// </summary>
        public string coupon_start_time { get; set; }
        /// <summary>
        /// 优惠券链接
        /// </summary>
        public string coupon_link { get; set; }
        /// <summary>
        /// 优惠券结束时间
        /// </summary>
        public string coupon_end_time { get; set; }
        /// <summary>
        /// 店铺id
        /// </summary>
        public string shopId { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string shopName { get; set; }
        /// <summary>
        /// 店铺Logo
        /// </summary>
        public string shopLogo { get; set; }
        /// <summary>
        /// 详情图片
        /// </summary>
        public string[] detail_images { get; set; }
        /// <summary>
        /// 月销量
        /// </summary>
        public long month_sales { get; set; }
        /// <summary>
        /// 商品描述
        /// </summary>
        public string remark { get; set; }
        /// <summary>
        /// 服务态度
        /// </summary>
        public string afterServiceScore { get; set; }
        /// <summary>
        /// 描述相符
        /// </summary>
        public string userEvaluateScore { get; set; }
        /// <summary>
        /// 物流服务
        /// </summary>
        public string logisticsLvyueScore { get; set; }

        /// <summary>
        /// 初级佣金金额
        /// </summary>
        public decimal LevelCommission { get; set; }
        /// <summary>
        /// 高级佣金金额
        /// </summary>
        public decimal SuperCommission { get; set; }

        /// <summary>
        /// 总佣金
        /// </summary>
        public double TotalCommission { get; set; }

        /// <summary>
        /// 所属缓存表的key值
        /// </summary>
        public string cacheKey { get; set; }

        /// <summary>
        /// 佣金比例
        /// </summary>
        public decimal CommissionRate { get; set; }
    }
}
