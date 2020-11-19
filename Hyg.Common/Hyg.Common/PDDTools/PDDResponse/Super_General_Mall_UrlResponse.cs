/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_General_Mall_UrlResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 14:30:29 
备注说明 : 多多客工具生成店铺推广链接API--返回参数

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// 多多客工具生成店铺推广链接API--返回参数
    /// </summary>
    public class Super_General_Mall_UrlResponse
    {
        public Mall_coupon_generate_url_response mall_coupon_generate_url_response { get; set; }
    }

    public class Mall_coupon_generate_url_response {
        public List<Mall_Prom_Url> list { get; set; }
    }

    public class Mall_Prom_Url : Prom_Url_BaseEntity {
        /// <summary>
        /// schema的链接
        /// </summary>
        public string schema_url { get; set; }

        /// <summary>
        /// qq小程序信息
        /// </summary>
        public QQ_app_info qq_app_info { get; set; }
    }
}
