/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_General_RP_Prom_UrlResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 15:56:47 
备注说明 : 生成营销工具推广链接--返回参数

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// 生成营销工具推广链接--返回参数
    /// </summary>
    public class Super_General_RP_Prom_UrlResponse
    {
        public Rp_promotion_url_generate_response rp_promotion_url_generate_response { get; set; }
    }

    public class Rp_promotion_url_generate_response
    {
        /// <summary>
        /// resource_list
        /// </summary>
        public List<ResourceItem> resource_list { get; set; }

        public List<Rp_Prom_Url> url_list { get; set; }
    }

    public class Rp_Prom_Url : Prom_UrlEntity
    {
        /// <summary>
        /// schema的链接
        /// </summary>
        public string schema_url { get; set; }
    }

    public class ResourceItem
    {
        /// <summary>
        /// 活动描述
        /// </summary>
        public string desc { get; set; }

        /// <summary>
        /// 活动地址
        /// </summary>
        public string url { get; set; }
    }
}
