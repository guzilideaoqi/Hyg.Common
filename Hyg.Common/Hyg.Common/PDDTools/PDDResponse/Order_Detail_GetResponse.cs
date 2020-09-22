/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Order_Detail_GetResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-22 11:20:35 
备注说明 : 订单详情返回信息

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// 订单详情返回信息
    /// </summary>
    public class Order_Detail_GetResponse
    {
        /// <summary>
        /// 订单详情返回信息
        /// </summary>
        public Order_Detail_GetEntity order_detail_response { get; set; }
    }
}
