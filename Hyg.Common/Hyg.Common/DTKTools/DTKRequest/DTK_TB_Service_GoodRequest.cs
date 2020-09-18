/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_TB_Service_GoodRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:17:16 
备注说明 : 联盟搜索

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// 联盟搜索
    /// </summary>
    public class DTK_TB_Service_GoodRequest
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v2.1.0";

        /// <summary>
        /// 第几页，默认1
        /// </summary>
        public int pageNo { get; set; }

        /// <summary>
        /// 每页条数， 默认20，范围值1~100
        /// </summary>
        public int pageSize { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        public string keyWords { get; set; }


        /// <summary>
        /// 排序指标：销量（total_sales），淘客佣金比率（tk_rate）， 累计推广量（tk_total_sales），总支出佣金（tk_total_commi），价格（price）,排序方式：排序_des（降序），排序_asc（升序）,示例：升序查询销量：total_sales_asc
        /// </summary>
        public string sort { get; set; }

        /// <summary>
        /// 是否商城商品，设置为1表示该商品是属于淘宝商城商品，设置为非1或不设置表示不判断这个属性（和overseas字段冲突，若已请求source，请勿再请求overseas）
        /// </summary>
        public int? source { get; set; }

        /// <summary>
        /// 是否海外商品，设置为1表示该商品是属于海外商品，设置为非1或不设置表示不判断这个属性（和source字段冲突，若已请求overseas，请勿再请求source）
        /// </summary>
        public int? overseas { get; set; }

        /// <summary>
        /// 折扣价范围上限，单位：元
        /// </summary>
        public decimal? endPrice { get; set; }

        /// <summary>
        /// 折扣价范围下限，单位：元
        /// </summary>
        public decimal? startPrice { get; set; }

        /// <summary>
        /// 媒体淘客佣金比率下限，如：1234表示12.34%
        /// </summary>
        public decimal? startTkRate { get; set; }

        /// <summary>
        /// 商品筛选-淘客佣金比率上限，如：1234表示12.34%
        /// </summary>
        public decimal? endTkRate { get; set; }

        /// <summary>
        /// 是否有优惠券，设置为true表示该商品有优惠券，设置为false或不设置表示不判断这个属性
        /// </summary>
        public bool hasCoupon { get; set; }
    }
}
