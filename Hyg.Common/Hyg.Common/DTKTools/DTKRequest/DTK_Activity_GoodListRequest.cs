/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Activity_GoodListRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:12:56 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// 活动商品
    /// </summary>
    public class DTK_Activity_GoodListRequest : CommonGoodRequestParam
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v1.2.2";
        /// <summary>
        /// 默认为1，支持传统的页码分页方式和scroll_id分页方式，后续传入接口第一次返回的pageid，
        /// </summary>
        public string pageId { get; set; }
        /// <summary>
        /// 每页显示数量
        /// </summary>
        public int pageSize { get; set; }
        /// <summary>
        /// 活动id
        /// </summary>
        public int activityId { get; set; }
        /// <summary>
        /// 大淘客一级分类ID  1 -女装，2 -母婴，3 -美妆，4 -居家日用，5 -鞋品，6 -美食，7 -文娱车品，8 -数码家电，9 -男装，10 -内衣，11 -箱包，12 -配饰，13 -户外运动，14 -家装家纺
        /// </summary>
        public int? cid { get; set; }
        /// <summary>
        /// 大淘客二级分类ID  可通过超级分类接口获取二级分类id，当同时传入一级分类id和二级分类id时，以一级分类id为准
        /// </summary>
        public int? subcid { get; set; }
    }
}
