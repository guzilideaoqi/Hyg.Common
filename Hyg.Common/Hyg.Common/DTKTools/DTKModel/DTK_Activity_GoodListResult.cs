/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Activity_GoodListResult.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:41:49 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// DTK_Activity_GoodListResult
    /// </summary>
    public class DTK_Activity_GoodListResult
    {
        public List<ActivityGoodItem> list { get; set; }
        public int totalNum { get; set; }
        public string pageId { get; set; }
    }

    public class ActivityGoodItem : GoodInfoBase
    { }
}
