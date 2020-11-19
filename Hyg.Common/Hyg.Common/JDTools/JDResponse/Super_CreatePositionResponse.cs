/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_CreatePositionResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-26 17:05:28 
备注说明 : 创建推广位返回结果

 =====================================End=======================================================*/
using Hyg.Common.JDTools.JDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDResponse
{
    /// <summary>
    /// 创建推广位返回结果
    /// </summary>
    public class Super_CreatePositionResponse
    {
        public Jd_union_open_position_create_response jd_union_open_position_create_response { get; set; }
    }

    public class Jd_union_open_position_create_response : JD_Common_First_ResponseBase { }

    public class Super_CreatePositionData : JD_Common_Two_ResponseBase
    {
        public Super_CreatePositionResult data { get; set; }
    }

    public class Super_CreatePositionResult
    {
        /// <summary>
        /// pid结果集
        /// </summary>
        public Dictionary<string, string> pid { get; set; }

        /// <summary>
        /// 推广位结果集合
        /// </summary>
        public Dictionary<string, string> resultList { get; set; }

        /// <summary>
        /// 站点ID
        /// </summary>
        public string siteId { get; set; }

        /// <summary>
        /// 站点类型 1.网站推广位2.APP推广位3.导购媒体推广位4.聊天工具推广位
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 联盟ID
        /// </summary>
        public long unionId { get; set; }
    }
}
