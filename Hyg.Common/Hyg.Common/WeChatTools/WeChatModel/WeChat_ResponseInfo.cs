/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : WeChat_ResponseInfo.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 16:39:42 
备注说明 : Hook统一返回消息

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// Hook统一返回消息
    /// </summary>
    public class WeChat_ResponseInfo
    {
        /// <summary>
        /// 微信数据
        /// </summary>
        public object data { get; set; }

        /// <summary>
        /// 消息返回编码
        /// </summary>
        public int type { get; set; }
    }
}
