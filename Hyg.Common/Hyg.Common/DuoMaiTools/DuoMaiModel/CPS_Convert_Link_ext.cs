/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : CPS_Convert_Link_ext.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-19 15:36:51 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DuoMaiTools.DuoMaiModel
{
    /// <summary>
    /// CPS_Convert_Link_ext
    /// </summary>
    public class CPS_Convert_Link_ext
    {
        /// <summary>
        /// 优惠券 淘宝为优惠券id 京东为优惠券链接
        /// </summary>
        public string coupon { get; set; }
        /// <summary>
        /// euid 反馈标签
        /// </summary>
        public string euid { get; set; }
        /// <summary>
        /// 礼金批次号
        /// </summary>
        public string gift_coupon_key { get; set; }
        /// <summary>
        /// 用户id 用于一些免登场景
        /// </summary>
        public string uid { get; set; }
        /// <summary>
        /// 用户昵称 用于一些免登场景
        /// </summary>
        public string uname { get; set; }
    }
}
