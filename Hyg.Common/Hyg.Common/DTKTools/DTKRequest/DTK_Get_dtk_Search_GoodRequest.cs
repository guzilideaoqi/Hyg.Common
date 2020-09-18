/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Get_dtk_Search_GoodRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:13:23 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// 大淘客搜索
    /// </summary>
    public class DTK_Get_dtk_Search_GoodRequest
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v2.1.2";
        /// <summary>
        /// 默认为1，支持传统的页码分页方式和scroll_id分页方式，后续传入接口第一次返回的pageid，
        /// </summary>
        public string pageId { get; set; }
        /// <summary>
        /// 每页显示数量
        /// </summary>
        public int pageSize { get; set; }
        /// <summary>
        /// 搜索关键词
        /// </summary>
        public string keyWords { get; set; }
        /// <summary>
        /// 一级类目id
        /// </summary>
        public string cids { get; set; }
        /// <summary>
        /// 二级类目id
        /// </summary>
        public int? subcid { get; set; }
        /// <summary>
        ///是否聚划算 1-聚划算商品，0-非聚划算商品，不填默认为所有商品
        /// </summary>
        public int? juHuaSuan { get; set; }
        /// <summary>
        ///是否淘抢购 1-淘抢购商品，0-非淘抢购商品，不填默认为所有商品
        /// </summary>
        public int? taoQiangGou { get; set; }
        /// <summary>
        ///是否天猫商品 1-天猫商品，0-非天猫商品，不填默认为所有商品
        /// </summary>
        public int? tmall { get; set; }
        /// <summary>
        ///是否天猫超市商品 1-天猫超市商品，0-非天猫超市商品，不填默认为所有商品
        /// </summary>
        public int? tchaoshi { get; set; }
        /// <summary>
        ///是否金牌卖家 1-金牌卖家，0-非金牌卖家，不填默认为所有店铺
        /// </summary>
        public int? goldSeller { get; set; }
        /// <summary>
        ///是否海淘商品 1-海淘商品，0-非海淘商品，不填默认为所有商品
        /// </summary>
        public int? haitao { get; set; }
        /// <summary>
        ///是否品牌商品 1-品牌商品，0-非品牌商品，不填默认为所有商品
        /// </summary>
        public int? brand { get; set; }
        /// <summary>
        /// 当brand传入0时，再传入brandIds将获取不到结果。品牌id可以传多个，以英文逗号隔开，如：”345,321,323”
        /// </summary>
        public string brandIds { get; set; }
        /// <summary>
        /// 价格（券后价）下限
        /// </summary>
        public decimal? priceLowerLimit { get; set; }
        /// <summary>
        /// 价格（券后价）上限
        /// </summary>
        public decimal? priceUpperLimit { get; set; }
        /// <summary>
        /// 最低优惠券面额
        /// </summary>
        public int? couponPriceLowerLimit { get; set; }
        /// <summary>
        /// 最低佣金比例
        /// </summary>
        public decimal? commissionRateLowerLimit { get; set; }
        /// <summary>
        /// 最低月销量
        /// </summary>
        public int? monthSalesLowerLimit { get; set; }
        /// <summary>
        /// 默认为0，0-综合排序，1-商品上架时间从新到旧，2-销量从高到低，3-领券量从高到低，4-佣金比例从高到低，5-价格（券后价）从高到低，6-价格（券后价）从低到高
        /// </summary>
        public string sort { get; set; }
        public int? freeshipRemoteDistrict { get; set; }
    }
}
