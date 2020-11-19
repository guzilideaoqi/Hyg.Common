/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_QueryCouponResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-26 11:35:39 
备注说明 : 优惠券查询结果

 =====================================End=======================================================*/
using Hyg.Common.JDTools.JDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDResponse
{
    /// <summary>
    /// 优惠券查询结果
    /// </summary>
    public class Super_QueryCouponResponse
    {
        public Jd_union_open_coupon_query_response jd_union_open_coupon_query_response { get; set; }
    }

    public class Jd_union_open_coupon_query_response : JD_Common_First_ResponseBase { }

    /// <summary>
    /// 优惠券结果
    /// </summary>
    public class Super_QueryCoupon_Result : JD_Common_Two_ResponseBase
    {
        public List<Super_QueryCoupon_Detail> data { get; set; }
    }

    /// <summary>
    /// 优惠券查询结果详情
    /// </summary>
    public class Super_QueryCoupon_Detail
    {
        /// <summary>
        /// 优惠券开始时间
        /// </summary>
        public long beginTime { get; set; }

        /// <summary>
        /// 券面额
        /// </summary>
        public decimal discount { get; set; }

        /// <summary>
        /// 优惠券结束时间
        /// </summary>
        public long endTime { get; set; }

        /// <summary>
        /// 优惠券链接
        /// </summary>
        public string link { get; set; }

        /// <summary>
        /// 优惠券数量
        /// </summary>
        public long num { get; set; }

        /// <summary>
        /// 券使用平台
        /// </summary>
        public string platform { get; set; }

        /// <summary>
        /// 券消费限额
        /// </summary>
        public decimal quota { get; set; }

        /// <summary>
        /// 券剩余张数
        /// </summary>
        public int remainNum { get; set; }

        /// <summary>
        /// 券领取开始时间(时间戳，毫秒)
        /// </summary>
        public long takeBeginTime { get; set; }

        /// <summary>
        /// 券领取结束时间
        /// </summary>
        public long takeEndTime { get; set; }

        /// <summary>
        /// 券有效状态
        /// </summary>
        public string yn { get; set; }
    }
}
