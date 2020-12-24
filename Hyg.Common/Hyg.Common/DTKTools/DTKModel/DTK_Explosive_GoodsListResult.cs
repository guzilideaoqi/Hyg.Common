/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Explosive_Goods_ListResult.cs
创建人员 : Mr.Hu
创建时间 : 2020-12-24 10:19:25 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// DTK_Explosive_GoodsListResult
    /// </summary>
    public class DTK_Explosive_GoodsListResult
    {
        public List<DTK_Explosive_GoodsItem> list { get; set; }
        public int totalNum { get; set; }
        public string pageId { get; set; }
    }

    public class DTK_Explosive_GoodsItem : GoodInfoBase
    { }
}
