/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : Query_CPS_Open_StoreRequest.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-19 16:17:42 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DuoMaiTools.DuoMaiRequest
{
    /// <summary>
    /// 商城列表请求参数
    /// </summary>
    public class Query_CPS_Open_StoreRequest
    {
        /// <summary>
        /// 商城名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 商城域名/网址
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 是否国内：0所有（默认），-1非国内，1国内
        /// </summary>
        public int is_domestic { get; set; }

        /// <summary>
        /// 推荐商家：0所有（默认），-1不推荐，1推荐
        /// </summary>
        public int recommend { get; set; }

        /// <summary>
        /// 页码 默认1
        /// </summary>
        public int page { get; set; }

        /// <summary>
        /// 分页大小 默认20 最大200
        /// </summary>
        public int page_size { get; set; }
    }
}
