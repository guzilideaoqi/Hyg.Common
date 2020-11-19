/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : HaoDanKu_GetOrienteeringItemsResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-23 10:12:52 
备注说明 : 定向计划商品API

 =====================================End=======================================================*/
using Hyg.Common.HaoDanKu.HaoDanKuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.HaoDanKu.HaoDanKuResponse
{
    /// <summary>
    /// 定向计划商品API
    /// </summary>
    public class HaoDanKu_GetOrienteeringItemsResponse: HaoDanKuCommonResponseBase
    {
        public List<HaoDanKu_GetOrienteeringItemEntity> data { get; set; }
    }
}
