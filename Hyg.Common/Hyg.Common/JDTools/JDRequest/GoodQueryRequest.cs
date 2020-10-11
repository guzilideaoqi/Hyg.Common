/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : GoodQueryRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-29 16:14:20 
备注说明 : 商品查询

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDRequest
{
    /// <summary>
    /// 商品查询
    /// </summary>
    public class GoodQueryRequest
    {
        public GoodQueryDetailReq goodsReq { get; set; }
    }

    public class GoodQueryDetailReq {
        /// <summary>
        /// 1-好券商品,2-精选卖场,10-9.9包邮,15-京东配送,22-实时热销榜,23-为你推荐,24-数码家电,25-超市,26-母婴玩具,27-家具日用,28-美妆穿搭,30-图书文具,31-今日必推,32-京东好物,33-京东秒杀,34-拼购商品,40-高收益榜,41-自营热卖榜,109-新品首发,110-自营,112-京东爆品,125-首购商品,129-高佣榜单,130-视频商品,153-历史最低价商品榜
        /// </summary>
        public int eliteId { get; set; }

        /// <summary>
        /// 页码，默认1
        /// </summary>
        public int pageIndex { get; set; } = 1;

        /// <summary>
        /// 每页数量，默认20，上限50，建议20
        /// </summary>
        public int pageSize { get; set; } = 20;

        /// <summary>
        /// 排序字段(price：单价, commissionShare：佣金比例, commission：佣金， inOrderCount30DaysSku：sku维度30天引单量，comments：评论数，goodComments：好评数)
        /// </summary>
        public string sortName { get; set; }

        /// <summary>
        /// asc,desc升降序,默认降序
        /// </summary>
        public string sort { get; set; }

        /// <summary>
        /// 联盟id_应用id_推广位id，三段式
        /// </summary>
        public string pid { get; set; }

        /// <summary>
        /// 支持出参数据筛选，逗号','分隔，目前可用：videoInfo,documentInfo
        /// </summary>
        public string fields { get; set; }

        /// <summary>
        /// 禁投类型集
        /// </summary>
        public string forbidTypes { get; set; }
    }
}
