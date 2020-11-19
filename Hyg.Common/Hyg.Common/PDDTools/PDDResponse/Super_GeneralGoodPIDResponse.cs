/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_GeneralGoodPIDResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 11:18:30 
备注说明 : 生成商品PID--返回参数

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// 生成商品PID--返回参数
    /// </summary>
    public class Super_GeneralGoodPIDResponse
    {
        public P_id_generate_response p_id_generate_response { get; set; }
    }

    public class P_id_generate_response
    {
        /// <summary>
        /// 多多进宝推广位对象列表
        /// </summary>
        public List<GeneralPIDEntity> p_id_list { get; set; }

        /// <summary>
        /// PID剩余数量
        /// </summary>
        public int remain_pid_count { get; set; }
    }
}
