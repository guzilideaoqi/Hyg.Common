/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : GoodInfoBase.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:37:48 
备注说明 : 商品信息基类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// 商品信息基类
    /// </summary>
    public class GoodInfoBase
    {
        /// <summary>
        /// 商品id
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// 淘宝商品id
        /// </summary>
        public string goodsId { get; set; }
        /// <summary>
        /// 淘宝标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 短标题
        /// </summary>
        public string dtitle { get; set; }
        /// <summary>
        /// 商品原价
        /// </summary>
        public decimal originalPrice { get; set; }
        /// <summary>
        /// 券后价
        /// </summary>
        public decimal actualPrice { get; set; }
        /// <summary>
        /// 店铺类型，1-天猫，0-淘宝
        /// </summary>
        public int shopType { get; set; }
        /// <summary>
        /// 是否金牌卖家，1-金牌卖家，0-非金牌卖家
        /// </summary>
        public int goldSellers { get; set; }
        /// <summary>
        /// 30天销量
        /// </summary>
        public int monthSales { get; set; }
        /// <summary>
        /// 2小时销量
        /// </summary>
        public int twoHoursSales { get; set; }
        /// <summary>
        /// 当天销量
        /// </summary>
        public int dailySales { get; set; }
        /// <summary>
        /// 佣金类型，0-通用，1-定向，2-高佣，3-营销计划
        /// </summary>
        public int commissionType { get; set; }
        /// <summary>
        /// 推广文案
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// 领券量
        /// </summary>
        public int couponReceiveNum { get; set; }
        /// <summary>
        /// 优惠券链接
        /// </summary>
        public string couponLink { get; set; }
        /// <summary>
        /// 优惠券结束时间
        /// </summary>
        public string couponEndTime { get; set; }
        /// <summary>
        /// 优惠券开始时间
        /// </summary>
        public string couponStartTime { get; set; }
        /// <summary>
        /// 优惠券金额
        /// </summary>
        public decimal couponPrice { get; set; }
        /// <summary>
        /// 优惠券使用条件
        /// </summary>
        public string couponConditions { get; set; }
        /// <summary>
        /// 活动类型，1-无活动，2-淘抢购，3-聚划算
        /// </summary>
        public int activityType { get; set; }
        /// <summary>
        /// 商品上架时间
        /// </summary>
        public string createTime { get; set; }
        /// <summary>
        /// 商品主图链接
        /// </summary>
        public string mainPic { get; set; }
        /// <summary>
        /// 营销主图链接
        /// </summary>
        public string marketingMainPic { get; set; }
        /// <summary>
        /// 淘宝卖家id
        /// </summary>
        public string sellerId { get; set; }
        /// <summary>
        /// 商品在大淘客的分类id
        /// </summary>
        public int cid { get; set; }
        /// <summary>
        /// 商品在大淘客的二级分类id，该分类为前端分类，一个商品可能有多个二级分类id
        /// </summary>
        public List<long> subcid { get; set; }
        /// <summary>
        /// 商品在淘宝的分类id
        /// </summary>
        public long tbcid { get; set; }
        /// <summary>
        /// 折扣力度
        /// </summary>
        public decimal discounts { get; set; }
        /// <summary>
        /// 佣金比例
        /// </summary>
        public decimal commissionRate { get; set; }
        /// <summary>
        /// 券总量
        /// </summary>
        public int couponTotalNum { get; set; }

        /// <summary>
        /// 是否海淘,1-海淘商品，0-非海淘商品
        /// </summary>
        public int haitao { get; set; }
        /// <summary>
        /// 活动开始时间
        /// </summary>
        public string activityStartTime { get; set; }
        /// <summary>
        /// 活动结束时间
        /// </summary>
        public string activityEndTime { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string shopName { get; set; }
        /// <summary>
        /// 淘宝店铺等级	
        /// </summary>
        public int? shopLevel { get; set; }
        /// <summary>
        /// 描述分
        /// </summary>
        public decimal? descScore { get; set; }
        /// <summary>
        /// 描述相符
        /// </summary>
        public decimal dsrScore { get; set; }
        /// <summary>
        /// 描述同行比
        /// </summary>
        public decimal dsrPercent { get; set; }
        /// <summary>
        /// 服务态度
        /// </summary>
        public decimal shipScore { get; set; }
        /// <summary>
        /// 服务同行比
        /// </summary>
        public decimal shipPercent { get; set; }
        /// <summary>
        /// 物流服务
        /// </summary>
        public decimal serviceScore { get; set; }
        /// <summary>
        /// 物流同行比
        /// </summary>
        public decimal servicePercent { get; set; }
        /// <summary>
        /// 是否是品牌商品
        /// </summary>
        public int brand { get; set; }
        /// <summary>
        /// 品牌id
        /// </summary>
        public long brandId { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
        public string brandName { get; set; }
        /// <summary>
        /// 热推值
        /// </summary>
        public int hotPush { get; set; }
        /// <summary>
        /// 放单人名称
        /// </summary>
        public string teamName { get; set; }
        /// <summary>
        /// 商品淘宝链接
        /// </summary>
        public string itemLink { get; set; }
        /// <summary>
        /// 是否天猫超市商品，1-天猫超市商品，0-非天猫超市商品
        /// </summary>
        public int tchaoshi { get; set; }
        /// <summary>
        /// 定金，若无定金，则显示0
        /// </summary>
        public decimal quanMLink { get; set; }
        /// <summary>
        /// 立减，若无立减金额，则显示0
        /// </summary>
        public decimal hzQuanOver { get; set; }
        /// <summary>
        /// 0.不包运费险 1.包运费险
        /// </summary>
        public int yunfeixian { get; set; }
        /// <summary>
        /// 预估淘礼金
        /// </summary>
        public decimal estimateAmount { get; set; }
        /// <summary>
        /// 店铺logo
        /// </summary>
        public string shopLogo { get; set; }

        /// <summary>
        /// 等级佣金(根据当前用户的等级展示)
        /// </summary>
        public decimal LevelCommission { get; set; }
        /// <summary>
        /// 高级佣金(预计最高可得到的佣金)
        /// </summary>
        public decimal SuperCommission { get; set; }
    }
}
