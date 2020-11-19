/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : HaoDanKuCommonResponseBase.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-23 10:06:11 
备注说明 : 好单库公用请求返回值

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.HaoDanKu.HaoDanKuModel
{
    /// <summary>
    /// 好单库公用请求返回值
    /// </summary>
    public class HaoDanKuCommonResponseBase
    {
        /// <summary>
        /// 状态码（200成功，0失败或没有数据返回）
        /// </summary>
        public int code { get; set; }

        /// <summary>
        /// 作为请求地址中获取下一页的参数值
        /// </summary>
        public int min_id { get; set; }

        /// <summary>
        /// 返回信息说明，SUCCESS代表成功获取，失败则有具体原因
        /// </summary>
        public string msg { get; set; }
    }
}
