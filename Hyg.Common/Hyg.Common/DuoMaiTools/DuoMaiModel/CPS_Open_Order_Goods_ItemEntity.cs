/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : CPS_Open_Order_Goods_ItemEntity.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-19 17:36:04 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DuoMaiTools.DuoMaiModel
{
    /// <summary>
    /// 订单中的商品详情
    /// </summary>
    public class CPS_Open_Order_Goods_ItemEntity
    {
        /// <summary>
        /// 商品类目，以实际商家平台结果为准
        /// </summary>
        public string goods_cate { get; set; }

        /// <summary>
        /// 商品类目名称，有可能是数字标识、文字说明，以实际商家平台结果为准
        /// </summary>
        public string goods_cate_name { get; set; }

        /// <summary>
        /// 商品编号
        /// </summary>
        public string goods_id { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string goods_name { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        public string goods_price { get; set; }

        /// <summary>
        /// 商品件数
        /// </summary>
        public string goods_ta { get; set; }

        /// <summary>
        /// 订单金额，例：1.00
        /// </summary>
        public decimal orders_price { get; set; }

        /// <summary>
        /// 商家平台原始订单状态描述，有可能是英文、中文、数值等，以实际结果为准。 与多麦联盟订单状态无对应关系
        /// </summary>
        public string order_status { get; set; }

        /// <summary>
        /// 预估站长佣金，非结算站长佣金，例：1.00
        /// </summary>
        public decimal order_commission { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string order_sn { get; set; }

        /// <summary>
        /// 父订单号/子订单号
        /// </summary>
        public string parent_order_sn { get; set; }

        /// <summary>
        /// 商品图片地址
        /// </summary>
        public string goods_img { get; set; }
    }
}
