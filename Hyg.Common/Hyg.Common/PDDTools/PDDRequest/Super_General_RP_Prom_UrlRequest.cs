/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_General_RP_Prom_UrlRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 15:21:36 
备注说明 : 生成营销工具推广链接--请求参数

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 生成营销工具推广链接--请求参数
    /// </summary>
    public class Super_General_RP_Prom_UrlRequest: Custom_ParamterEntity
    {
        /// <summary>
        /// -1-活动列表，0-默认红包，2–新人红包，3-刮刮卡，5-员工内购，6-购物车，7-大促会场，8-直播间列表集合页，10-生成绑定备案链接
        /// </summary>
        public int channel_type { get; set; }

        /// <summary>
        /// 转盘自定义参数
        /// </summary>
        public Diy_lottery_param diy_lottery_param { get; set; }

        /// <summary>
        /// 红包自定义参数
        /// </summary>
        public Diy_red_packet_param diy_red_packet_param { get; set; }

        /// <summary>
        /// 是否生成qq小程序
        /// </summary>
        public bool generate_qq_app { get; set; }

        /// <summary>
        /// 是否返回 schema URL
        /// </summary>
        public bool generate_schema_url { get; set; }

        /// <summary>
        /// 是否生成短链接。true-是，false-否，默认false
        /// </summary>
        public bool generate_short_url { get; set; }

        /// <summary>
        /// 是否生成小程序推广
        /// </summary>
        public bool generate_we_app { get; set; }

        /// <summary>
        /// 推广位列表，例如：["60005_612"]
        /// </summary>
        public string[] p_id_list { get; set; }

        /// <summary>
        /// 初始金额（单位分），有效金额枚举值：300、500、700、1100和1600，默认300
        /// </summary>
        public long amount { get; set; } = 300;
    }

    public class Diy_lottery_param {
        /// <summary>
        /// 优先展示类目
        /// </summary>
        public int opt_id { get; set; }

        /// <summary>
        /// 自定义价格和商品佣金区间
        /// </summary>
        public Range_ItemEntity[] range_items { get; set; }
    }

    public class Diy_red_packet_param {
        /// <summary>
        /// 红包金额列表，200、300、500、1000、2000，单位分。红包金额和红包抵后价设置只能二选一，默认设置了红包金额会忽略红包抵后价设置
        /// </summary>
        public long[] amount_probability { get; set; }

        /// <summary>
        /// 设置玩法，false-现金红包, true-现金券
        /// </summary>
        public bool dis_text { get; set; }

        /// <summary>
        /// 推广页设置，false-红包开启页, true-红包领取页
        /// </summary>
        public bool not_show_background { get; set; }

        /// <summary>
        /// 优先展示类目
        /// </summary>
        public int opt_id { get; set; }

        /// <summary>
        /// 自定义红包抵后价和商品佣金区间对象数组
        /// </summary>
        public Range_ItemEntity[] range_items { get; set; }
    }
}
