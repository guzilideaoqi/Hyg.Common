/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : HaoDanKu_GetOrienteeringItemsRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-23 10:10:09 
备注说明 : 定向计划商品API

 =====================================End=======================================================*/
using Hyg.Common.HaoDanKu.HaoDanKuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.HaoDanKu.HaoDanKuRequest
{
    /// <summary>
    /// 定向计划商品API
    /// </summary>
    public class HaoDanKu_GetOrienteeringItemsRequest: HaoDanKuCommonRequest
    {
        /// <summary>
        /// 商品类目：0全部，1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物
        /// </summary>
        public int? cat_id { get; set; }

        /// <summary>
        /// 每页返回条数（请在1,2,5,10,20,50,100中选择一个数值返回）
        /// </summary>
        public int back { get; set; }

        /// <summary>
        /// 分页，用于实现类似分页抓取效果，来源于上次获取后的数据的min_id值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        /// </summary>
        public int min_id { get; set; }
    }
}
