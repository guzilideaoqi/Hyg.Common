/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_LiveMaterialGoodRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-11 16:15:02 
备注说明 : 直播好货接口

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// 直播好货接口
    /// </summary>
    public class DTK_LiveMaterialGoodRequest
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v1.0.0";
        /// <summary>
        /// 选择某一天的直播商品数据，默认返回全部参与过直播，且未下架的商品。时间格式：2020-09-16
        /// </summary>
        public string date { get; set; }

        /// <summary>
        /// 排序方式，默认为0，0-综合排序，1-商品上架时间从高到低，2-销量从高到低，3-领券量从高到低，4-佣金比例从高到低，5-价格（券后价）从高到低，6-价格（券后价）从低到高
        /// </summary>
        public string sort { get; set; }
    }
}
