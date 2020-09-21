/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Order_List_GetResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-21 18:16:06 
备注说明 : 增量订单返回信息

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// 增量订单返回信息
    /// </summary>
    public class IncrementOrder_List_GetResponse
    {
       public PDD_OrderInfoDetail order_list_get_response { get; set; }
    }


}
