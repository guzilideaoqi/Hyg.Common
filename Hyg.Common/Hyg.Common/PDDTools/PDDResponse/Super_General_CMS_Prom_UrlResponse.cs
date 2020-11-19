/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_General_CMS_Prom_UrlResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 10:52:24 
备注说明 : 生成商城推广链接接口--返回结果

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// 生成商城推广链接接口--返回结果
    /// </summary>
    public class Super_General_CMS_Prom_UrlResponse
    {
        /// <summary>
        /// 商城推广链接返回对象
        /// </summary>
        public Cms_promotion_url_generate_response cms_promotion_url_generate_response { get; set; }
    }

    public class Cms_promotion_url_generate_response {
        public int total { get; set; }
        public List<CMS_Prom_UrlEntity> url_list { get; set; }
    }

    public class CMS_Prom_UrlEntity : Prom_UrlEntity { }
}
