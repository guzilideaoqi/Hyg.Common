/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : JD_OrderBaseEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-11 13:43:20 
备注说明 : 京东订单信息

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDModel
{
    /// <summary>
    /// 京东订单信息
    /// </summary>
    public class JD_OrderBaseEntity
    {
        /// <summary>
        /// 标记唯一订单行：订单+sku维度的唯一标识
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string orderId { get; set; }

        /// <summary>
        /// 父单的订单号：如某个订单因为仓储物流或其它原因拆成多笔订单时，拆分前的原订单号会作为父单号存储在该字段中，拆分出的新订单号作为子单号存储在orderid中，若未发生拆单，该字段为0
        /// </summary>
        public string parentId { get; set; }

        /// <summary>
        /// 下单时间,格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string orderTime { get; set; }

        /// <summary>
        /// 完成时间（购买用户确认收货时间）,格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string finishTime { get; set; }

        /// <summary>
        /// 更新时间,格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string modifyTime { get; set; }

        /// <summary>
        /// 下单设备 1.pc 2.无线
        /// </summary>
        public int orderEmt { get; set; }

        /// <summary>
        /// 下单用户是否为PLUS会员 0：否，1：是
        /// </summary>
        public int plus { get; set; }

        /// <summary>
        /// 推客ID
        /// </summary>
        public string unionId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public string skuId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string skuName { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        public int skuNum { get; set; }

        /// <summary>
        /// 商品已退货数量
        /// </summary>
        public int skuReturnNum { get; set; }

        /// <summary>
        /// 商品售后中数量
        /// </summary>
        public int skuFrozenNum { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        public decimal price { get; set; }

        /// <summary>
        /// 佣金比例(投放的广告主计划比例)
        /// </summary>
        public decimal commissionRate { get; set; }

        /// <summary>
        /// 分成比例（单位：%）
        /// </summary>
        public decimal subSideRate { get; set; }

        /// <summary>
        /// 补贴比例（单位：%）
        /// </summary>
        public decimal subsidyRate { get; set; }

        /// <summary>
        /// 最终分佣比例（单位：%）=分成比例+补贴比例
        /// </summary>
        public decimal finalRate { get; set; }

        /// <summary>
        /// 预估计佣金额：由订单的实付金额拆分至每个商品的预估计佣金额，不包括运费，以及京券、东券、E卡等虚拟资产支付的金额，最终实际可用于计算佣金的金额以计佣金额为准
        /// </summary>
        public decimal estimateCosPrice { get; set; }

        /// <summary>
        /// 推客的预估佣金（预估计佣金额*佣金比例*最终比例），如订单完成前发生退款，此金额也会更新。
        /// </summary>
        public decimal estimateFee { get; set; }

        /// <summary>
        /// 实际计算佣金的金额。订单完成后，会将误扣除的运费券金额更正。如订单完成后发生退款，此金额会更新。
        /// </summary>
        public decimal actualCosPrice { get; set; }

        /// <summary>
        /// 推客分得的实际佣金（实际计佣金额*佣金比例*最终比例）。如订单完成后发生退款，此金额会更新。
        /// </summary>
        public decimal actualFee { get; set; }

        /// <summary>
        /// sku维度的有效码（-1：未知,2.无效-拆单,3.无效-取消,4.无效-京东帮帮主订单,5.无效-账号异常,6.无效-赠品类目不返佣,7.无效-校园订单,8.无效-企业订单,9.无效-团购订单,11.无效-乡村推广员下单,13.无效-违规订单,14.无效-来源与备案网址不符,15.待付款,16.已付款,17.已完成（购买用户确认收货）,18.已结算（5.9号不再支持结算状态回写展示））,20.无效-此复购订单对应的首购订单无效,21.无效-云店订单
        /// </summary>
        public int validCode { get; set; }

        /// <summary>
        /// 同跨店：2同店 3跨店
        /// </summary>
        public int traceType { get; set; }

        /// <summary>
        /// 推广位ID
        /// </summary>
        public string positionId { get; set; }

        /// <summary>
        /// 应用id（网站id、appid、社交媒体id）
        /// </summary>
        public string siteId { get; set; }

        /// <summary>
        /// PID所属母账号平台名称（原第三方服务商来源），两方分佣会有该值
        /// </summary>
        public string unionAlias { get; set; }

        /// <summary>
        /// 格式:子推客ID_子站长应用ID_子推客推广位ID
        /// </summary>
        public string pid { get; set; }

        /// <summary>
        /// 一级类目id
        /// </summary>
        public string cid1 { get; set; }

        /// <summary>
        /// 二级类目id
        /// </summary>
        public string cid2 { get; set; }

        /// <summary>
        /// 三级类目id
        /// </summary>
        public string cid3 { get; set; }

        /// <summary>
        /// 子渠道标识，在转链时可自定义传入，格式要求：字母、数字或下划线，最多支持80个字符(需要联系运营开放白名单才能拿到数据)
        /// </summary>
        public string subUnionId { get; set; }

        /// <summary>
        /// 联盟标签数据（整型的二进制字符串，返回32位：00000000000000000000000000000001。数据从右向左进行，每一位为1表示符合联盟的标签特征，第1位：红包，第2位：组合推广，第3位：拼购，第5位：有效首次购（0000000000011XXX表示有效首购，最终奖励活动结算金额会结合订单状态判断，以联盟后台对应活动效果数据报表https://union.jd.com/active为准）,第8位：复购订单，第9位：礼金，第10位：联盟礼金，第11位：推客礼金，第12位：京喜APP首购，第13位：京喜首购，第14位：京喜复购，第15位：京喜订单，第16位：京东极速版APP首购，第17位白条首购，第18位校园订单，例如：00000000000000000000000000000001:红包订单，00000000000000000000000000000010:组合推广订单，00000000000000000000000000000100:拼购订单，00000000000000000000000000011000:有效首购，00000000000000000000000000000111：红包+组合推广+拼购等）
        /// </summary>
        public string unionTag { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        public string popId { get; set; }

        /// <summary>
        /// 推客生成推广链接时传入的扩展字段（需要联系运营开放白名单才能拿到数据）。
        /// </summary>
        public string ext1 { get; set; }

        /// <summary>
        /// 预估结算时间，订单完成后才会返回，格式：yyyyMMdd，默认：0。表示最新的预估结算日期。当payMonth为当前的未来时间时，表示该订单可结算；当payMonth为当前的过去时间时，表示该订单已结算
        /// </summary>
        public string payMonth { get; set; }

        /// <summary>
        /// 招商团活动id
        /// </summary>
        public string cpActId { get; set; }

        /// <summary>
        /// 站长角色：1 推客 2 团长
        /// </summary>
        public int unionRole { get; set; }

        /// <summary>
        /// 礼金分摊金额
        /// </summary>
        public decimal giftCouponOcsAmount { get; set; }

        /// <summary>
        /// 礼金批次ID
        /// </summary>
        public string giftCouponKey { get; set; }

        /// <summary>
        /// 计佣扩展信息，表示结算月:每月实际佣金变化情况，格式：{20191020:10,20191120:-2}，注意：有完成时间的，才会有这个值
        /// </summary>
        public string balanceExt { get; set; }

        /// <summary>
        /// 数据签名，用来核对出参数据是否被修改，入参fields中写入sign时返回
        /// </summary>
        public string sign { get; set; }

        /// <summary>
        /// 价保赔付金额：订单申请价保或赔付的金额，实际计佣时会减去该金额后重新计算佣金，目前实际计佣金额已经减掉该金额
        /// </summary>
        public decimal proPriceAmount { get; set; }

        /// <summary>
        /// 团长渠道ID，仅限招商团长管理渠道使用，团长开通权限后才可使用
        /// </summary>
        public string rid { get; set; }

        /// <summary>
        /// 商品信息，入参传入fields，goodsInfo获取
        /// </summary>
        public JD_Order_GoodsInfo goodsInfo { get; set; }

        /// <summary>
        /// 类目信息,入参传入fields，categoryInfo获取
        /// </summary>
        public JD_Order_CategoryInfo categoryInfo { get; set; }
    }

    public class JD_Order_GoodsInfo {
        /// <summary>
        /// sku主图链接
        /// </summary>
        public string imageUrl { get; set; }

        /// <summary>
        /// g=自营，p=pop
        /// </summary>
        public string owner { get; set; }

        /// <summary>
        /// 自营商品主Id（owner=g取此值）
        /// </summary>
        public string mainSkuId { get; set; }

        /// <summary>
        /// 非自营商品主Id（owner=p取此值）
        /// </summary>
        public string productId { get; set; }

        /// <summary>
        /// 店铺名称（或供应商名称）
        /// </summary>
        public string shopName { get; set; }

        /// <summary>
        /// 店铺Id
        /// </summary>
        public string shopId { get; set; }
    }

    public class JD_Order_CategoryInfo {
        public string cid1 { get; set; }
        public string cid2 { get; set; }
        public string cid3 { get; set; }

        public string cid1Name { get; set; }
        public string cid2Name { get; set; }
        public string cid3Name { get; set; }
    }
}
