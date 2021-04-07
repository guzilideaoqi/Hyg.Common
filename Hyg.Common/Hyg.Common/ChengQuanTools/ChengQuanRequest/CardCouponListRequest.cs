/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : CardCouponListRequest.cs
创建人员 : Mr.Hu
创建时间 : 2021-04-06 15:38:12 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.ChengQuanTools.ChengQuanRequest
{
    /// <summary>
    /// CardCouponListRequest
    /// </summary>
    public class CardCouponListRequest
    {
        /// <summary>
        /// 用户唯一编码
        /// </summary>
        public string machine_code { get; set; }

        /// <summary>
        /// 代理商ID
        /// </summary>
        public string agent_id { get; set; }

        /// <summary>
        /// 毫秒级时间戳
        /// </summary>
        public string timestamp { get; set; }

        /// <summary>
        /// 签名参数
        /// </summary>
        public string sign { get; set; }
    }
}
