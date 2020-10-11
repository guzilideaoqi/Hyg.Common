/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : ConvertLinkResultResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-11 10:44:44 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.JDTools.JDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDResponse
{

    public class ConvertLinkResponse
    {
        public ConvertLinkResultResponse jd_union_open_promotion_common_get_response { get; set; }
    }

    public class ConvertLinkResultResponse
    {
        public int code { get; set; }

        public string result { get; set; }
    }


    /// <summary>
    /// ConvertLinkResultResponse
    /// </summary>
    public class ConvertLinkResultDetailResponse
    {
        /// <summary>
        /// 返回码
        /// </summary>
        public int code { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        public string message { get; set; }

        public ConvertLinkResultEntity data { get; set; }
    }
}
