/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Topic_GoodListResult.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:10:16 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// 精选专辑商品列表
    /// </summary>
    public class DTK_Topic_GoodListResult
    {
        public List<TopicGoodItem> list { get; set; }
        public int totalNum { get; set; }
        public string pageId { get; set; }
    }

    public class TopicGoodItem : GoodInfoBase
    {
    }
}
