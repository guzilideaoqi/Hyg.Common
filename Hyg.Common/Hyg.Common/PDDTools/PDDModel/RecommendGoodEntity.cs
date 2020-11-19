/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : RecommendGoodEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 11:52:12 
备注说明 : 运营频道商品

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{
    /// <summary>
    /// 运营频道商品
    /// </summary>
    public class RecommendGoodEntity: Good_BaseEntity
    {
        /// <summary>
        /// 分享描述
        /// </summary>
        public string share_desc { get; set; }
    }
}
