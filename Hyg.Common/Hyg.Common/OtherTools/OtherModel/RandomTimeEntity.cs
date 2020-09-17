/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : OtherModel.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 18:09:20 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.OtherTools
{
    /// <summary>
    /// 随机时间段实体
    /// </summary>
    public class RandomTimeEntity
    {
        /// <summary>
        /// 最小时间
        /// </summary>
        public int MinValue { get; set; } = 1;
        /// <summary>
        /// 最大时间
        /// </summary>
        public int MaxValue { get; set; } = 3;
    }
}
