/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : TB_ActivityLinkResult.cs
创建人员 : Mr.Hu
创建时间 : 2021-03-05 17:36:54 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// 淘宝活动转链结果
    /// </summary>
    public class TB_ActivityLinkResult
    {
        /// <summary>
        /// 会场活动名称
        /// </summary>
        public string page_name { get; set; }

        /// <summary>
        /// 推广长链接
        /// </summary>
        public string click_url { get; set; }

        /// <summary>
        /// 推广淘口令
        /// </summary>
        public string Tpwd { get; set; }

        /// <summary>
        /// 针对iOS14版本，增加对应能解析的长口令
        /// </summary>
        public string longTpwd { get; set; }

        /// <summary>
        /// 投放平台, 1-PC 2-无线
        /// </summary>
        public string terminal_type { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        public string page_start_time { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        public string page_end_time { get; set; }

        /// <summary>
        /// 【本地化】微信推广二维码地址
        /// </summary>
        public string wx_qrcode_url { get; set; }

        /// <summary>
        /// 【本地化】微信小程序路径
        /// </summary>
        public string wx_miniprogram_path { get; set; }
    }
}
