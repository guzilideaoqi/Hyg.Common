/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_General_Resource_UrlResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 15:03:51 
备注说明 : 拼多多主站频道推广接口--返回参数

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// 拼多多主站频道推广接口--返回参数
    /// </summary>
    public class Super_General_Resource_UrlResponse
    {
        public Resource_url_response resource_url_response { get; set; }
    }

    public class Resource_url_response
    {
        /// <summary>
        /// 多人团链接
        /// </summary>
        public multi_url_listEntity multi_url_list { get; set; }

        public string sign { get; set; }

        /// <summary>
        /// qq小程序信息
        /// </summary>
        public QQ_app_info qq_app_info { get; set; }

        /// <summary>
        /// 单人团链接
        /// </summary>
        public single_url_listEntity single_url_list { get; set; }

        /// <summary>
        /// 小程序信息
        /// </summary>
        public We_app_info we_app_info { get; set; }
    }
}
