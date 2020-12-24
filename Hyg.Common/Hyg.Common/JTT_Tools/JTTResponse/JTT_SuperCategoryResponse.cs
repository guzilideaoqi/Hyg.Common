/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : JTT_SuperCategoryResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-12-24 14:03:06 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.DTKTools.DTKModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JTT_Tools.JTTResponse
{
    /// <summary>
    /// 京推推超级分类返回数据
    /// </summary>
    public class JTT_SuperCategoryResponse : JTT_CommonResponse
    {
        public JTT_SuperCategoryData result { get; set; }
    }

    /// <summary>
    /// 分类数据
    /// </summary>
    public class JTT_SuperCategoryData
    {
        public List<CategoryItem> data { get; set; }
    }
}
