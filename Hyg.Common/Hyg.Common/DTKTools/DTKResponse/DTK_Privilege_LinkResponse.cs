/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Privilege_LinkResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:54:12 
备注说明 : 高效转链

 =====================================End=======================================================*/
using Hyg.Common.DTKTools.DTKModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKResponse
{
    /// <summary>
    /// 高效转链
    /// </summary>
    public class DTK_Privilege_LinkResponse : CommonResponseBase
    {
        public PrivilegeLinkResult data { get; set; }
    }
}
