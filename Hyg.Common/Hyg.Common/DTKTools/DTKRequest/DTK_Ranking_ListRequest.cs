/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Ranking_ListRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:15:18 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// 各大榜单
    /// </summary>
    public class DTK_Ranking_ListRequest: CommonGoodRequestParam
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v1.3.0";

        /// <summary>
        /// 1.实时榜 2.全天榜 3.热推榜 4.复购榜 5.热词飙升榜 6.热词排行榜 7.综合热搜榜
        /// </summary>
        public int rankType { get; set; }

        /// <summary>
        /// 仅对实时榜单、全天榜单有效
        /// </summary>
        public int cid { get; set; }
    }
}
