/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_GoodQueryDetailReq.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-26 9:44:28 
备注说明 : 

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
    public class Super_GoodQueryRequest
    {
        public Super_GoodQueryDetailReq goodsReqDTO { get; set; }
    }

    /// <summary>
    /// 超级商品查询接口
    /// </summary>
    public class Super_GoodQueryDetailReq
    {
        /// <summary>
        /// 一级类目id
        /// </summary>
        public long? cid1 { get; set; }

        /// <summary>
        /// 二级类目id
        /// </summary>
        public long? cid2 { get; set; }

        /// <summary>
        /// 三级类目id
        /// </summary>
        public long? cid3 { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public int? pageIndex { get; set; } = 1;

        /// <summary>
        /// 每页数量，单页数最大30，默认20
        /// </summary>
        public int? pageSize { get; set; } = 20;

        /// <summary>
        /// skuid集合(一次最多支持查询100个sku)，数组类型开发时记得加[]
        /// </summary>
        public long[] skuIds { get; set; }

        /// <summary>
        /// 关键词，字数同京东商品名称一致，目前未限制
        /// </summary>
        public string keyword { get; set; }

        /// <summary>
        /// 商品价格下限
        /// </summary>
        public decimal? pricefrom { get; set; }

        /// <summary>
        /// 商品价格上限
        /// </summary>
        public decimal? priceto { get; set; }

        /// <summary>
        /// 佣金比例最小区间
        /// </summary>
        public int? commissionShareStart { get; set; }

        /// <summary>
        /// 佣金比例区间结束
        /// </summary>
        public int? commissionShareEnd { get; set; }

        /// <summary>
        /// 商品类型：自营[g]，POP[p]
        /// </summary>
        public string owner { get; set; }

        /// <summary>
        /// 排序字段(price：单价, commissionShare：佣金比例, commission：佣金， inOrderCount30Days：30天引单量， inOrderComm30Days：30天支出佣金)
        /// </summary>
        public string sortName { get; set; }

        /// <summary>
        /// asc,desc升降序,默认降序
        /// </summary>
        public string sort { get; set; }

        /// <summary>
        /// 是否是优惠券商品，1：有优惠券，0：无优惠券
        /// </summary>
        public int? isCoupon { get; set; }

        /// <summary>
        /// 是否是拼购商品，1：拼购商品，0：非拼购商品
        /// </summary>
        public int? isPG { get; set; }

        /// <summary>
        /// 拼购价格区间开始
        /// </summary>
        public decimal? pingouPriceStart { get; set; }

        /// <summary>
        /// 拼购价格区间结束
        /// </summary>
        public decimal? pingouPriceEnd { get; set; }

        /// <summary>
        /// 品牌code
        /// </summary>
        public string brandCode { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        public int? shopId { get; set; }

        /// <summary>
        /// 1：查询内容商品；其他值过滤掉此入参条件。
        /// </summary>
        public int? hasContent { get; set; }

        /// <summary>
        /// 1：查询有最优惠券商品；其他值过滤掉此入参条件。
        /// </summary>
        public int? hasBestCoupon { get; set; }

        /// <summary>
        /// 联盟id_应用iD_推广位id
        /// </summary>
        public string pid { get; set; }

        /// <summary>
        /// 支持出参数据筛选，逗号','分隔，目前可用：videoInfo(视频信息),hotWords(热词),similar(相似推荐商品),documentInfo(段子信息),bookInfo(图书信息),specInfo(扩展信息)
        /// </summary>
        public string fields { get; set; }

        /// <summary>
        /// 10微信京东购物小程序禁售，11微信京喜小程序禁售
        /// </summary>
        public string forbidTypes { get; set; }

        /// <summary>
        /// 京喜商品类型，1京喜、2京喜工厂直供、3京喜优选（包含3时可在京东APP购买），入参多个值表示或条件查询
        /// </summary>
        public int[] jxFlags { get; set; }

        /// <summary>
        /// 支持传入0.0、2.5、3.0、3.5、4.0、4.5、4.9，默认为空表示不筛选评分
        /// </summary>
        public decimal? shopLevelFrom { get; set; }

        /// <summary>
        /// 京东配送 1：是，0：不是
        /// </summary>
        public int? deliveryType { get; set; }

        /// <summary>
        /// 图书编号
        /// </summary>
        public string isbn { get; set; }
    }
}
