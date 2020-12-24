/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Explosive_Goods_ListResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-12-24 10:18:26 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.DTKTools.DTKModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKResponse
{
    /// <summary>
    /// DTK_Explosive_Goods_ListResponse
    /// </summary>
    public class DTK_Explosive_Goods_ListResponse : CommonResponseBase
    {
        public DTK_Explosive_GoodsListResult data { get; set; }
    }
}
