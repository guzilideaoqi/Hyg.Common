/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : TopicCatalogueItem.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:08:58 
备注说明 : 精选专辑

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// 精选专辑
    /// </summary>
    public class TopicCatalogueItem
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        public int topicId { get; set; }
        /// <summary>
        /// 活动名称
        /// </summary>
        public string topicName { get; set; }
        /// <summary>
        /// 活动开始时间
        /// </summary>
        public string startTime { get; set; }
        /// <summary>
        /// 活动结束时间
        /// </summary>
        public string endTime { get; set; }
        /// <summary>
        /// 专辑活动banner（部分活动提供banner，可能提供多张）
        /// </summary>
        public List<string> banner { get; set; }
    }
}
