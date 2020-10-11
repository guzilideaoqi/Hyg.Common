/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : UnionOpenPromotionCommonRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-11 10:21:41 
备注说明 : 网站/APP获取推广链接接口

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDRequest
{
    /// <summary>
    /// 网站/APP获取推广链接接口
    /// </summary>
    public class UnionOpenPromotionCommonRequest
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        public PromotionCodeReq promotionCodeReq { get; set; }
    }

    public class PromotionCodeReq {
        /// <summary>
        /// 推广物料
        /// </summary>
        public string materialId { get; set; }

        /// <summary>
        /// 站点ID是指在联盟后台的推广管理中的网站Id、APPID（1、通用转链接口禁止使用社交媒体id入参；2、订单来源，即投放链接的网址或应用必须与传入的网站ID/AppID备案一致，否则订单会判“无效-来源与备案网址不符”）
        /// </summary>
        public string siteId { get; set; }

        /// <summary>
        /// 推广位ID
        /// </summary>
        public string positionId { get; set; }

        /// <summary>
        /// 子联盟ID（需申请，申请方法请见https://union.jd.com/helpcenter/13246-13247-46301），该字段为自定义参数，建议传入字母数字和下划线的格式
        /// </summary>
        public string subUnionId { get; set; }

        /// <summary>
        /// 系统扩展参数，无需传入
        /// </summary>
        public string ext1 { get; set; }

        /// <summary>
        /// 联盟子站长身份标识，格式：子站长ID_子站长网站ID_子站长推广位ID
        /// </summary>
        public string pid { get; set; }

        /// <summary>
        /// 优惠券领取链接，在使用优惠券、商品二合一功能时入参，且materialId须为商品详情页链接
        /// </summary>
        public string couponUrl { get; set; }

        /// <summary>
        /// 礼金批次号
        /// </summary>
        public string giftCouponKey { get; set; }
    }
}
