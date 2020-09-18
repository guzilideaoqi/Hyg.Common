/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : ActivityCatalogueItem.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:40:19 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// ActivityCatalogueItem
    /// </summary>
    public class ActivityCatalogueItem
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        public int activityId { get; set; }
        /// <summary>
        /// 活动名称
        /// </summary>
        public string activityName { get; set; }
        /// <summary>
        /// 活动开始时间
        /// </summary>
        public string startTime { get; set; }
        /// <summary>
        /// 活动结束时间
        /// </summary>
        public string endTime { get; set; }
        /// <summary>
        /// 单品标签图片
        /// </summary>
        public string goodsLabel { get; set; }
        /// <summary>
        /// 商详页标签图片
        /// </summary>
        public string detailLabel { get; set; }
        /// <summary>
        /// 活动商品类型 1.非定金商品 2.定金商品 3.付付定返红包
        /// </summary>
        public int goodsType { get; set; }
    }
}
