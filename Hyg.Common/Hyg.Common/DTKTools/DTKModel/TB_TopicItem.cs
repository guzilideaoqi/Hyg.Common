/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : TB_TopicItem.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:06:33 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// TB_TopicItem
    /// </summary>
    public class TB_TopicItem
    {
        /// <summary>
        /// 活动id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 活动名称	
        /// </summary>
        public string activityName { get; set; }
        /// <summary>
        /// 活动开始时间
        /// </summary>
        public string activityStartTime { get; set; }
        /// <summary>
        /// 活动结束时间
        /// </summary>
        public string activityEndTime { get; set; }
        /// <summary>
        /// 活动信息
        /// </summary>
        public string activityInfo { get; set; }
        /// <summary>
        /// 端口类型
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 活动链接
        /// </summary>
        public string activityLink { get; set; }
        /// <summary>
        /// 素材链接
        /// </summary>
        public string materialLink { get; set; }
    }
}
