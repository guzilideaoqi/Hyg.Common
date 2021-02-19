/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : CPS_Stores_PlansEntity.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-19 10:42:16 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DuoMaiTools.DuoMaiModel
{
    /// <summary>
    /// CPS_Stores_PlansEntity
    /// </summary>
    public class CPS_Stores_PlansEntity
    {
        /// <summary>
        /// 计划id
        /// </summary>
        public string ads_id { get; set; }
        /// <summary>
        /// 计划名称
        /// </summary>
        public string ads_name { get; set; }
        /// <summary>
        /// 所属商城名称
        /// </summary>
        public string store_name { get; set; }
        /// <summary>
        /// 活动类型：0 web 1 wap 3 ROI 4 小程序
        /// </summary>
        public string channel { get; set; }
        /// <summary>
        /// RD有效期
        /// </summary>
        public string rddays { get; set; }
        /// <summary>
        /// 普通佣金说明，具体佣金说明及政策请访问
        /// </summary>
        public string commission { get; set; }
        /// <summary>
        /// 当category=1 海外商家时，此字段表示计划允许的跟单地区
        /// </summary>
        public string category_area { get; set; }
        /// <summary>
        /// 商家类型：0 国内商家 1 海外商家 2 跨境电商
        /// </summary>
        public string category { get; set; }
        /// <summary>
        /// 审核方式 1人工审核 2自动通过
        /// </summary>
        public string apply_mode { get; set; }
        /// <summary>
        /// 计划开始时间，格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string stime { get; set; }
        /// <summary>
        /// 计划截止时间，格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string etime { get; set; }
        /// <summary>
        /// 默认url
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 计划logo
        /// </summary>
        public string ads_logo { get; set; }
        /// <summary>
        /// 计划状态：0 待提交 1 待审核 2 已拒绝 3 运行中 4 修改待审核 7 已终止 8已挂起
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 申请状态：1审核通过，0未审核通过，-1未申请
        /// </summary>
        public string ads_apply_status { get; set; }
    }
}
