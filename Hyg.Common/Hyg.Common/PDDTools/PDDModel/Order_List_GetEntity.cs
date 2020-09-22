/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Order_List_GetEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-21 18:02:00 
备注说明 : 拼多多订单实体

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{

    public class PDD_OrderInfoDetail
    {
        public List<Order_List_GetEntity> order_list { get; set; }
        public long total_count { get; set; }
    }

    /// <summary>
    /// 拼多多订单实体
    /// </summary>
    public class Order_List_GetEntity: Order_BaseEntity
    {

    }
}
