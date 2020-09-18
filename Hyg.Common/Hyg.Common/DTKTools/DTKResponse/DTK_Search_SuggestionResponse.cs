/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Search_SuggestionResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:58:17 
备注说明 : 联想词

 =====================================End=======================================================*/
using Hyg.Common.DTKTools.DTKModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKResponse
{
    /// <summary>
    /// 联想词
    /// </summary>
    public class DTK_Search_SuggestionResponse : CommonResponseBase
    {
        public List<SuggestionItem> data { get; set; }
    }
}
