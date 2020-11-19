/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : HaoDanKu_GoodBaseEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-23 9:39:41 
备注说明 : 好单库商品基类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.HaoDanKu.HaoDanKuModel
{
    /// <summary>
    /// 好单库商品基类
    /// </summary>
    public class HaoDanKu_GoodBaseEntity
    {
        /// <summary>
        /// 自增ID
        /// </summary>
        public string product_id { get; set; }

        /// <summary>
        /// 宝贝ID
        /// </summary>
        public string itemid { get; set; }

        /// <summary>
        /// 宝贝标题
        /// </summary>
        public string itemtitle { get; set; }

        /// <summary>
        /// 宝贝短标题
        /// </summary>
        public string itemshorttitle { get; set; }

        /// <summary>
        /// 宝贝推荐语
        /// </summary>
        public string itemdesc { get; set; }

        /// <summary>
        /// 宝贝在售价
        /// </summary>
        public decimal itemprice { get; set; }

        /// <summary>
        /// 宝贝月销量
        /// </summary>
        public int itemsale { get; set; }

        /// <summary>
        /// 宝贝近两个小时跑单
        /// </summary>
        public int itemsale2 { get; set; }

        /// <summary>
        /// 今日销量
        /// </summary>
        public int todaysale { get; set; }

        /// <summary>
        /// 宝贝主图原始图像（由于图片原图过大影响加载速度，建议加上后缀_310x310.jpg)
        /// </summary>
        public string itempic { get; set; }

        /// <summary>
        /// 推广长图（带http://img-haodanku-com.cdn.fudaiapp.com/0_553757100845_1509175123.jpg-600进行访问）
        /// </summary>
        public string itempic_copy { get; set; }

        /// <summary>
        /// 轮播主图，用英文逗号分隔开来（由于图片原图过大影响加载速度，建议加上后缀_310x310.jpg)
        /// </summary>
        public string taobao_image { get; set; }

        /// <summary>
        /// 商品类目：1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物
        /// </summary>
        public int fqcat { get; set; }

        /// <summary>
        /// 宝贝券后价
        /// </summary>
        public decimal itemendprice { get; set; }

        /// <summary>
        /// 店铺类型：天猫店（B）淘宝店（C）
        /// </summary>
        public string shoptype { get; set; }

        /// <summary>
        /// 优惠券链接
        /// </summary>
        public string couponurl { get; set; }

        /// <summary>
        /// 优惠券金额
        /// </summary>
        public decimal couponmoney { get; set; }

        /// <summary>
        /// 是否为品牌产品（1是）
        /// </summary>
        public int is_brand { get; set; }

        /// <summary>
        /// 是否为直播商品
        /// </summary>
        public int is_live { get; set; }

        /// <summary>
        /// 推广导购文案
        /// </summary>
        public string guide_article { get; set; }

        /// <summary>
        /// 商品视频ID（id大于0的为有视频单，视频拼接地址http://cloud.video.taobao.com/play/u/1/p/1/e/6/t/1/+videoid+.mp4）
        /// </summary>
        public string videoid { get; set; }

        /// <summary>
        /// 活动类型：普通活动 聚划算 淘抢购
        /// </summary>
        public string activity_type { get; set; }

        /// <summary>
        /// 营销计划链接
        /// </summary>
        public string planlink { get; set; }

        /// <summary>
        /// 店主的userid
        /// </summary>
        public string userid { get; set; }

        /// <summary>
        /// 店铺掌柜名
        /// </summary>
        public string sellernick { get; set; }

        /// <summary>
        /// 店铺名
        /// </summary>
        public string shopname { get; set; }

        /// <summary>
        /// 佣金计划：隐藏 营销
        /// </summary>
        public string tktype { get; set; }

        /// <summary>
        /// 佣金比例
        /// </summary>
        public string tkrates { get; set; }

        /// <summary>
        /// 预计可得（宝贝价格 * 佣金比例 / 100）
        /// </summary>
        public decimal tkmoney { get; set; }

        /// <summary>
        /// 当天优惠券领取量
        /// </summary>
        public int couponreceive2 { get; set; }

        /// <summary>
        /// 优惠券剩余量
        /// </summary>
        public int couponsurplus { get; set; }

        /// <summary>
        /// 优惠券总数量
        /// </summary>
        public int couponnum { get; set; }

        /// <summary>
        /// 优惠券使用条件
        /// </summary>
        public string couponexplain { get; set; }

        /// <summary>
        /// 优惠券开始时间
        /// </summary>
        public long couponstarttime { get; set; }

        /// <summary>
        /// 优惠券结束时间
        /// </summary>
        public long couponendtime { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        public long start_time { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        public long end_time { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public long starttime { get; set; }

        /// <summary>
        /// 举报处理条件 0未举报 1为待处理 2为忽略 3为下架
        /// </summary>
        public int report_status { get; set; }

        /// <summary>
        /// 好单指数
        /// </summary>
        public int general_index { get; set; }

        /// <summary>
        /// 放单人名号
        /// </summary>
        public string seller_name { get; set; }

        /// <summary>
        /// 折扣力度
        /// </summary>
        public decimal discount { get; set; }

        /// <summary>
        /// 双十一定金
        /// </summary>
        public decimal deposit { get; set; }

        /// <summary>
        /// 双十一定金抵扣金额
        /// </summary>
        public decimal deposit_deduct { get; set; }
    }
}
