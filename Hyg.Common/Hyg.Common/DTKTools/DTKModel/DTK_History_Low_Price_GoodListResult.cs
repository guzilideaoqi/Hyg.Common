/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_History_Low_Price_GoodListResult.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-07 10:29:33 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// DTK_History_Low_Price_GoodListResult
    /// </summary>
    public class DTK_History_Low_Price_GoodListResult
    {
        public List<ActivityGoodItem> list { get; set; }
        public int totalNum { get; set; }
        public string pageId { get; set; }
    }

    public class DTK_History_Low_PriceGoodItem : GoodInfoBase
    { }
}
