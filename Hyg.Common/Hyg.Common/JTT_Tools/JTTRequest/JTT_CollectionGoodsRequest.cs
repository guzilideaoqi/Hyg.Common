/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : JTT_CollectionGoodsRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-12-24 14:36:16 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JTT_Tools.JTTRequest
{
    /// <summary>
    /// JTT_CollectionGoodsRequest
    /// </summary>
    public class JTT_CollectionGoodsRequest : JTT_CommonRequest
    {
        /// <summary>
        /// 分页获取数据（默认第1页）
        /// </summary>
        public int pageIndex { get; set; }
        /// <summary>
        /// 单页面显示条数(最大100条最少10条)
        /// </summary>
        public string pageSize { get; set; }
        /// <summary>
        /// 关键词搜索（可以输入关键词、SKU、商品链接、店铺名称）
        /// </summary>
        public string keyword { get; set; }
    }
}
