/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Super_GoodResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:01:58 
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
    /// DTK_Super_GoodResponse
    /// </summary>
    public class DTK_Super_GoodResponse : CommonResponseBase
    {
        public SuperGoodList data { get; set; }
    }
}
