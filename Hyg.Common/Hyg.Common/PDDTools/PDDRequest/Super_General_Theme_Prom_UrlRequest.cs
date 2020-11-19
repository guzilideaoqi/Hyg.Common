/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_General_Theme_Prom_UrlRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 16:06:46 
备注说明 : 多多进宝主题推广链接生成接口--请求参数

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 多多进宝主题推广链接生成接口--请求参数
    /// </summary>
    public class Super_General_Theme_Prom_UrlRequest : Custom_ParamterEntity
    {
        /// <summary>
        /// BOOLEAN 非必填 是否生成手机跳转链接。true-是,false-否,默认false
        /// </summary>
        public bool generate_mobile { get; set; }

        /// <summary>
        /// BOOLEAN 非必填 是否生成qq小程序
        /// </summary>
        public bool generate_qq_app { get; set; }

        /// <summary>
        /// BOOLEAN 非必填 是否返回 schema URL
        /// </summary>
        public bool generate_schema_url { get; set; }

        /// <summary>
        /// BOOLEAN 非必填 是否生成短链接,true-是,false-否
        /// </summary>
        public bool generate_short_url { get; set; }

        /// <summary>
        /// BOOLEAN 非必填 是否唤起微信客户端， 默认false 否，true 是
        /// </summary>
        public bool generate_weapp_webview { get; set; }

        /// <summary>
        /// BOOLEAN 非必填 是否生成小程序链接
        /// </summary>
        public bool generate_we_app { get; set; }

        /// <summary>
        /// STRING 必填  推广位ID
        /// </summary>
        public string pid { get; set; }

        /// <summary>
        /// 主题ID列表,例如[1,235]
        /// </summary>
        public long[] theme_id_list { get; set; }
    }
}
