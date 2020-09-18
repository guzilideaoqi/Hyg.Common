/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : SuperGoodList.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:01:11 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// SuperGoodList
    /// </summary>
    public class SuperGoodList
    {
        public List<SuperGoodItem> list { get; set; }
    }

    public class SuperGoodItem : GoodInfoBase
    { }
}
