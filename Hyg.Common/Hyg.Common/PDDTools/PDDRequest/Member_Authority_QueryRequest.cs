/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Member_Authority_QueryRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-22 16:05:36 
备注说明 : 查询是否绑定备案

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 查询是否绑定备案
    /// </summary>
    public class Member_Authority_QueryRequest
    {
        /// <summary>
        /// 推广位id
        /// </summary>
        public string pid { get; set; }

        /// <summary>
        /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为： {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key
        /// </summary>
        public string custom_parameters { get; set; }
    }
}
