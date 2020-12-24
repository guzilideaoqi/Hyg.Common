/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : JTT_CommonGoodsInfo.cs
创建人员 : Mr.Hu
创建时间 : 2020-12-24 14:45:15 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JTT_Tools.JTTModel
{
    /// <summary>
    /// 京推推商品信息
    /// </summary>
    public class JTT_CommonGoodsInfo
    {
        /// <summary>
        /// 京推推商品ID
        /// </summary>
        public string JID { get; set; }

        /// <summary>
        /// 京推推商品状态(注:1被修改；2正常；3已下架；4已下架（除状态2返回所有信息，其他状态将只返回京推推商品ID、京东商品ID以及商品状态)
        /// </summary>
        public int J_state { get; set; }

        /// <summary>
        /// 商品SKU
        /// </summary>
        public string goods_id { get; set; }

        /// <summary>
        /// 京东商品原标题
        /// </summary>
        public string goods_name { get; set; }

        /// <summary>
        /// 商品图片
        /// </summary>
        public string goods_img { get; set; }

        /// <summary>
        /// 商品原价
        /// </summary>
        public decimal goods_price { get; set; }

        /// <summary>
        /// 京推推商品描述文案
        /// </summary>
        public string goods_content { get; set; }

        /// <summary>
        /// 京东商品链接
        /// </summary>
        public string goods_link { get; set; }

        /// <summary>
        /// 优惠券面额
        /// </summary>
        public decimal discount_price { get; set; }

        /// <summary>
        /// 领券链接
        /// </summary>
        public string discount_link { get; set; }
        /// <summary>
        /// 优惠券开始时间
        /// </summary>
        public string discount_start { get; set; }
        /// <summary>
        /// 优惠券结束时间
        /// </summary>
        public string discount_end { get; set; }
        /// <summary>
        /// 券后价
        /// </summary>
        public decimal coupon_price { get; set; }
        /// <summary>
        /// 京推推商品一级类目
        /// </summary>
        public int goods_type { get; set; }
        /// <summary>
        /// 商品佣金比例（具体佣金可根据平台分佣体系进行计算显示）
        /// </summary>
        public decimal commission { get; set; }
        /// <summary>
        /// 商品今日领券总量，券类型为商品券
        /// </summary>
        public string today_num { get; set; }
        /// <summary>
        /// 京推推商品类型（5=普通产品；10=优选产品；20=精选好货；30=主推(坑位等)；40=爆款）
        /// </summary>
        public int goods_level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string shop_type { get; set; }
        /// <summary>
        /// 京东商品类型（1=POP；2=self自营；3=拼购）
        /// </summary>
        public int jd_type { get; set; }
        /// <summary>
        /// 京推推品牌id,可用于品牌API商品筛选
        /// </summary>
        public string brand_id { get; set; }
        /// <summary>
        /// 店铺id
        /// </summary>
        public string shopid { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string shop_name { get; set; }
        /// <summary>
        /// 京东商品近30天销量
        /// </summary>
        public string inOrderCount30Days { get; set; }
        /// <summary>
        /// 店铺评分（afterServiceScore售后服务评分；logisticsLvyueScore物流履约评分； ;scoreRankRateGrade店铺星级；userEvaluateScore商品评价评分)
        /// </summary>
        public string score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string evaluate { get; set; }
        /// <summary>
        /// 精编社群推广文案
        /// </summary>
        public string link_content { get; set; }
        /// <summary>
        /// 京东图片合集（第一张图为京东商品主图）
        /// </summary>
        public string img_list { get; set; }
        /// <summary>
        /// 商品主SPU，其值为同款商品的主skuid
        /// </summary>
        public string spu_id { get; set; }
        public string cid1 { get; set; }
        public string cid2 { get; set; }
        public string cid3 { get; set; }
        public string cid1Name { get; set; }
        public string cid2Name { get; set; }
        public string cid3Name { get; set; }
        public string jd_imageList { get; set; }
        /// <summary>
        /// 是否爆款（1=是；0=否）
        /// </summary>
        public int isHot { get; set; }
        /// <summary>
        /// 京东_品牌code
        /// </summary>
        public string jd_brandCode { get; set; }
        /// <summary>
        /// 京东_品牌名称
        /// </summary>
        public string jd_brandName { get; set; }
        public string jd_title { get; set; }
        public string owner { get; set; }
        /// <summary>
        /// 商品好评率
        /// </summary>
        public string goodCommentsShare { get; set; }
        public decimal? pingouPrice { get; set; }
        public string pingouTmCount { get; set; }
        public string pingouUrl { get; set; }
        public string pingouStartTime { get; set; }
        public string pingouEndTime { get; set; }
        /// <summary>
        /// 京东_视频集合
        /// </summary>
        public string jd_videoList { get; set; }
        /// <summary>
        /// 京东商品图文详情
        /// </summary>
        public string pc_ware_style { get; set; }
    }
}
