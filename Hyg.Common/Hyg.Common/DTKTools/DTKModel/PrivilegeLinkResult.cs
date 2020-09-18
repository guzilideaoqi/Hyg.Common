/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : PrivilegeLinkResult.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:55:01 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// PrivilegeLinkResult
    /// </summary>
    public class PrivilegeLinkResult
    {
        /// <summary>
        /// 商品优惠券推广链接	
        /// </summary>
        public string couponClickUrl { get; set; }
        /// <summary>
        /// 优惠券结束时间	
        /// </summary>
        public string couponEndTime { get; set; }
        /// <summary>
        /// 优惠券面额	
        /// </summary>
        public string couponInfo { get; set; }
        /// <summary>
        /// 优惠券开始时间
        /// </summary>
        public string couponStartTime { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        public string itemId { get; set; }
        /// <summary>
        /// 优惠券总量
        /// </summary>
        public string couponTotalCount { get; set; }
        /// <summary>
        /// 优惠券剩余数量
        /// </summary>
        public string couponRemainCount { get; set; }
        /// <summary>
        /// 商品淘客链接
        /// </summary>
        public string itemUrl { get; set; }
        /// <summary>
        /// 淘口令
        /// </summary>
        public string tpwd { get; set; }
        /// <summary>
        /// 佣金比例
        /// </summary>
        public decimal maxCommissionRate { get; set; }
        /// <summary>
        /// 短链接
        /// </summary>
        public string shortUrl { get; set; }

        /// <summary>
        /// 当传入请求参数channelId、specialId、externalId时，该字段展示预估最低佣金率(%)
        /// </summary>
        public decimal minCommissionRate { get; set; }

        /// <summary>
        /// 针对iOS14版本，增加对应能解析的长口令
        /// </summary>
        public string longTpwd { get; set; }
    }
}
