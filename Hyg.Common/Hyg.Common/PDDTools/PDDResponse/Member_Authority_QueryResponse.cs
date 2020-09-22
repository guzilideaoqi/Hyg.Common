/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Member_Authority_QueryResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-22 16:05:03 
备注说明 : 查询是否绑定备案

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// 查询是否绑定备案
    /// </summary>
    public class Member_Authority_QueryResponse
    {
        public Member_Authority_QueryEntity authority_query_response { get; set; }
    }
}
