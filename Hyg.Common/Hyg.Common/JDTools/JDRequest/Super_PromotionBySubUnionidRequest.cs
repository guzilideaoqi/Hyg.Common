/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_PromotionBySubUnionidRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-26 13:36:38 
备注说明 : 社交媒体获取推广链接接口【申请】

 =====================================End=======================================================*/
using Hyg.Common.JDTools.JDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDRequest
{
    /// <summary>
    /// 社交媒体获取推广链接接口【申请】
    /// </summary>
    public class Super_PromotionBySubUnionidRequest
    {
        /// <summary>
        /// 请求入参
        /// </summary>
        public Super_PromotionBySubUnionid promotionCodeReq { get; set; }
    }

    public class Super_PromotionBySubUnionid : JD_ConvertLinkRequestBaseEntity {
        /// <summary>
        /// 转链类型，1：长链， 2 ：短链 ，3： 长链+短链，默认短链，短链有效期60天
        /// </summary>
        public int chainType { get; set; }
        /// <summary>
        /// 礼金批次号
        /// </summary>
        public string giftCouponKey { get; set; }
    }
}
