/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Ranking_ListResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:55:44 
备注说明 : 各大榜单

 =====================================End=======================================================*/
using Hyg.Common.DTKTools.DTKModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKResponse
{
    /// <summary>
    /// 各大榜单
    /// </summary>
    public class DTK_Ranking_ListResponse : CommonResponseBase
    {
        public List<RankingItem> data { get; set; }
    }
}
