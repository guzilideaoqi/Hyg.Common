/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : originInfoEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 14:37:47 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// originInfoEntity
    /// </summary>
    public class ParseContent
    {
        /// <summary>
        /// 淘宝商品ID
        /// </summary>
        public string goodsId { get; set; }

        /// <summary>
        /// 二合一链接
        /// </summary>
        public string originUrl { get; set; }

        /// <summary>
        /// 链接中的信息类型
        /// </summary>
        public string originType { get; set; }

        public originInfoEntity originInfo { get; set; }
    }

    public class originInfoEntity {
        public string activityId { get; set; }
        /// <summary>
        /// 券金额
        /// </summary>
        public decimal amount { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string shopName { get; set; }

        /// <summary>
        /// 店铺logo
        /// </summary>
        public string shopLogo { get; set; }

        /// <summary>
        /// 商品主图
        /// </summary>
        public string image { get; set; }

        /// <summary>
        /// 优惠券开始时间
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        /// 优惠券结束时间
        /// </summary>
        public string endTime { get; set; }

        /// <summary>
        /// 券门槛金额
        /// </summary>
        public decimal startFee { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        public decimal price { get; set; }

        /// <summary>
        /// pid
        /// </summary>
        public string pid { get; set; }

        /// <summary>
        /// 券状态  0:可用; 非0:不可用
        /// </summary>
        public int status { get; set; }
    }
}
