/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Get_Good_DetailsRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:13:50 
备注说明 : 单品详情

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// 单品详情
    /// </summary>
    public class DTK_Get_Good_DetailsRequest
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v1.2.3";
        /// <summary>
        /// 大淘客商品ID
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 淘宝商品ID
        /// </summary>
        public string goodsId { get; set; }
    }
}
