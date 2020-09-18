/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Parse_ContentResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 14:36:14 
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
    /// DTK_Parse_ContentResponse
    /// </summary>
    public class DTK_Parse_ContentResponse : CommonResponseBase
    {
        public ParseContent data { get; set; }
    }
}
