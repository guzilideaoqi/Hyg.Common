/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_GeneralGoodPIDRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 11:16:07 
备注说明 : 生成商品pid--请求参数

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 生成商品pid--请求参数
    /// </summary>
    public class Super_GeneralGoodPIDRequest
    {
        /// <summary>
        /// 要生成的推广位数量，默认为10，范围为：1~100
        /// </summary>
        public int number { get; set; } = 10;

        /// <summary>
        /// 推广位名称，例如["1","2"]
        /// </summary>
        public string[] p_id_name_list { get; set; }
    }
}
