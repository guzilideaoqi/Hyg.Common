/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : HaoDanKu_GetOrienteeringItemEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-23 10:14:33 
备注说明 : 定向计划商品

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.HaoDanKu.HaoDanKuModel
{
    /// <summary>
    /// 定向计划商品
    /// </summary>
    public class HaoDanKu_GetOrienteeringItemEntity:HaoDanKu_GoodBaseEntity
    {
        /// <summary>
        /// 定向计划佣金比例
        /// </summary>
        public decimal dx_rates { get; set; }

        /// <summary>
        /// 定向计划链接
        /// </summary>
        public string tkurl { get; set; }
    }
}
