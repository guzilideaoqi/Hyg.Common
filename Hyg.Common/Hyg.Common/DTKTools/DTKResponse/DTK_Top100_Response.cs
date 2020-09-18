/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Top100_Response.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:07:27 
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
    /// 热搜记录
    /// </summary>
    public class DTK_Top100_Response : CommonResponseBase
    {
        public Top100Data data { get; set; }
    }
}
