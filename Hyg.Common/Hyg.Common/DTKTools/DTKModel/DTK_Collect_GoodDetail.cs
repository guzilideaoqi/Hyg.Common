/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Collect_GoodDetail.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-11 15:38:05 
备注说明 : 收藏商品详情

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// 收藏商品详情
    /// </summary>
    public class DTK_Collect_GoodDetail
    {
        /// <summary>
        /// 大淘客商品ID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 淘宝商品ID
        /// </summary>
        public string goodsId { get; set; }

        public int trailerGoods { get; set; }
    }
}
