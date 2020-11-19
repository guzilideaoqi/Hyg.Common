/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Range_ItemEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 15:44:21 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{
    /// <summary>
    /// Range_ItemEntity
    /// </summary>
    public class Range_ItemEntity
    {
        /// <summary>
        /// 区间的开始值
        /// </summary>
        public long range_from { get; set; }

        /// <summary>
        /// range_id为1表示红包抵后价（单位分）， range_id为2表示佣金比例（单位千分之几)
        /// </summary>
        public int range_id { get; set; }

        /// <summary>
        /// 区间的结束值
        /// </summary>
        public long range_to { get; set; }
    }
}
