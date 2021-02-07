/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_History_Low_Price_ListRequest.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-07 10:26:02 
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
    /// DTK_History_Low_Price_ListRequest
    /// </summary>
    public class DTK_History_Low_Price_ListRequest : CommonGoodRequestParam
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v1.0.0";
        /// <summary>
        /// 默认为1，支持传统的页码分页方式和scroll_id分页方式，后续传入接口第一次返回的pageid，
        /// </summary>
        public string pageId { get; set; }
        /// <summary>
        /// 每页显示数量
        /// </summary>
        public int pageSize { get; set; }
        /// <summary>
        /// 排序方式，默认为0，0-综合排序，1-商品上架时间从高到低，2-销量从高到低，3-领券量从高到低，4-佣金比例从高到低，5-价格（券后价）从高到低，6-价格（券后价）从低到高
        /// </summary>
        public int sort { get; set; } = 0;
        /// <summary>
        /// 大淘客一级分类ID  1 -女装，2 -母婴，3 -美妆，4 -居家日用，5 -鞋品，6 -美食，7 -文娱车品，8 -数码家电，9 -男装，10 -内衣，11 -箱包，12 -配饰，13 -户外运动，14 -家装家纺
        /// </summary>
        public int? cid { get; set; }
    }
}
