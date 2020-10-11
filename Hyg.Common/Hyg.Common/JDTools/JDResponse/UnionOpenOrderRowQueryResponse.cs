/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : UnionOpenOrderRowQueryResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-11 13:40:26 
备注说明 : 订单行查询接口

 =====================================End=======================================================*/
using Hyg.Common.JDTools.JDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDResponse
{
    /// <summary>
    /// 订单行查询接口
    /// </summary>
    public class UnionOpenOrderRowQueryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public UnionOpenOrderRowQueryResult jd_union_open_order_row_query_response { get; set; }
    }

    public class UnionOpenOrderRowQueryResult
    {
        public int code { get; set; }

        /// <summary>
        /// 订单结果
        /// </summary>
        public string result { get; set; }
    }

    public class UnionOpenOrderRowQueryResultDetail
    {
        /// <summary>
        /// 返回码
        /// </summary>
        public int code { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        public string message { get; set; }

        public List<UnionOpenOrderRowQueryInfo> data { get; set; }

        public bool hasMore { get; set; }

        public string requestId { get; set; }
    }

    public class UnionOpenOrderRowQueryInfo : JD_OrderBaseEntity { }
}
