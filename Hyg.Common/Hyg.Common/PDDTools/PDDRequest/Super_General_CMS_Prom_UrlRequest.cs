/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_General_CMS_Prom_UrlRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 10:37:46 
备注说明 : 生成商城推广链接接口--请求参数

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 生成商城推广链接接口--请求参数
    /// </summary>
    public class Super_General_CMS_Prom_UrlRequest: Custom_ParamterEntity
    {
        /// <summary>
        /// 0, "1.9包邮"；1, "今日爆款"； 2, "品牌清仓"； 4,"PC端专属商城"
        /// </summary>
        public int channel_type { get; set; }

        /// <summary>
        /// 是否生成手机跳转链接。true-是，false-否，默认false
        /// </summary>
        public bool generate_mobile { get; set; }

        /// <summary>
        /// 是否返回 schema URL
        /// </summary>
        public bool generate_schema_url { get; set; }

        /// <summary>
        /// 是否生成短链接，true-是，false-否
        /// </summary>
        public bool generate_short_url { get; set; }

        /// <summary>
        /// 是否唤起微信客户端， 默认false 否，true 是
        /// </summary>
        public bool generate_weapp_webview { get; set; }

        /// <summary>
        /// 单人团多人团标志。true-多人团，false-单人团 默认false
        /// </summary>
        public bool multi_group { get; set; }

        /// <summary>
        /// 推广位列表，例如：["60005_612"]
        /// </summary>
        public string[] p_id_list { get; set; }

        /// <summary>
        /// 是否生成小程序推广
        /// </summary>
        public bool generate_we_app { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        public string keyword { get; set; }
    }
}
