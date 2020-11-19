/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_QueryGoodPIDResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 11:31:09 
备注说明 : 查询推广位--返回参数

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// 查询推广位--返回参数
    /// </summary>
    public class Super_QueryGoodPIDResponse
    {
        public P_id_query_response p_id_query_response { get; set; }
    }

    public class P_id_query_response
    {
        /// <summary>
        /// 多多进宝推广位对象列表
        /// </summary>
        public List<GeneralPIDEntity> p_id_list { get; set; }

        /// <summary>
        /// 返回推广位总数
        /// </summary>
        public int total_count { get; set; }
    }
}
