/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_TB_ActivityLinkResponse.cs
创建人员 : Mr.Hu
创建时间 : 2021-03-05 17:33:42 
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
    /// DTK_TB_ActivityLinkResponse
    /// </summary>
    public class DTK_TB_ActivityLinkResponse: CommonResponseBase
    {
        public TB_ActivityLinkResult data { get; set; }
    }
}
