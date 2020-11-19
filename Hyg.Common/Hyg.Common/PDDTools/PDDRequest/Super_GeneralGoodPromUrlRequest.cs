/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_GeneralGoodPromUrl.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 9:35:34 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// Super_GeneralGoodPromUrl
    /// </summary>
    public class Super_GeneralGoodPromUrlRequest : GeneralPromUrlParam_BaseEntity
    {
        /// <summary>
        /// 是否使用多多客专属推广计划
        /// </summary>
        public bool force_duo_id { get; set; }
    }
}
