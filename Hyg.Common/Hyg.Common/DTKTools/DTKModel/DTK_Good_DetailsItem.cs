/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Good_DetailsItem.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:49:34 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// DTK_Good_DetailsItem
    /// </summary>
    public class DTK_Good_DetailsItem
    {
        /// <summary>
        /// 大淘客商品ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 淘宝商品ID
        /// </summary>
        public string goodsId { get; set; }

        /// <summary>
        /// 淘宝商品链接
        /// </summary>
        public string itemLink { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 大淘客商品标题
        /// </summary>
        public string dtitle { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// 商品在大淘客的分类id
        /// </summary>
        public string cid { get; set; }
        /// <summary>
        /// 商品在大淘客的二级分类id，该分类为前端分类，一个商品可能有多个二级分类id
        /// </summary>
        public int[] subcid { get; set; }

        public int tbcid { get; set; }

        /// <summary>
        /// 商品主图
        /// </summary>
        public string mainPic { get; set; }

        /// <summary>
        /// 营销主图
        /// </summary>
        public string marketingMainPic { get; set; }

        /// <summary>
        /// 商品原价
        /// </summary>
        public string originalPrice { get; set; }
        /// <summary>
        /// 券后价
        /// </summary>
        public decimal actualPrice { get; set; }
        /// <summary>
        /// 折扣力度
        /// </summary>
        public decimal discounts { get; set; }

        /// <summary>
        /// 佣金类型，0-通用，1-定向，2-高佣，3-营销计划
        /// </summary>
        public int commissionType { get; set; }

        /// <summary>
        /// 佣金比例
        /// </summary>
        public decimal commissionRate { get; set; }

        /// <summary>
        /// 优惠券链接
        /// </summary>
        public string couponLink { get; set; }

        /// <summary>
        /// 优惠券总数
        /// </summary>
        public int couponTotalNum { get; set; }
        /// <summary>
        /// 优惠券领取数量
        /// </summary>
        public int couponReceiveNum { get; set; }
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
        /// 30天销量
        /// </summary>
        public int monthSales { get; set; }
        /// <summary>
        /// 当天销量
        /// </summary>
        public int dailySales { get; set; }
        /// <summary>
        /// 2小时销量
        /// </summary>
        public int twoHoursSales { get; set; }
        /// <summary>
        /// 品牌id
        /// </summary>
        public string brandId { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
        public string brandName { get; set; }
        /// <summary>
        /// 淘宝卖家id
        /// </summary>
        public string sellerId { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string shopName { get; set; }
        /// <summary>
        /// 淘宝店铺等级
        /// </summary>
        public int shopLevel { get; set; }
        /// <summary>
        /// 描述分
        /// </summary>
        public decimal descScore { get; set; }
        /// <summary>
        /// 描述相符
        /// </summary>
        public decimal dsrScore { get; set; }
        /// <summary>
        /// 描述同行比
        /// </summary>
        public decimal dsrPercent { get; set; }
        /// <summary>
        /// 物流服务
        /// </summary>
        public decimal shipScore { get; set; }
        /// <summary>
        /// 物流同行比
        /// </summary>
        public decimal shipPercent { get; set; }
        /// <summary>
        /// 服务态度
        /// </summary>
        public decimal serviceScore { get; set; }
        /// <summary>
        /// 服务同行比
        /// </summary>
        public decimal servicePercent { get; set; }
        /// <summary>
        /// 商品主图（需要做适配
        /// </summary>
        public string detailPics { get; set; }
        /// <summary>
        /// 轮播图
        /// </summary>
        public string imgs { get; set; }
    }
}
