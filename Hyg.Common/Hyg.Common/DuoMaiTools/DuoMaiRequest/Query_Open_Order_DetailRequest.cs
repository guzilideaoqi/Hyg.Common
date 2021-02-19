/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : Query_Open_Order_DetailRequest.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-19 17:28:04 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DuoMaiTools.DuoMaiRequest
{
    /// <summary>
    /// 查询订单详情
    /// </summary>
    public class Query_Open_Order_DetailRequest
    {
        /// <summary>
        /// 计划ID
        /// </summary>
        public string ads_id { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string order_sn { get; set; }
    }
}
