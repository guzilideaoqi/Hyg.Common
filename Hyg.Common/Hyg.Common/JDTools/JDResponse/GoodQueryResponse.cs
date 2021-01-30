/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : GoodQueryResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-29 16:24:43 
备注说明 : 京东商品查询返回数据

 =====================================End=======================================================*/
using Hyg.Common.JDTools.JDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDResponse
{
    /// <summary>
    /// 京东商品查询返回数据
    /// </summary>
    public class GoodQueryResponse
    {
        public Jd_union_open_goods_jingfen_query_response jd_union_open_goods_jingfen_query_response { get; set; }
    }


    public class Jd_union_open_goods_jingfen_query_response : JD_Common_First_ResponseBase { }

    public class Jd_GoodInfo_Reponse: JD_Common_Two_ResponseBase
    {
        public int totalCount { get; set; }
        public JFGoodsResp[] data { get; set; }

        public List<JFGoodsRespRow> jFGoodsRespRows { get; set; }
    }
    public class JFGoodsResp: JD_GoodBaseEntity
    {
        /// <summary>
        /// 资源信息
        /// </summary>
        public ResourceInfo resourceInfo { get; set; }
        public long inOrderCount30DaysSku { get; set; }
    }

    public class JFGoodsRespRow
    {
        /// <summary>
        /// 评论数量
        /// </summary>
        public long comments { get; set; }
        public long cid1 { get; set; }
        public string cid1Name { get; set; }
        public long cid2 { get; set; }
        public string cid2Name { get; set; }
        public long cid3 { get; set; }
        public string cid3Name { get; set; }
        /// <summary>
        /// 佣金信息
        /// </summary>
        public double commission { get; set; }
        /// <summary>
        /// 佣金比例
        /// </summary>
        public double commissionShare { get; set; }
        /// <summary>
        /// 券后佣金
        /// </summary>
        public double couponCommission { get; set; }
        /// <summary>
        /// 商品好评率
        /// </summary>
        public double goodCommentsShare { get; set; }
        /// <summary>
        /// 30天引单数量
        /// </summary>
        public long inOrderCount30Days { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        public string skuId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string skuName { get; set; }
        /// <summary>
        /// 店铺ID
        /// </summary>
        public string shopId { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string shopName { get; set; }
        /// <summary>
        /// 是否爆款，1：是，0：否
        /// </summary>
        public int isHot { get; set; }
        /// <summary>
        /// spuid，其值为同款商品的主skuid
        /// </summary>
        public long spuid { get; set; }
        /// <summary>
        /// 品牌code
        /// </summary>
        public string brandCode { get; set; }
        /// <summary>
        /// 品牌名
        /// </summary>
        public string brandName { get; set; }
        /// <summary>
        /// g=自营，p=pop
        /// </summary>
        public string owner { get; set; }
        public double price { get; set; }
        public long inOrderCount30DaysSku { get; set; }
        public string[] images { get; set; }
        public int bindType { get; set; }
        public double discount { get; set; }
        public string link { get; set; }
        public int platformType { get; set; }
        public double quota { get; set; }
        public long getStartTime { get; set; }
        public long getEndTime { get; set; }
        public long useStartTime { get; set; }
        public long useEndTime { get; set; }

        /// <summary>
        /// 用户等级佣金
        /// </summary>
        public decimal LevelCommission { get; set; }
        /// <summary>
        /// 最高级佣金
        /// </summary>
        public decimal SuperCommission { get; set; }
    }
    
    public class ResourceInfo
    {
        /// <summary>
        /// 频道id
        /// </summary>
        public int eliteId { get; set; }
        /// <summary>
        /// 频道名称
        /// </summary>
        public string eliteName { get; set; }
    }




}
