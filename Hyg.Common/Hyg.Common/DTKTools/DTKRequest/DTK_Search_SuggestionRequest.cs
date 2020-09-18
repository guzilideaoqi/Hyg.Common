/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Search_SuggestionRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:15:41 
备注说明 : 联想词

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// 联想词
    /// </summary>
    public class DTK_Search_SuggestionRequest
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v1.0.2";
        /// <summary>
        /// 搜索关键词
        /// </summary>
        public string keyWords { get; set; }
        /// <summary>
        /// 当前搜索API类型：1.大淘客搜索 2.联盟搜索 3.超级搜索
        /// </summary>
        public int type { get; set; }
    }
}
