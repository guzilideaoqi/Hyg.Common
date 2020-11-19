/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : JD_Common_Two_ResponseBase.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-26 11:48:02 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDModel
{
    /// <summary>
    /// 公用返回结果--二级
    /// </summary>
    public class JD_Common_Two_ResponseBase
    {
        /// <summary>
        /// 错误码
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 请求id
        /// </summary>
        public string requestId { get; set; }
    }
}
