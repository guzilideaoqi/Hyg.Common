/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Topic_GoodListResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:09:50 
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
    /// DTK_Topic_GoodListResponse
    /// </summary>
    public class DTK_Topic_GoodListResponse : CommonResponseBase
    {
        public DTK_Topic_GoodListResult data { get; set; }
    }
}
