/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_General_Mall_UrlRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 14:26:59 
备注说明 : 多多客工具生成店铺推广链接API--请求参数

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 多多客工具生成店铺推广链接API--请求参数
    /// </summary>
    public class Super_General_Mall_UrlRequest : Custom_ParamterEntity
    {
        /// <summary>
        /// 是否生成店铺收藏券推广链接
        /// </summary>
        public bool generate_mall_collect_coupon { get; set; }

        /// <summary>
        /// 是否生成qq小程序
        /// </summary>
        public bool generate_qq_app { get; set; }

        /// <summary>
        /// 是否返回 schema URL
        /// </summary>
        public bool generate_schema_url { get; set; }

        /// <summary>
        /// 是否生成短链接，true-是，false-否
        /// </summary>
        public bool generate_short_url { get; set; }

        /// <summary>
        /// 是否生成唤起微信客户端链接，true-是，false-否，默认false
        /// </summary>
        public bool generate_weapp_webview { get; set; } = false;

        /// <summary>
        /// 店铺id
        /// </summary>
        public long mall_id { get; set; }

        /// <summary>
        /// true--生成多人团推广链接 false--生成单人团推广链接（默认false）1、单人团推广链接：用户访问单人团推广链接，可直接购买商品无需拼团。2、多人团推广链接：用户访问双人团推广链接开团，若用户分享给他人参团，则开团者和参团者的佣金均结算给推手
        /// </summary>
        public bool multi_group { get; set; }

        /// <summary>
        /// 推广位
        /// </summary>
        public string pid { get; set; }
    }
}
