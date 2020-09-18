/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_SearchGoodList.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:45:42 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// 大淘客商品搜索结果
    /// </summary>
    public class DTK_SearchGoodList
    {
        public List<DTK_SearchGoodItem> list { get; set; }
    }

    public class DTK_SearchGoodItem : GoodInfoBase
    { }
}
