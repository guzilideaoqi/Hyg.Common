/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : CPS_Convert_LinkRequest.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-19 14:32:25 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.DuoMaiTools.DuoMaiModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DuoMaiTools.DuoMaiRequest
{
    /// <summary>
    /// 转链请求参数
    /// </summary>
    public class CPS_Convert_LinkRequest
    {
        /// <summary>
        /// 链接
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 计划id
        /// </summary>
        public string ads_id { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        public string product_id { get; set; }

        /// <summary>
        /// 推广位id
        /// </summary>
        public string site_id { get; set; }

        /// <summary>
        /// 是否需要商家原始链接
        /// </summary>
        public string original { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        public CPS_Convert_Link_ext ext { get; set; }
    }
}
