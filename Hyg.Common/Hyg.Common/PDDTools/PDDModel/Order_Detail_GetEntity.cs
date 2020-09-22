/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Order_Detail_GetEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-22 11:13:54 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{
    /// <summary>
    /// 拼多多订单详情
    /// </summary>
    public class Order_Detail_GetEntity:Order_BaseEntity
    {
        public string cps_sign { get; set; }
        /// <summary>
        /// 推广位id
        /// </summary>
        public string pid { get; set; }
        /// <summary>
        /// 售后状态  0：无，1：售后中，2：售后完成
        /// </summary>
        public int return_status { get; set; }
    }
}
