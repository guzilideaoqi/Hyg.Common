/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Order_DataResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 17:38:19 
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
    /// DTK_Order_DataResponse
    /// </summary>
    public class DTK_Order_DataResponse:CommonResponseBase
    {
        public DTK_Order_DataPaging data { get; set; }
    }
}
