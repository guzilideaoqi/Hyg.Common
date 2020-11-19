/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_Query_Member_AuthorityRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 14:41:07 
备注说明 : 查询是否绑定备案

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 查询是否绑定备案
    /// </summary>
    public class Super_Query_Member_AuthorityRequest: Custom_ParamterEntity
    {
        /// <summary>
        /// 推广位id
        /// </summary>
        public string pid { get; set; }
    }
}
