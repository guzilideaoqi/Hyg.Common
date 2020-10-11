/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_LiveMaterialGoodResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-11 16:20:01 
备注说明 : 直播好货接口返回

 =====================================End=======================================================*/
using Hyg.Common.DTKTools.DTKModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKResponse
{
    /// <summary>
    /// 直播好货接口返回
    /// </summary>
    public class DTK_LiveMaterialGoodResponse: CommonResponseBase
    {
        public DTK_LiveMaterialGoodResult data { get; set; }
    }
}
