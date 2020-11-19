/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Prom_Url_BaseEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 14:24:39 
备注说明 : 基类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{
    /// <summary>
    /// 基类
    /// </summary>
    public class Prom_Url_BaseEntity
    {

        /// <summary>
        /// 唤醒拼多多app短链
        /// </summary>
        public string mobile_short_url { get; set; }

        /// <summary>
        /// 唤醒拼多多app链接
        /// </summary>
        public string mobile_url { get; set; }

        /// <summary>
        /// h5短链接
        /// </summary>
        public string short_url { get; set; }


        /// <summary>
        /// h5长链接
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 唤醒微信短链
        /// </summary>
        public string we_app_web_view_short_url { get; set; }

        /// <summary>
        /// 唤醒微信长链
        /// </summary>
        public string we_app_web_view_url { get; set; }
    }
}
