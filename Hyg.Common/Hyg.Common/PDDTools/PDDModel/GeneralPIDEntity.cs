/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : GeneralPIDEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 11:19:28 
备注说明 : 生成的PID信息

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{
    /// <summary>
    /// 生成的PID信息
    /// </summary>
    public class GeneralPIDEntity
    {
        /// <summary>
        /// 推广位创建时间
        /// </summary>
        public long create_time { get; set; }

        /// <summary>
        /// 推广位名称
        /// </summary>
        public string pid_name { get; set; }

        /// <summary>
        /// 调用方推广位ID
        /// </summary>
        public string p_id { get; set; }
    }
}
