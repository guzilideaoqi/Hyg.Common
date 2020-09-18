/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Topic_CatalogueResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:08:36 
备注说明 : 精选专辑

 =====================================End=======================================================*/
using Hyg.Common.DTKTools.DTKModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKResponse
{
    /// <summary>
    /// 精选专辑
    /// </summary>
    public class DTK_Topic_CatalogueResponse:CommonResponseBase
    {
        public List<TopicCatalogueItem> data { get; set; }
    }
}
