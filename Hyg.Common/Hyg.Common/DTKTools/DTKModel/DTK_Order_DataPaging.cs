/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Order_Data.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 17:31:45 
备注说明 : 订单分页数据

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// 订单分页数据
    /// </summary>
    public class DTK_Order_DataPaging
    {
        /// <summary>
        /// 是否还有上一页
        /// </summary>
        public bool has_pre { get; set; }

        /// <summary>
        /// 是否还有下一页
        /// </summary>
        public bool has_next { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public int page_no { get; set; }

        /// <summary>
        /// 显示数量
        /// </summary>
        public int page_size { get; set; }

        /// <summary>
        /// 位点字段，由调用方原样传递
        /// </summary>
        public string position_index { get; set; }

        public publisher_order_dtoEntity results { get; set; }
    }

    public class publisher_order_dtoEntity {
        public List<DTK_OrderItem> publisher_order_dto { get; set; }
    }
}
