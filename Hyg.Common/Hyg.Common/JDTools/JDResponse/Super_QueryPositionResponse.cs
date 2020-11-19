/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_QueryPositionResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-26 16:01:11 
备注说明 : 查询推广位返回结果

 =====================================End=======================================================*/
using Hyg.Common.JDTools.JDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDResponse
{
    /// <summary>
    /// 查询推广位返回结果
    /// </summary>
    public class Super_QueryPositionResponse
    {
        public Jd_union_open_position_query_response jd_union_open_position_query_response { get; set; }
    }

    public class Jd_union_open_position_query_response : JD_Common_First_ResponseBase { }

    public class Super_QueryPositionData: JD_Common_Two_ResponseBase {
        public Super_QueryPositionResultInfo data { get; set; }
    }

    public class Super_QueryPositionResultInfo {
        public int pageNo { get; set; }

        public int pageSize { get; set; }

        public List<JD_PositionInfoEntity> result { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        public int total { get; set; }
    }
}
