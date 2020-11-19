/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_QueryRecommendGoodRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 11:44:09 
备注说明 : 运营频道商品查询--请求参数

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 运营频道商品查询--请求参数
    /// </summary>
    public class Super_QueryRecommendGoodRequest : Custom_ParamterEntity
    {
        /// <summary>
        /// 频道类型；0, "1.9包邮", 1, "今日爆款", 2, "品牌清仓", 3, "默认商城", 非必填 ,默认是1
        /// </summary>
        public int channel_type { get; set; } = 1;

        /// <summary>
        /// 请求数量；默认值 ： 400
        /// </summary>
        public int limit { get; set; } = 400;

        /// <summary>
        /// 翻页时建议填写前页返回的list_id值
        /// </summary>
        public string list_id { get; set; }

        /// <summary>
        /// 从多少位置开始请求；默认值 ： 0
        /// </summary>
        public int offset { get; set; }

        /// <summary>
        /// 推广位id
        /// </summary>
        public string pid { get; set; }
    }
}
