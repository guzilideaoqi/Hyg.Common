/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Activity_CatalogueResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:39:37 
备注说明 : 热门活动商品类

 =====================================End=======================================================*/
using Hyg.Common.DTKTools.DTKModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKResponse
{
    /// <summary>
    /// 热门活动商品类
    /// </summary>
    public class DTK_Activity_CatalogueResponse : CommonResponseBase
    {
        public List<ActivityCatalogueItem> data { get; set; }
    }
}
