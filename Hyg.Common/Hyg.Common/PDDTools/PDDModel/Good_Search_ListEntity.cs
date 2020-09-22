/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Good_Search_ListEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-22 18:41:51 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{
    /// <summary>
    /// Good_Search_ListEntity
    /// </summary>
    public class Good_Search_ListEntity
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        public List<Good_Search_Item> goods_list { get; set; }

        /// <summary>
        /// 翻页时必填前页返回的list_id值
        /// </summary>
        public string list_id { get; set; }

        /// <summary>
        /// 搜索id，建议生成推广链接时候填写，提高收益
        /// </summary>
        public string search_id { get; set; }

        /// <summary>
        /// 返回商品总数
        /// </summary>
        public int total_count { get; set; }
    }

    public class Good_Search_Item : Good_BaseEntity {

    }
}
