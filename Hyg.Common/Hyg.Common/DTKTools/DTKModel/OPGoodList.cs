/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : OPGoodList.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:52:02 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// 9.9包邮精选
    /// </summary>
    public class OPGoodList
    {
        public List<OPGoodItem> list { get; set; }
    }

    public class OPGoodItem : GoodInfoBase { }
}
