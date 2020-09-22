/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Order_List_Range_ListEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-22 15:15:29 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{
    /// <summary>
    /// Order_List_Range_ListEntity
    /// </summary>
    public class Order_List_Range_ListEntity 
    {
        /// <summary>
        /// last_order_id
        /// </summary>
        public string last_order_id { get; set; }
        /// <summary>
        /// 多多进宝推广位对象列表
        /// </summary>
        public List<Order_List_Range_List_ItemEntity> order_list { get; set; }
    }

    public class Order_List_Range_List_ItemEntity : Order_BaseEntity { }
}
