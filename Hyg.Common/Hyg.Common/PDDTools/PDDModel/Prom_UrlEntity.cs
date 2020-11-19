/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : CMS_Prom_UrlEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 11:01:06 
备注说明 : 商城推广链接

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{
    /// <summary>
    /// 商城推广链接
    /// </summary>
    public class Prom_UrlEntity: Prom_Url_BaseEntity
    {

        /// <summary>
        /// 多人团唤醒拼多多app链接
        /// </summary>
        public string multi_group_mobile_short_url { get; set; }

        /// <summary>
        /// 多人团唤醒拼多多app长链接
        /// </summary>
        public string multi_group_mobile_url { get; set; }

        /// <summary>
        /// 多人团短链
        /// </summary>
        public string multi_group_short_url { get; set; }

        /// <summary>
        /// 多人团长链
        /// </summary>
        public string multi_group_url { get; set; }

        /// <summary>
        /// 双人团链接列表
        /// </summary>
        public multi_url_listEntity multi_url_list { get; set; }

        /// <summary>
        /// 多人团唤醒微信推广短链接
        /// </summary>
        public string multi_we_app_web_view_short_url { get; set; }

        /// <summary>
        /// 多人团唤醒微信推广长链接
        /// </summary>
        public string multi_we_app_web_view_url { get; set; }

        /// <summary>
        /// CPSsign
        /// </summary>
        public string sign { get; set; }

        /// <summary>
        /// 单人团链接列表
        /// </summary>
        public single_url_listEntity single_url_list { get; set; }

        /// <summary>
        /// 小程序信息
        /// </summary>
        public We_app_info we_app_info { get; set; }
    }
}
