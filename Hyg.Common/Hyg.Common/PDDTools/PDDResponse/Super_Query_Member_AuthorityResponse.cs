/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_Query_Member_AuthorityResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 14:42:55 
备注说明 : 查询是否绑定备案--返回参数

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// 查询是否绑定备案--返回参数
    /// </summary>
    public class Super_Query_Member_AuthorityResponse
    {
        public Authority_query_response authority_query_response { get; set; }
    }

    public class Authority_query_response {
        /// <summary>
        /// 1-已绑定；0-未绑定
        /// </summary>
        public int bind { get; set; }
    }
}
