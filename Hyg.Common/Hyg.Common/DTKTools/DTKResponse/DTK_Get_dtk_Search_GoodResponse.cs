/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Get_dtk_Search_GoodResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:43:41 
备注说明 : 获取大淘客商品

 =====================================End=======================================================*/
using Hyg.Common.DTKTools.DTKModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKResponse
{
    /// <summary>
    /// 获取大淘客商品
    /// </summary>
    public class DTK_Get_dtk_Search_GoodResponse: CommonResponseBase
    {
        public DTK_SearchGoodList data { get; set; }
    }
}
