/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Explosive_Goods_ListRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-12-24 10:15:29 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// DTK_Explosive_Goods_ListRequest
    /// </summary>
    public class DTK_Explosive_Goods_ListRequest : CommonGoodRequestParam
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v1.0.0";

        /// <summary>
        /// 分页id：常规分页方式，请直接传入对应页码（比如：1,2,3……）
        /// </summary>
        public string pageId { get; set; } = "1";

        /// <summary>
        /// 每页返回条数，每页条数支持输入10,20，50,100。默认50条
        /// </summary>
        public int? pageSize { get; set; }

        /// <summary>
        /// 价格区间，1表示10~20元区；2表示20~40元区；3表示40元以上区；默认为1
        /// </summary>
        public int? PriceCid { get; set; }

        /// <summary>
        /// 大淘客的一级分类id，如果需要传多个，以英文逗号相隔，如：”1,2,3”。1 -女装，2 -母婴，3 -美妆，4 -居家日用，5 -鞋品，6 -美食，7 -文娱车品，8 -数码家电，9 -男装，10 -内衣，11 -箱包，12 -配饰，13 -户外运动，14 -家装家纺。不填默认全部
        /// </summary>
        public string cids { get; set; }
    }
}
