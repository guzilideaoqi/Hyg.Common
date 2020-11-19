/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_QueryRecommendGoodResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 11:53:51 
备注说明 : 运营频道商品查询--返回参数

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// 运营频道商品查询--返回参数
    /// </summary>
    public class Super_QueryRecommendGoodResponse
    {
        public Goods_basic_detail_response goods_Basic_Detail_Response { get; set; }
    }

    public class Goods_basic_detail_response
    {
        /// <summary>
        /// 列表
        /// </summary>
        public List<RecommendGoodEntity> list { get; set; }

        /// <summary>
        /// 翻页时必填前页返回的list_id值
        /// </summary>
        public string list_id { get; set; }

        /// <summary>
        /// 搜索id，建议生成推广链接时候填写，提高收益
        /// </summary>
        public string search_id { get; set; }

        public int total { get; set; }
    }
}
