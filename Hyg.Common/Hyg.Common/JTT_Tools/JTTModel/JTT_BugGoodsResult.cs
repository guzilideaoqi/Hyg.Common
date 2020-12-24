/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : JTT_BugGoodsResult.cs
创建人员 : Mr.Hu
创建时间 : 2020-12-24 16:48:57 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JTT_Tools.JTTModel
{
    /// <summary>
    /// JTT_BugGoodsResult
    /// </summary>
    public class JTT_BugGoodsResult
    {
        public List<JTT_BugGoodsEntity> data { get; set; }
        public int current_page { get; set; }
        public int total_page { get; set; }
    }
}
