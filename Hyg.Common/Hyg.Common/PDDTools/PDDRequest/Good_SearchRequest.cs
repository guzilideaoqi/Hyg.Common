/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Good_SearchRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-22 17:34:07 
备注说明 : 商品查询请求参数

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 商品查询请求参数
    /// </summary>
    public class Good_SearchRequest
    {
        /// <summary>
        /// 商品活动标记数组，例：[4,7]，4-秒杀，7-百亿补贴，24-品牌高佣，20-行业精选，21-金牌商家，10044-潜力爆品，其他的值请忽略
        /// </summary>
        public int[] activity_tags { get; set; }

        /// <summary>
        /// 商品类目ID，使用pdd.goods.cats.get接口获取
        /// </summary>
        public long? cat_id { get; set; }

        /// <summary>
        /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为： {"uid":"11111","sid":"22222","new":1} ，其中 uid 为用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 为上下文信息标识，例如sessionId等，非必填。new字段标识是否是新用户，如果为新用户，uid请传入用户唯一标识，例如小程序的openid、app的设备号等（可自行加密）。该json字符串中也可以加入其他自定义的key。
        /// </summary>
        public string custom_parameters { get; set; }

        /// <summary>
        /// 【重要：2020年8月24号后将不再支持该功能，建议在keyword中使用短链代替】商品ID列表。例如：[123456,123]，当入参带有goods_id_list字段，将不会以opt_id、 cat_id、keyword维度筛选商品
        /// </summary>
        public string[] goods_id_list { get; set; }

        /// <summary>
        /// 是否为品牌商品
        /// </summary>
        public bool is_brand_goods { get; set; } = false;

        /// <summary>
        /// 关键词
        /// </summary>
        public string keyword { get; set; }

        /// <summary>
        /// 翻页时建议填写前页返回的list_id值
        /// </summary>
        public string list_id { get; set; }

        /// <summary>
        /// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店（未传为全部）
        /// </summary>
        public int merchant_type { get; set; }

        /// <summary>
        /// 商品标签类目ID，使用pdd.goods.opt.get获取
        /// </summary>
        public long opt_id { get; set; }

        /// <summary>
        /// 默认值1，商品分页数
        /// </summary>
        public int page { get; set; } = 1;

        /// <summary>
        /// 默认100，每页商品数量
        /// </summary>
        public int page_size { get; set; } = 100;

        /// <summary>
        /// 推广位id
        /// </summary>
        public string pid { get; set; }

        /// <summary>
        /// 筛选范围列表 样例：[{"range_id":0,"range_from":1,"range_to":1500},{"range_id":1,"range_from":1,"range_to":1500}]
        /// </summary>
        public List<RangeItem> range_list { get; set; }

        /// <summary>
        /// 排序方式:0-综合排序;1-按佣金比率升序;2-按佣金比例降序;3-按价格升序;4-按价格降序;5-按销量升序;6-按销量降序;7-优惠券金额排序升序;8-优惠券金额排序降序;9-券后价升序排序;10-券后价降序排序;11-按照加入多多进宝时间升序;12-按照加入多多进宝时间降序;13-按佣金金额升序排序;14-按佣金金额降序排序;15-店铺描述评分升序;16-店铺描述评分降序;17-店铺物流评分升序;18-店铺物流评分降序;19-店铺服务评分升序;20-店铺服务评分降序;27-描述评分击败同类店铺百分比升序，28-描述评分击败同类店铺百分比降序，29-物流评分击败同类店铺百分比升序，30-物流评分击败同类店铺百分比降序，31-服务评分击败同类店铺百分比升序，32-服务评分击败同类店铺百分比降序
        /// </summary>
        public int sort_type { get; set; }

        /// <summary>
        /// 是否只返回优惠券的商品，false返回所有商品，true只返回有优惠券的商品
        /// </summary>
        public bool with_coupon { get; set; } = false;
    }

    public class RangeItem {
        /// <summary>
        /// 区间的开始值
        /// </summary>
        public long range_from { get; set; }

        /// <summary>
        /// 0，最小成团价 1，券后价 2，佣金比例 3，优惠券价格 4，广告创建时间 5，销量 6，佣金金额 7，店铺描述分 8，店铺物流分 9，店铺服务分 10， 店铺描述分击败同行业百分比 11， 店铺物流分击败同行业百分比 12，店铺服务分击败同行业百分比 13，商品分 17 ，优惠券/最小团购价 18，过去两小时pv 19，过去两小时销量
        /// </summary>
        public int range_id { get; set; }

        /// <summary>
        /// 区间的结束值
        /// </summary>
        public long range_to { get; set; }
    }
}
