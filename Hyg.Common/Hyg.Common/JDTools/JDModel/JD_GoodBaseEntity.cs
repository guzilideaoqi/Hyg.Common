/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : JD_GoodBaseEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-26 10:32:48 
备注说明 : 京东商品公用类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDModel
{
    /// <summary>
    /// JD_GoodBaseEntity
    /// </summary>
    public class JD_GoodBaseEntity
    {
        public CategoryInfo categoryInfo { get; set; }
        /// <summary>
        /// 评论数量
        /// </summary>
        public long comments { get; set; }
        /// <summary>
        /// 佣金信息
        /// </summary>
        public CommissionInfo commissionInfo { get; set; }
        /// <summary>
        /// 优惠券信息
        /// </summary>
        public CouponInfo couponInfo { get; set; }
        /// <summary>
        /// 商品好评率
        /// </summary>
        public double goodCommentsShare { get; set; }
        /// <summary>
        /// 图片信息
        /// </summary>
        public ImageInfo imageInfo { get; set; }
        /// <summary>
        /// 30天引单数量
        /// </summary>
        public long inOrderCount30Days { get; set; }
        /// <summary>
        /// 价格信息
        /// </summary>
        public PriceInfo priceInfo { get; set; }
        /// <summary>
        /// 店铺信息
        /// </summary>
        public ShopInfo shopInfo { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        public string skuId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string skuName { get; set; }
        /// <summary>
        /// 是否爆款，1：是，0：否
        /// </summary>
        public int isHot { get; set; }
        /// <summary>
        /// spuid，其值为同款商品的主skuid
        /// </summary>
        public long spuid { get; set; }
        /// <summary>
        /// 品牌code
        /// </summary>
        public string brandCode { get; set; }
        /// <summary>
        /// 品牌名
        /// </summary>
        public string brandName { get; set; }
        /// <summary>
        /// g=自营，p=pop
        /// </summary>
        public string owner { get; set; }
        /// <summary>
        /// 拼购信息
        /// </summary>
        public PinGouInfo pinGouInfo { get; set; }
    }

    public class CategoryInfo
    {
        public long cid1 { get; set; }
        public string cid1Name { get; set; }
        public long cid2 { get; set; }
        public string cid2Name { get; set; }
        public long cid3 { get; set; }
        public string cid3Name { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string shopName { get; set; }
        /// <summary>
        /// 店铺id
        /// </summary>
        public string shopId { get; set; }
    }

    public class CommissionInfo
    {
        /// <summary>
        /// 佣金信息
        /// </summary>
        public double commission { get; set; }
        /// <summary>
        /// 佣金比例
        /// </summary>
        public double commissionShare { get; set; }
        /// <summary>
        /// 券后佣金
        /// </summary>
        public double couponCommission { get; set; }
    }


    public class ImageInfo
    {
        public UrlInfo[] imageList { get; set; }
    }

    public class CouponInfo
    {
        public Coupon[] couponList { get; set; }
    }

    public class Coupon
    {
        public int bindType { get; set; }
        public double discount { get; set; }
        public string link { get; set; }
        public int platformType { get; set; }
        public double quota { get; set; }
        public long getStartTime { get; set; }
        public long getEndTime { get; set; }
        public long useStartTime { get; set; }
        public long useEndTime { get; set; }
    }

    public class PinGouInfo
    {
        /// <summary>
        /// 拼购价格
        /// </summary>
        public double pingouPrice { get; set; }
        /// <summary>
        /// 拼购成团所需人数
        /// </summary>
        public long pingouTmCount { get; set; }
        /// <summary>
        /// 拼购落地页url
        /// </summary>
        public string pingouUrl { get; set; }
    }

    public class ShopInfo
    {
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string shopName { get; set; }
        /// <summary>
        /// 店铺id
        /// </summary>
        public string shopId { get; set; }
    }

    public class PriceInfo
    {
        /// <summary>
        /// 无线价格
        /// </summary>
        public double price { get; set; }
        /// <summary>
        /// 最低价后的优惠券价
        /// </summary>
        public double lowestCouponPrice { get; set; }
        /// <summary>
        /// 最低价格
        /// </summary>
        public double lowestPrice { get; set; }
        /// <summary>
        /// 最低价格类型，1：无线价格；2：拼购价格； 3：秒杀价格
        /// </summary>
        public double lowestPriceType { get; set; }
    }

    public class UrlInfo
    {
        public string url { get; set; }
    }
}
