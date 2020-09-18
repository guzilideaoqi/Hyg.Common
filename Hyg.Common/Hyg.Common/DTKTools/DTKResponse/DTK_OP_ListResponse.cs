/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_OP_ListResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:51:27 
备注说明 : 9.9包邮精选

 =====================================End=======================================================*/
using Hyg.Common.DTKTools.DTKModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKResponse
{
    /// <summary>
    /// 9.9包邮精选
    /// </summary>
    public class DTK_OP_ListResponse : CommonResponseBase
    {
        public OPGoodList data { get; set; }
    }
}
