/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Good_Zs_UnitGenerateEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-21 15:38:28 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{
    /// <summary>
    /// 拼多多转链结果
    /// </summary>
    public class UnitGenerateDetailEntity {
        /// <summary>
        /// 推广短链接（可唤起拼多多app）
        /// </summary>
        public string mobile_short_url { get; set; }

        /// <summary>
        /// 推广长链接（唤起拼多多app）
        /// </summary>
        public string mobile_url { get; set; }

        /// <summary>
        /// 推广短链接（唤起拼多多app）
        /// </summary>
        public string multi_group_mobile_short_url { get; set; }

        /// <summary>
        /// 推广长链接（可唤起拼多多app）
        /// </summary>
        public string multi_group_mobile_url { get; set; }

        /// <summary>
        /// 双人团推广短链接
        /// </summary>
        public string multi_group_short_url { get; set; }

        /// <summary>
        /// 双人团推广长链接
        /// </summary>
        public string multi_group_url { get; set; }

        /// <summary>
        /// 单人团推广短链接
        /// </summary>
        public string short_url { get; set; }

        /// <summary>
        /// 单人团推广长链接
        /// </summary>
        public string url { get; set; }
    }
}
