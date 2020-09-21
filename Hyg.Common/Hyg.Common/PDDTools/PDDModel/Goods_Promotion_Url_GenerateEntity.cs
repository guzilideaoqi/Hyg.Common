/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Goods_Promotion_Url_Generate.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-21 16:45:38 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{
    /// <summary>
    /// Goods_Promotion_Url_Generate
    /// </summary>
    public class Goods_Promotion_Url_GenerateEntity
    {
        public List<Goods_Promotion_Url_List> goods_promotion_url_list { get; set; }
    }

    public class Goods_Promotion_Url_List {
        /// <summary>
        /// 唤醒拼多多app的推广短链接
        /// </summary>
        public string mobile_short_url { get; set; }

        /// <summary>
        /// 唤醒拼多多app的推广长链接
        /// </summary>
        public string mobile_url { get; set; }

        /// <summary>
        /// schema的链接
        /// </summary>
        public string schema_url { get; set; }

        /// <summary>
        /// 推广短链接
        /// </summary>
        public string short_url { get; set; }

        /// <summary>
        /// 推广长链接
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 微博推广短链接
        /// </summary>
        public string weibo_app_web_view_short_url { get; set; }

        /// <summary>
        /// 微博推广链接
        /// </summary>
        public string weibo_app_web_view_url { get; set; }

        /// <summary>
        /// 唤起微信app推广短链接
        /// </summary>
        public string we_app_web_view_short_url { get; set; }

        /// <summary>
        /// 唤起微信app推广链接
        /// </summary>
        public string we_app_web_view_url { get; set; }

        /// <summary>
        /// qq小程序信息
        /// </summary>
        public QQ_app_info qq_app_info { get; set; }

        /// <summary>
        /// 小程序信息
        /// </summary>
        public We_app_info we_app_info { get; set; }
    }

    public class QQ_app_info {
        /// <summary>
        /// 拼多多小程序id
        /// </summary>
        public string app_id { get; set; }

        /// <summary>
        /// Banner图
        /// </summary>
        public string banner_url { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string desc { get; set; }

        /// <summary>
        /// 小程序path值
        /// </summary>
        public string page_path { get; set; }

        /// <summary>
        /// 小程序icon
        /// </summary>
        public string qq_app_icon_url { get; set; }


        /// <summary>
        /// 来源名
        /// </summary>
        public string source_display_name { get; set; }

        /// <summary>
        /// 小程序标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string user_name { get; set; }
    }

    public class We_app_info {
        /// <summary>
        /// 拼多多小程序id
        /// </summary>
        public string app_id { get; set; }

        /// <summary>
        /// Banner图
        /// </summary>
        public string banner_url { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string desc { get; set; }

        /// <summary>
        /// 小程序path值
        /// </summary>
        public string page_path { get; set; }

        /// <summary>
        /// 小程序icon
        /// </summary>
        public string we_app_icon_url { get; set; }


        /// <summary>
        /// 来源名
        /// </summary>
        public string source_display_name { get; set; }

        /// <summary>
        /// 小程序标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string user_name { get; set; }
    }
}
