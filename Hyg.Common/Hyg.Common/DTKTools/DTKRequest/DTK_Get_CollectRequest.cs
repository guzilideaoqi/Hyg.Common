/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Get_CollectRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-11 15:27:03 
备注说明 : 我的收藏请求参数

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// 我的收藏请求参数
    /// </summary>
    public class DTK_Get_CollectRequest
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v1.0.1";

        /// <summary>
        /// 默认为1，支持传统的页码分页方式和scroll_id分页方式，根据用户自身需求传入值。示例1：商品入库，则首次传入1，后续传入接口返回的pageid，接口将持续返回符合条件的完整商品列表，该方式可以避免入口商品重复；示例2：根据pagesize和totalNum计算出总页数，按照需求返回指定页的商品（该方式可能在临近页取到重复商品）
        /// </summary>
        public string pageId { get; set; } = "1";

        /// <summary>
        /// 每页条数，默认为100，最大值200，若小于10，则按10条处理，每页条数仅支持输入10,50,100,200
        /// </summary>
        public string pageSize { get; set; } = "20";

        /// <summary>
        /// 商品在大淘客的一级分类id，如果需要传多个，以英文逗号相隔，如：”1,2,3”。当一级类目id和二级类目id同时传入时，会自动忽略二级类目id，1 -女装，2 -母婴，3 -美妆，4 -居家日用，5 -鞋品，6 -美食，7 -文娱车品，8 -数码家电，9 -男装，10 -内衣，11 -箱包，12 -配饰，13 -户外运动，14 -家装家纺
        /// </summary>
        public string cid { get; set; }

        /// <summary>
        /// 是否返回预告商品，1为预告商品，0为在线商品，不填则全部商品
        /// </summary>
        public int trailerType { get; set; }

        /// <summary>
        /// 排序字段，默认为0，0-综合排序，1-商品上架时间从高到低，2-销量从高到低，3-领券量从高到低，4-佣金比例从高到低，5-价格（券后价）从高到低，6-价格（券后价）从低到高
        /// </summary>
        public string sort { get; set; }

        /// <summary>
        /// 加入收藏时间
        /// </summary>
        public string collectionTimeOrder { get; set; }
    }
}
