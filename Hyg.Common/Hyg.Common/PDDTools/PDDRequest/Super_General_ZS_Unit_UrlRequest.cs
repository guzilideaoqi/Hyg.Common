/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_General_ZS_Unit_UrlRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 13:59:16 
备注说明 : 生成招商推广链接--请求参数

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 生成招商推广链接--请求参数
    /// </summary>
    public class Super_General_ZS_Unit_UrlRequest: Custom_ParamterEntity
    {
        /// <summary>
        /// 是否返回 schema URL
        /// </summary>
        public bool generate_schema_url { get; set; }

        /// <summary>
        /// 渠道id
        /// </summary>
        public string pid { get; set; }

        /// <summary>
        /// 需转链的链接
        /// </summary>
        public string source_url { get; set; }
    }
}
