/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : CPS_Stores_Plans_DetailEntity.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-19 10:51:27 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DuoMaiTools.DuoMaiModel
{
    /// <summary>
    /// 推广计划详情
    /// </summary>
    public class CPS_Stores_Plans_DetailEntity
    {
        /// <summary>
        /// 计划id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 计划名称
        /// </summary>
        public string ads_name { get; set; }
        /// <summary>
        /// 商城名称
        /// </summary>
        public string store_name { get; set; }
        /// <summary>
        /// 计划相关返佣说明
        /// </summary>
        public string info { get; set; }
        /// <summary>
        /// 所属商城简介说明
        /// </summary>
        public string store_info { get; set; }
        /// <summary>
        /// 审核方式：人工审核 ，自动通过
        /// </summary>
        public string apply_mode { get; set; }
        /// <summary>
        /// 活动类型 0 web 1 wap 3 ROI 4 小程序
        /// </summary>
        public string channel { get; set; }
        /// <summary>
        /// RD有效期
        /// </summary>
        public string rddays { get; set; }
        /// <summary>
        /// 商家类型：0 国内商家 1 海外商家 2 跨境电商
        /// </summary>
        public string category { get; set; }
        /// <summary>
        /// 当category=1 海外商家时，此字段表示计划允许的跟单地区
        /// </summary>
        public string category_area { get; set; }
        /// <summary>
        /// 是否支持euid：0不支持，1支持
        /// </summary>
        public string support_euid { get; set; }
        /// <summary>
        /// 是否支持自定义落地页：0不支持，1支持
        /// </summary>
        public string support_url { get; set; }
        /// <summary>
        /// 结算周期
        /// </summary>
        public string charge_period { get; set; }
        /// <summary>
        /// 计划开始时间，格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string stime { get; set; }
        /// <summary>
        /// 计划截止时间，格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string etime { get; set; }
        /// <summary>
        /// 计划logo
        /// </summary>
        public string ads_logo { get; set; }
        /// <summary>
        /// 默认url
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 订单返回时效
        /// </summary>
        public string order_return { get; set; }
        /// <summary>
        /// 佣金描述信息
        /// </summary>
        public string commission { get; set; }
        /// <summary>
        /// 当前有效的佣金政策详细说明
        /// </summary>
        public List<Commission_detailItem> commission_detail { get; set; }
    }

    public class Commission_detailItem
    {
        /// <summary>
        /// 说明
        /// </summary>
        public string comment { get; set; }
        /// <summary>
        /// 佣金比例
        /// </summary>
        public string commission { get; set; }
        /// <summary>
        /// 政策开始时间，格式:yyyy-MM-dd
        /// </summary>
        public string commission_new_from { get; set; }
        /// <summary>
        /// 政策结束时间，格式:yyyy-MM-dd
        /// </summary>
        public string commission_new_to { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sort { get; set; }
        /// <summary>
        /// 类目名称
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int type { get; set; }
    }
}
