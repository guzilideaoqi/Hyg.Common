/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_OrderItem.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 16:11:59 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// DTK_OrderItem
    /// </summary>
    public class DTK_OrderItem
    {
        /// <summary>
        /// 订单在淘宝拍下付款的时间
        /// </summary>
        public string tb_paid_time { get; set; }

        /// <summary>
        /// 订单付款的时间，该时间同步淘宝，可能会略晚于买家在淘宝的订单创建时间
        /// </summary>
        public string tk_paid_time { get; set; }

        /// <summary>
        /// 买家确认收货的付款金额（不包含运费金额）
        /// </summary>
        public string pay_price { get; set; }

        /// <summary>
        /// 结算预估收入=结算金额×提成。以买家确认收货的付款金额为基数，预估您可能获得的收入。因买家退款、您违规推广等原因，可能与您最终收入不一致。最终收入以月结后您实际收到的为准
        /// </summary>
        public string pub_share_fee { get; set; }

        /// <summary>
        /// 买家通过购物车购买的每个商品对应的订单编号，此订单编号并未在淘宝买家后台透出
        /// </summary>
        public string trade_id { get; set; }
        /// <summary>
        /// 二方：佣金收益的第一归属者； 三方：从其他淘宝客佣金中进行分成的推广者
        /// </summary>
        public string tk_order_role { get; set; }

        /// <summary>
        /// 订单确认收货后且商家完成佣金支付的时间
        /// </summary>
        public string tk_earning_time { get; set; }

        /// <summary>
        /// 推广位管理下的推广位名称对应的ID，同时也是pid=mm_1_2_3中的“3”这段数字
        /// </summary>
        public string adzone_id { get; set; }

        /// <summary>
        /// 从结算佣金中分得的收益比率
        /// </summary>
        public string pub_share_rate { get; set; }

        /// <summary>
        /// 维权标签，0 含义为非维权 1 含义为维权订单
        /// </summary>
        public int refund_tag { get; set; }

        /// <summary>
        /// 平台给与的补贴比率，如天猫、淘宝、聚划算等
        /// </summary>
        public string subsidy_rate { get; set; }

        /// <summary>
        /// 提成=收入比率×分成比率。指实际获得收益的比率
        /// </summary>
        public string tk_total_rate { get; set; }

        /// <summary>
        /// 商品所属的根类目，即一级类目的名称
        /// </summary>
        public string item_category_name { get; set; }

        /// <summary>
        /// 掌柜旺旺
        /// </summary>
        public string seller_nick { get; set; }

        /// <summary>
        /// 推广者会员ID
        /// </summary>
        public long pub_id { get; set; }

        /// <summary>
        /// 推广者赚取佣金后支付给阿里妈妈的技术服务费用的比率
        /// </summary>
        public string alimama_rate { get; set; }

        /// <summary>
        /// 平台出资方，如天猫、淘宝、或聚划算等
        /// </summary>
        public string subsidy_type { get; set; }
        
        /// <summary>
        /// 商品图片
        /// </summary>
        public string item_img { get; set; }

        /// <summary>
        /// 付款预估收入=付款金额×提成。指买家付款金额为基数，预估您可能获得的收入。因买家退款等原因，可能与结算预估收入不一致
        /// </summary>
        public string pub_share_pre_fee { get; set; }

        /// <summary>
        /// 买家拍下付款的金额（不包含运费金额）
        /// </summary>
        public decimal alipay_total_price { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        public string item_title { get; set; }

        /// <summary>
        /// 媒体管理下的对应ID的自定义名称
        /// </summary>
        public string site_name { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        public int item_num { get; set; }

        /// <summary>
        /// 补贴金额=结算金额×补贴比率
        /// </summary>
        public string subsidy_fee { get; set; }

        /// <summary>
        /// 技术服务费=结算金额×收入比率×技术服务费率。推广者赚取佣金后支付给阿里妈妈的技术服务费用
        /// </summary>
        public string alimama_share_fee { get; set; }

        /// <summary>
        /// 买家在淘宝后台显示的订单编号
        /// </summary>
        public string trade_parent_id { get; set; }

        /// <summary>
        /// 订单所属平台类型，包括天猫、淘宝、聚划算等
        /// </summary>
        public string order_type { get; set; }

        /// <summary>
        /// 订单创建的时间，该时间同步淘宝，可能会略晚于买家在淘宝的订单创建时间
        /// </summary>
        public string tk_create_time { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        public string flow_source { get; set; }

        /// <summary>
        /// 成交平台
        /// </summary>
        public string terminal_type { get; set; }

        /// <summary>
        /// 通过推广链接达到商品、店铺详情页的点击时间
        /// </summary>
        public string click_time { get; set; }

        /// <summary>
        /// 已付款：指订单已付款，但还未确认收货 已收货：指订单已确认收货，但商家佣金未支付 已结算：指订单已确认收货，且商家佣金已支付成功 已失效：指订单关闭/订单佣金小于0.01元，订单关闭主要有：1）买家超时未付款； 2）买家付款前，买家/卖家取消了订单；3）订单付款后发起售中退款成功；3：订单结算，12：订单付款， 13：订单失效，14：订单成功
        /// </summary>
        public int tk_status { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        public string item_price { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public string item_id { get; set; }

        /// <summary>
        /// 推广位管理下的自定义推广位名称
        /// </summary>
        public string adzone_name { get; set; }

        /// <summary>
        /// 佣金比率
        /// </summary>
        public string total_commission_rate { get; set; }

        /// <summary>
        /// 商品链接
        /// </summary>
        public string item_link { get; set; }

        /// <summary>
        /// 媒体管理下的ID，同时也是pid=mm_1_2_3中的“2”这段数字
        /// </summary>
        public string site_id { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string seller_shop_title { get; set; }

        /// <summary>
        /// 订单结算的佣金比率+平台的补贴比率
        /// </summary>
        public string income_rate { get; set; }

        /// <summary>
        /// 佣金金额=结算金额＊佣金比率
        /// </summary>
        public string total_commission_fee { get; set; }

        /// <summary>
        /// 预估内容专项服务费：内容场景专项技术服务费，内容推广者在内容场景进行推广需要支付给阿里妈妈专项的技术服务费用。专项服务费＝付款金额＊专项服务费率。
        /// </summary>
        public string tk_commission_pre_fee_for_media_platform { get; set; }

        /// <summary>
        /// 结算内容专项服务费：内容场景专项技术服务费，内容推广者在内容场景进行推广需要支付给阿里妈妈专项的技术服务费用。专项服务费＝结算金额＊专项服务费率。
        /// </summary>
        public string tk_commission_fee_for_media_platform { get; set; }

        /// <summary>
        /// 内容专项服务费率：内容场景专项技术服务费率，内容推广者在内容场景进行推广需要按结算金额支付一定比例给阿里妈妈作为内容场景专项技术服务费，用于提供与内容平台实现产品技术对接等服务。
        /// </summary>
        public string tk_commission_rate_for_media_platform { get; set; }

        /// <summary>
        /// 会员运营id
        /// </summary>
        public string special_id { get; set; }

        /// <summary>
        /// 渠道关系id
        /// </summary>
        public string relation_id { get; set; }

        /// <summary>
        /// 预售时期，用户对预售商品支付定金的付款时间，可能略晚于在淘宝付定金时间
        /// </summary>
        public string tk_deposit_time { get; set; }

        /// <summary>
        /// 预售时期，用户对预售商品支付定金的付款时间
        /// </summary>
        public string tb_deposit_time { get; set; }

        /// <summary>
        /// 预售时期，用户对预售商品支付的定金金额
        /// </summary>
        public string deposit_price { get; set; }

        /// <summary>
        /// 开发者调用api的appkey
        /// </summary>
        public string app_key { get; set; }

        /// <summary>
        /// 服务费信息
        /// </summary>
        public string service_fee_dto_list { get; set; }

        /// <summary>
        /// 专项服务费率
        /// </summary>
        public string share_relative_rate { get; set; }

        /// <summary>
        /// 结算专项服务费
        /// </summary>
        public string share_fee { get; set; }

        /// <summary>
        /// 预估专项服务费
        /// </summary>
        public string share_pre_fee { get; set; }

        /// <summary>
        /// 专项服务费来源
        /// </summary>
        public string tk_share_role_type { get; set; }
    }
}
