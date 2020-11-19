/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_WeApp_Qrcode_UrlResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 16:30:28 
备注说明 : 多多客生成单品推广小程序二维码url--返回参数

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// 多多客生成单品推广小程序二维码url--返回参数
    /// </summary>
    public class Super_WeApp_Qrcode_UrlResponse
    {
        public Weapp_qrcode_generate_response weapp_qrcode_generate_response { get; set; }
    }

    public class Weapp_qrcode_generate_response {
        /// <summary>
        /// 单品推广小程序二维码url
        /// </summary>
        public string url { get; set; }
    }
}
