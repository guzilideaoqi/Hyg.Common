/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_General_Theme_Prom_UrlResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 16:13:05 
备注说明 : 多多进宝主题推广链接生成接口--返回参数

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// 多多进宝主题推广链接生成接口--返回参数
    /// </summary>
    public class Super_General_Theme_Prom_UrlResponse
    {
        public Theme_promotion_url_generate_response theme_promotion_url_generate_response { get; set; }
    }

    public class Theme_promotion_url_generate_response
    {
        public List<Theme_Prom_Url> url_list { get; set; }
    }

    public class Theme_Prom_Url : Prom_UrlEntity
    {
        /// <summary>
        /// schema的链接
        /// </summary>
        public string schema_url { get; set; }
    }
}
