/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Pdd_TokenInfoResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-21 14:47:11 
备注说明 : 拼多多token返回信息

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// 拼多多token返回信息
    /// </summary>
    public class Pdd_TokenInfoResponse
    {
        /// <summary>
        /// 拼多多创建token信息
        /// </summary>
        public Pdd_TokenInfoEntity pop_auth_token_create_response { get; set; }

        /// <summary>
        /// 拼多多刷新token信息
        /// </summary>
        public Pdd_TokenInfoEntity pop_auth_token_refresh_response { get; set; }
    }
}
