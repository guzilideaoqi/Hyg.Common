/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_Query_Good_DetailRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-11-19 15:09:32 
备注说明 : 获取商品详情

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 获取商品详情
    /// </summary>
    public class Super_Query_Good_DetailRequest : Custom_ParamterEntity
    {
        /// <summary>
        /// 商品goodsSign，支持通过goods_sign查询商品。优先使用此字段进行查询
        /// </summary>
        public string goods_sign { get; set; }

        /// <summary>
        /// 商品ID，仅支持单个查询。例如：[123456]
        /// </summary>
        public string[] goods_id_list { get; set; }

        /// <summary>
        /// 推广位id
        /// </summary>
        public string pid { get; set; }

        /// <summary>
        /// 搜索id，建议填写，提高收益。来自pdd.ddk.goods.recommend.get、pdd.ddk.goods.search、pdd.ddk.top.goods.list.query等接口
        /// </summary>
        public string search_id { get; set; }

        /// <summary>
        /// 招商多多客ID
        /// </summary>
        public string zs_duo_id { get; set; }
    }
}
