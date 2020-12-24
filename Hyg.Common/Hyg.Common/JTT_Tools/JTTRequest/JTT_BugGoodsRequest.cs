/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : JTT_BugGoodsRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-12-24 16:23:22 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JTT_Tools.JTTRequest
{
    /// <summary>
    /// 京东漏洞单
    /// </summary>
    public class JTT_BugGoodsRequest: JTT_CommonRequest
    {
        /// <summary>
        /// 分页获取数据（默认第1页）
        /// </summary>
        public int pageIndex { get; set; }

        /// <summary>
        /// 单页面显示条数(最大100条最少10条)
        /// </summary>
        public string pageSize { get; set; }

        /// <summary>
        /// 关键词搜索（可以输入关键词、SKU、商品链接、店铺名称）
        /// </summary>
        public string keyword { get; set; }

        /// <summary>
        /// 京推推商品一级类目： 1居家日用；2食品；3生鲜；4图书；5美妆个护；6母婴；7数码家电；8内衣；9配饰；10女装；11男装；12鞋品；13家装家纺；14文娱车品；15箱包；16户外运动（支持多类目筛选，如1,2获取类目为居家日用、食品的所有商品，请用英文都好隔开，不传则为全部商品）
        /// </summary>
        public string goods_type { get; set; }

        /// <summary>
        /// 京推推二级分类（可通过超级分类API获取全部的二级分类id，本接口也有返回）
        /// </summary>
        public string goods_second_type { get; set; }

        /// <summary>
        /// 频道id： sift精选好货；nineSift“9块9”精选；collage京东拼购；self京东自营；wtype京东配送；goodShop京东好店；flagShop官方旗舰店；giftGoods奖励商品；import京东国际；jdMarket京东超市；bugGoods漏洞单；remotePost偏远地区包邮
        /// </summary>
        public string eliteId { get; set; }

        /// <summary>
        /// 排序字段： finally券后价；brokerage佣金比例；sale折扣力度；OrderCount30Days 30天引入订单量；inOrderComm30Days 30天支出佣金；getCouponNum领券量；comments评论数；goodComments好评数
        /// </summary>
        public string sortName { get; set; }

        /// <summary>
        /// 排序： asc升序,desc降序
        /// </summary>
        public string sort { get; set; }

        /// <summary>
        /// 价格筛选:最低价格
        /// </summary>
        public string price_start { get; set; }

        /// <summary>
        /// 价格筛选:最高价格
        /// </summary>
        public string price_end { get; set; }

        /// <summary>
        /// 京推推品牌ID筛选
        /// </summary>
        public string brand_id { get; set; }

        /// <summary>
        /// 店铺id筛选
        /// </summary>
        public string shop_id { get; set; }
    }
}
