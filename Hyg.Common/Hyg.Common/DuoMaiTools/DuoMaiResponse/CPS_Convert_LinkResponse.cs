/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : CPS_Convert_LinkResponse.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-19 15:35:29 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.DuoMaiTools.DuoMaiModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DuoMaiTools.DuoMaiResponse
{
    /// <summary>
    /// CPS_Convert_LinkResponse
    /// </summary>
    public class CPS_Convert_LinkResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Ads_Item ads { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public CPS_Convert_Link_ext ext { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string shop_coupon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string short_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wx_short { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wx_path { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wx_appid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wx_ghid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wx_qrcode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string deep_link { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string original_link { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string original_link_wx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hide_coupon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wx_app_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wx_qr_code { get; set; }
    }
}
