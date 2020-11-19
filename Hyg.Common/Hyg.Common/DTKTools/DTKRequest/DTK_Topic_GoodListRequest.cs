/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Topic_GoodListRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:19:09 
备注说明 : 精选专辑商品

 =====================================End=======================================================*/
using Hyg.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// 精选专辑商品
    /// </summary>
    public class DTK_Topic_GoodListRequest : CommonGoodRequestParam
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v1.2.2";
        /// <summary>
        /// 默认为1，支持传统的页码分页方式和scroll_id分页方式，后续传入接口第一次返回的pageid，
        /// </summary>
        public string pageId { get; set; }
        /// <summary>
        /// 每页显示数量
        /// </summary>
        public int pageSize { get; set; }
        /// <summary>
        /// 通过精选专辑API获取的活动id
        /// </summary>
        public int topicId { get; set; }
    }
}
