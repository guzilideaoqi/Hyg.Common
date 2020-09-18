/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_TB_Service_GoodResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:03:00 
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
    /// 联盟搜索
    /// </summary>
    public class DTK_TB_Service_GoodResponse : CommonResponseBase
    {
        public List<DTK_TB_Service_GoodItem> data { get; set; }
    }
}
