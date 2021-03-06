﻿/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : multi_url_listEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 10:56:58 
备注说明 : 双人团链接

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{
    /// <summary>
    /// 双人团链接
    /// </summary>
    public class multi_url_listEntity
    {
        /// <summary>
        /// 双人团唤醒拼多多app短链接
        /// </summary>
        public string mobile_short_url { get; set; }

        /// <summary>
        /// 双人团唤醒拼多多app长链接
        /// </summary>
        public string mobile_url { get; set; }

        /// <summary>
        /// schema的链接
        /// </summary>
        public string schema_url { get; set; }

        /// <summary>
        /// 双人团短链接
        /// </summary>
        public string short_url { get; set; }

        /// <summary>
        /// 双人团长链接
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 双人团唤醒微信短链接
        /// </summary>
        public string we_app_web_view_short_url { get; set; }

        /// <summary>
        /// 双人团唤醒微信链接
        /// </summary>
        public string we_app_web_view_url { get; set; }
    }
}
