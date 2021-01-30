/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_GoodQueryResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-26 10:28:20 
备注说明 : 高级接口商品搜索结果

 =====================================End=======================================================*/
using Hyg.Common.JDTools.JDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDResponse
{
    /// <summary>
    /// 高级接口商品搜索结果
    /// </summary>
    public class Super_GoodQueryResponse
    {
        public Jd_union_open_goods_query_response jd_union_open_goods_query_response { get; set; }
    }


    public class Jd_union_open_goods_query_response : JD_Common_First_ResponseBase { }

    public class Super_Jd_GoodInfo_Reponse: JD_Common_Two_ResponseBase
    {
        public int totalCount { get; set; }
        public JFGoodsResp[] data { get; set; }

        public List<JFGoodsRespRow> jFGoodsRespRows { get; set; }
    }
    public class Super_GoodsResp : JD_GoodBaseEntity
    {
        /// <summary>
        /// 京喜商品类型，1京喜、2京喜工厂直供、3京喜优选（包含3时可在京东APP购买）
        /// </summary>
        public int[] jxFlags { get; set; }
    }
}
