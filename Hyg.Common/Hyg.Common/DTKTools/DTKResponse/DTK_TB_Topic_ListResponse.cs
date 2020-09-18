/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_TB_Topic_ListResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:06:05 
备注说明 : 官方活动推广

 =====================================End=======================================================*/
using Hyg.Common.DTKTools.DTKModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKResponse
{
    /// <summary>
    /// 官方活动推广
    /// </summary>
    public class DTK_TB_Topic_ListResponse:CommonResponseBase
    {
        public List<TB_TopicItem> data { get; set; }
    }
}
