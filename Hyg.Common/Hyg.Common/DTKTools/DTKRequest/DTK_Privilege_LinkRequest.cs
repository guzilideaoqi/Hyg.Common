/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Privilege_LinkRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:14:45 
备注说明 : 高佣转链

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// 高佣转链
    /// </summary>
    public class DTK_Privilege_LinkRequest
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v1.3.0";
        /// <summary>
        /// 商品ID
        /// </summary>
        public string goodsId { get; set; }
        /// <summary>
        /// 优惠券ID
        /// </summary>
        public string couponId { get; set; }
        /// <summary>
        /// 推广位ID
        /// </summary>
        public string pid { get; set; }
        /// <summary>
        /// 渠道ID
        /// </summary>
        public string channelId { get; set; }
        /// <summary>
        /// 0.不使用付定返红包，1.参与付定返红包
        /// </summary>
        public string rebateType { get; set; }

        /// <summary>
        /// 会员运营ID
        /// </summary>
        public string specialId { get; set; }

        /// <summary>
        /// 淘宝客外部用户标记，如自身系统账户ID；微信ID等
        /// </summary>
        public string externalId { get; set; }

        /// <summary>
        /// 团长与下游渠道合作的特殊标识，用于统计渠道推广效果 （新增入参）
        /// </summary>
        public string xid { get; set; }
    }
}
