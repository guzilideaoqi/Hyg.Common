/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Custom_ParamterEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 11:45:38 
备注说明 : 自定义参数基类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{
    /// <summary>
    /// 自定义参数基类
    /// </summary>
    public class Custom_ParamterEntity
    {
        /// <summary>
        /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为： {"uid":"11111","sid":"22222","new":1} ，其中 uid 为用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 为上下文信息标识，例如sessionId等，非必填。new字段标识是否是新用户，如果为新用户，uid请传入用户唯一标识，例如小程序的openid、app的设备号等（可自行加密）。该json字符串中也可以加入其他自定义的key。
        /// </summary>
        public string custom_parameters { get; set; }
    }
}
