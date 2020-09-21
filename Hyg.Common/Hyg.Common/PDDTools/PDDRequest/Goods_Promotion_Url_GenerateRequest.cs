/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Goods_Promotion_Url_GenerateRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-21 16:47:21 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// Goods_Promotion_Url_GenerateRequest
    /// </summary>
    public class Goods_Promotion_Url_GenerateRequest
    {
        /// <summary>
        /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为：{"uid":"11111","sid":"22222"} ，其中 uid 为用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key。授权绑定备案支持优先对该自定义参数里面uid的解析绑定。
        /// </summary>
        public string custom_parameters { get; set; }

        /// <summary>
        /// 是否生成店铺收藏券推广链接
        /// </summary>
        public bool generate_mall_collect_coupon { get; set; } = false;

        /// <summary>
        /// 是否生成qq小程序
        /// </summary>
        public bool generate_qq_app { get; set; } = false;

        /// <summary>
        /// 是否返回 schema URL
        /// </summary>
        public bool generate_schema_url { get; set; } = false;

        /// <summary>
        /// 是否生成短链接，true-是，false-否
        /// </summary>
        public bool generate_short_url { get; set; } = true;

        /// <summary>
        /// 是否生成唤起微信客户端链接，true-是，false-否，默认false
        /// </summary>
        public bool generate_weapp_webview { get; set; } = false;

        /// <summary>
        /// 是否生成微博推广链接
        /// </summary>
        public bool generate_weiboapp_webview { get; set; } = false;

        /// <summary>
        /// 是否生成小程序推广
        /// </summary>
        public bool generate_we_app { get; set; } = false;

        /// <summary>
        /// 商品ID，仅支持单个查询
        /// </summary>
        public string[] goods_id_list { get; set; }

        /// <summary>
        /// true--生成多人团推广链接 false--生成单人团推广链接（默认false）1、单人团推广链接：用户访问单人团推广链接，可直接购买商品无需拼团。2、多人团推广链接：用户访问双人团推广链接开团，若用户分享给他人参团，则开团者和参团者的佣金均结算给推手
        /// </summary>
        public bool multi_group { get; set; } = false;

        /// <summary>
        /// 推广位ID
        /// </summary>
        public string p_id { get; set; }

        /// <summary>
        /// 搜索id，建议填写，提高收益。来自pdd.ddk.goods.recommend.get、pdd.ddk.goods.search、pdd.ddk.top.goods.list.query等接口
        /// </summary>
        public string search_id { get; set; }

        /// <summary>
        /// 招商多多客id
        /// </summary>
        public string zs_duo_id { get; set; }

        /// <summary>
        /// 直播间id列表，如果生成直播间推广链接该参数必填，goods_id_list填[1]
        /// </summary>
        public string[] room_id_list { get; set; }

        /// <summary>
        /// 直播预约id列表，如果生成直播间预约推广链接该参数必填，goods_id_list填[1]，room_id_list不填
        /// </summary>
        public string[] target_id_list { get; set; }

        /// <summary>
        /// 是否生成带授权的单品链接。如果未授权，则会走授权流程
        /// </summary>
        public bool generate_authority_url { get; set; } = true;
    }
}
