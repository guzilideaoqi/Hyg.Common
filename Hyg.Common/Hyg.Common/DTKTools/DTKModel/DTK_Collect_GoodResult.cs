/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Collect_GoodResult.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-11 15:48:25 
备注说明 : 大淘客商品收藏结果

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// 大淘客商品收藏结果
    /// </summary>
    public class DTK_Collect_GoodResult
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        public List<DTK_Collect_GoodDetail> list { get; set; }

        public int totalNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string pageId { get; set; }
    }
}
