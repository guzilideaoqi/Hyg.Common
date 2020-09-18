/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Super_CategoryResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:59:31 
备注说明 : 超级分类

 =====================================End=======================================================*/
using Hyg.Common.DTKTools.DTKModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKResponse
{
    /// <summary>
    /// 超级分类
    /// </summary>
    public class DTK_Super_CategoryResponse : CommonResponseBase
    {
        public List<CategoryItem> data { get; set; }
    }
}
