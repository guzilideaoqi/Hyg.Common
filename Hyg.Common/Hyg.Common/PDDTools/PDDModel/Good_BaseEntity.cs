/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Good_BaseEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-22 18:01:58 
备注说明 : 商品信息基类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{
    /// <summary>
    /// 商品信息基类
    /// </summary>
    public class Good_BaseEntity
    {
        /// <summary>
        /// 商品活动标记数组，例：[4,7]，4-秒杀，7-百亿补贴，24-品牌高佣，20-行业精选，21-金牌商家，10044-潜力爆品，其他的值请忽略
        /// </summary>
        public int[] activity_tags { get; set; }

        /// <summary>
        /// 活动类型，0-无活动;1-秒杀;3-限量折扣;12-限时折扣;13-大促活动;14-名品折扣;15-品牌清仓;16-食品超市;17-一元幸运团;18-爱逛街;19-时尚穿搭;20-男人帮;21-9块9;22-竞价活动;23-榜单活动;24-幸运半价购;25-定金预售;26-幸运人气购;27-特色主题活动;28-断码清仓;29-一元话费;30-电器城;31-每日好店;32-品牌卡;101-大促搜索池;102-大促品类分会场;
        /// </summary>
        public int activity_type { get; set; }

        /// <summary>
        /// 商品类目ID，使用pdd.goods.cats.get接口获取
        /// </summary>
        public long category_id { get; set; }

        /// <summary>
        /// 商品类目名
        /// </summary>
        public string category_name { get; set; }

        /// <summary>
        /// 商品类目id
        /// </summary>
        public long[] cat_ids { get; set; }

        /// <summary>
        /// 店铺收藏券id
        /// </summary>
        public string clt_cpn_batch_sn { get; set; }

        /// <summary>
        /// 店铺收藏券面额,单位为分
        /// </summary>
        private decimal _clt_cpn_discount;
        public decimal clt_cpn_discount { get { return decimal.Parse((_clt_cpn_discount / 100).ToString("#0.00")); } set { _clt_cpn_discount = value; } }

        /// <summary>
        /// 店铺收藏券截止时间
        /// </summary>
        public long clt_cpn_end_time { get; set; }

        private decimal _clt_cpn_min_amt;
        /// <summary>
        /// 店铺收藏券使用门槛价格,单位为分
        /// </summary>
        public decimal clt_cpn_min_amt { get { return decimal.Parse((_clt_cpn_min_amt / 100).ToString("#0.00")); } set { _clt_cpn_min_amt = value; } }

        /// <summary>
        /// 店铺收藏券总量
        /// </summary>
        public long clt_cpn_quantity { get; set; }

        /// <summary>
        /// 店铺收藏券剩余量
        /// </summary>
        public long clt_cpn_remain_quantity { get; set; }

        /// <summary>
        /// 店铺收藏券开始时间
        /// </summary>
        public long clt_cpn_start_time { get; set; }

        /// <summary>
        /// 优惠券面额，单位为分
        /// </summary>
        private decimal _coupon_discount;
        public decimal coupon_discount { get { return decimal.Parse((_coupon_discount / 100).ToString("#0.00")); } set { _coupon_discount = value; } }

        /// <summary>
        /// 优惠券失效时间，UNIX时间戳
        /// </summary>
        public long coupon_end_time { get; set; }

        /// <summary>
        /// 优惠券门槛价格，单位为分
        /// </summary>
        private decimal _coupon_min_order_amount;
        public decimal coupon_min_order_amount { get { return decimal.Parse((_coupon_min_order_amount / 100).ToString("#0.00")); } set { _coupon_min_order_amount = value; } }

        /// <summary>
        /// 优惠券剩余数量
        /// </summary>
        public long coupon_remain_quantity { get; set; }

        /// <summary>
        /// 优惠券生效时间，UNIX时间戳
        /// </summary>
        public long coupon_start_time { get; set; }

        /// <summary>
        /// 优惠券总数
        /// </summary>
        public long coupon_total_quantity { get; set; }

        /// <summary>
        /// 创建时间（unix时间戳）
        /// </summary>
        public long create_at { get; set; }

        /// <summary>
        /// 描述分
        /// </summary>
        public string desc_txt { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        public string goods_desc { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        public long goods_id { get; set; }

        /// <summary>
        /// 商品主图
        /// </summary>
        public string goods_image_url { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string goods_name { get; set; }

        /// <summary>
        /// 商品缩略图
        /// </summary>
        public string goods_thumbnail_url { get; set; }

        /// <summary>
        /// 商品是否有优惠券 true-有，false-没有
        /// </summary>
        public bool has_coupon { get; set; }

        /// <summary>
        /// 是否有店铺券
        /// </summary>
        public bool has_mall_coupon { get; set; }

        /// <summary>
        /// 物流分
        /// </summary>
        public string lgst_txt { get; set; }

        /// <summary>
        /// 店铺券折扣
        /// </summary>
        public int mall_coupon_discount_pct { get; set; }

        /// <summary>
        /// 店铺券结束使用时间
        /// </summary>
        public long mall_coupon_end_time { get; set; }

        /// <summary>
        /// 店铺券id
        /// </summary>
        public long mall_coupon_id { get; set; }

        /// <summary>
        /// 最大使用金额
        /// </summary>
        public int mall_coupon_max_discount_amount { get; set; }

        /// <summary>
        /// 最小使用金额
        /// </summary>
        public int mall_coupon_min_order_amount { get; set; }

        /// <summary>
        /// 店铺券余量
        /// </summary>
        public long mall_coupon_remain_quantity { get; set; }

        /// <summary>
        /// 店铺券开始使用时间
        /// </summary>
        public long mall_coupon_start_time { get; set; }

        /// <summary>
        /// 店铺券总量
        /// </summary>
        public long mall_coupon_total_quantity { get; set; }

        /// <summary>
        /// 该商品所在店铺是否参与全店推广，0：否，1：是
        /// </summary>
        public int mall_cps { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        public long mall_id { get; set; }

        /// <summary>
        /// 店铺名字
        /// </summary>
        public string mall_name { get; set; }

        /// <summary>
        /// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店
        /// </summary>
        public int merchant_type { get; set; }

        /// <summary>
        /// 最小拼团价（单位为分）
        /// </summary>
        private decimal _min_group_price;
        public decimal min_group_price { get { return decimal.Parse((_min_group_price / 100).ToString("#0.00")); } set { _min_group_price = value; } }

        /// <summary>
        /// 最小单买价格（单位为分）
        /// </summary>
        private decimal _min_normal_price;
        public decimal min_normal_price { get { return decimal.Parse((_min_normal_price / 100).ToString("#0.00")); } set { _min_normal_price = value; } }

        /// <summary>
        /// 快手专享
        /// </summary>
        public bool only_scene_auth { get; set; }

        /// <summary>
        /// 商品标签ID，使用pdd.goods.opts.get接口获取
        /// </summary>
        public long opt_id { get; set; }

        /// <summary>
        /// 商品标签id
        /// </summary>
        public long[] opt_ids { get; set; }

        /// <summary>
        /// 商品标签名
        /// </summary>
        public string opt_name { get; set; }

        /// <summary>
        /// 推广计划类型 3:定向 4:招商
        /// </summary>
        public int plan_type { get; set; }

        private decimal _promotion_rate;
        public decimal promotion_rate { get { return decimal.Parse((_promotion_rate / 10).ToString("#0.00")); } set { _promotion_rate = value; } }

        /// <summary>
        /// 已售卖件数
        /// </summary>
        public string sales_tip { get; set; }

        /// <summary>
        /// 搜索id，建议生成推广链接时候填写，提高收益
        /// </summary>
        public string search_id { get; set; }

        /// <summary>
        /// 服务标签: 4-送货入户并安装,5-送货入户,6-电子发票,9-坏果包赔,11-闪电退款,12-24小时发货,13-48小时发货,17-顺丰包邮,18-只换不修,19-全国联保,20-分期付款,24-极速退款,25-品质保障,26-缺重包退,27-当日发货,28-可定制化,29-预约配送,1000001-正品发票,1000002-送货入户并安装
        /// </summary>
        public long[] service_tags { get; set; }

        /// <summary>
        /// 服务分
        /// </summary>
        public string serv_txt { get; set; }

        /// <summary>
        /// 招商团长id
        /// </summary>
        public long zs_duo_id { get; set; }

        /// <summary>
        /// 比价行为预判定佣金，需要用户备案
        /// </summary>
        private decimal _predict_promotion_rate;
        public decimal predict_promotion_rate { get { return decimal.Parse((_predict_promotion_rate / 10).ToString("#0.00")); } set { _predict_promotion_rate = value; } }

        public string goods_sign { get; set; }
    }
}
