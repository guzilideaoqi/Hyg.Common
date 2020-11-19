/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_WeApp_Qrcode_UrlRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 16:21:33 
备注说明 : 多多客生成单品推广小程序二维码url--请求参数

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 多多客生成单品推广小程序二维码url--请求参数
    /// </summary>
    public class Super_WeApp_Qrcode_UrlRequest: Custom_ParamterEntity
    {
        /// <summary>
        /// 是否生成店铺收藏券推广链接
        /// </summary>
        public bool generate_mall_collect_coupon { get; set; }

        /// <summary>
        /// 商品ID，仅支持单个查询
        /// </summary>
        public List<long> goods_id_list { get; set; }

        /// <summary>
        /// 推广位ID
        /// </summary>
        public string p_id { get; set; }

        /// <summary>
        /// 招商多多客ID
        /// </summary>
        public long zs_duo_id { get; set; }

        /// <summary>
        /// 直播间id列表，如果生成直播间推广链接该参数必填，goods_id_list填[1]
        /// </summary>
        public string[] room_id_list { get; set; }

        /// <summary>
        /// 直播预约id列表，如果生成直播间预约推广链接该参数必填，goods_id_list填[1]，room_id_list不填
        /// </summary>
        public string[] target_id_list { get; set; }
    }
}
