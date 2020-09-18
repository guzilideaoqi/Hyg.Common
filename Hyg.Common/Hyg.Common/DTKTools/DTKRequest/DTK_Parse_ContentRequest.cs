/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Parse_ContentRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 14:32:07 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// DTK_Parse_ContentRequest
    /// </summary>
    public class DTK_Parse_ContentRequest
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v1.0.0";

        /// <summary>
        /// 需要解析的文案内容
        /// </summary>
        public string content { get; set; }
    }
}
