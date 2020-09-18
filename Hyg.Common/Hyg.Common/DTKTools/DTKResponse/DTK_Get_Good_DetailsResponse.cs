/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Get_Good_DetailsResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:47:50 
备注说明 : 获取商品详情

 =====================================End=======================================================*/
using Hyg.Common.DTKTools.DTKModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKResponse
{
    /// <summary>
    /// 获取商品详情
    /// </summary>
    public class DTK_Get_Good_DetailsResponse : CommonResponseBase
    {
        public DTK_Good_DetailsItem data { get; set; }
    }
}
