/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_QueryGoodPIDRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 11:28:51 
备注说明 : 查询商品推广位--请求参数

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 查询商品推广位--请求参数
    /// </summary>
    public class Super_QueryGoodPIDRequest
    {
        /// <summary>
        /// 返回的页数
        /// </summary>
        public int page { get; set; }

        /// <summary>
        /// 返回的每页推广位数量
        /// </summary>
        public int page_size { get; set; }

        /// <summary>
        /// 推广位id列表
        /// </summary>
        public string[] pid_list { get; set; }
    }
}
