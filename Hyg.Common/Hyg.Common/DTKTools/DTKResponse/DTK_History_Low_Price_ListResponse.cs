/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_History_Low_Price_ListResponse.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-07 10:28:20 
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
    /// DTK_History_Low_Price_ListResponse
    /// </summary>
    public class DTK_History_Low_Price_ListResponse : CommonResponseBase
    {
        public DTK_History_Low_Price_GoodListResult data { get; set; }
    }
}
