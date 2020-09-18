/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Super_GoodRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:16:45 
备注说明 : 超级搜索

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// 超级搜索
    /// </summary>
    public class DTK_Super_GoodRequest
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v1.3.0";
        /// <summary>
        /// 搜索类型 0-综合结果，1-大淘客商品，2-联盟商品
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 请求的页码，默认参数1
        /// </summary>
        public int pageId { get; set; }
        /// <summary>
        /// 每页条数
        /// </summary>
        public int pageSize { get; set; }
        /// <summary>
        /// 关键词搜索
        /// </summary>
        public string keyWords { get; set; }
        /// <summary>
        /// 是否天猫商品  1-天猫商品，0-所有商品，不填默认为0
        /// </summary>
        public int tmall { get; set; }
        /// <summary>
        /// 是否海淘商品	  1-海淘商品，0-所有商品，不填默认为0
        /// </summary>
        public int haitao { get; set; }
        /// <summary>
        /// 排序字段   排序字段信息 销量（total_sales） 价格（price），排序_des（降序），排序_asc（升序）
        /// </summary>
        public string sort { get; set; }
    }
}
