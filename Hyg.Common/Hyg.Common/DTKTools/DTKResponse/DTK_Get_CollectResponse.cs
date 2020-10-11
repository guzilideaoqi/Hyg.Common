/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Get_CollectResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-11 15:36:20 
备注说明 : 商品收藏返回值

 =====================================End=======================================================*/
using Hyg.Common.DTKTools.DTKModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKResponse
{
    /// <summary>
    /// 商品收藏返回值
    /// </summary>
    public class DTK_Get_CollectResponse : CommonResponseBase
    {
        public DTK_Collect_GoodResult data { get; set; }
    }
}
