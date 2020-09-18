/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : CategoryItem.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:59:51 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// CategoryItem
    /// </summary>
    public class CategoryItem
    {
        /// <summary>
        /// 类别ID
        /// </summary>
        public long cid { get; set; }
        /// <summary>
        /// 类别名称
        /// </summary>
        public string cname { get; set; }
        /// <summary>
        /// 类别图片
        /// </summary>
        public string cpic { get; set; }
        /// <summary>
        /// 二级分类列表
        /// </summary>
        public List<SubCategoryList> subcategories { get; set; }
    }

    public class SubCategoryList
    {
        /// <summary>
        /// 子类别ID
        /// </summary>
        public long subcid { get; set; }
        /// <summary>
        /// 子类别名称
        /// </summary>
        public string subcname { get; set; }
        /// <summary>
        /// 子类别图片
        /// </summary>
        public string scpic { get; set; }
    }
}
