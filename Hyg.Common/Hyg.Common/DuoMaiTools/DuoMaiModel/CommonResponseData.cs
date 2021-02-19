/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : CommonResponseData.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-19 10:30:46 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DuoMaiTools.DuoMaiModel
{
    /// <summary>
    /// 多麦公用返回参数
    /// </summary>
    public class CommonResponseData
    {
        /// <summary>
        /// 0=成功
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// 分页数据
        /// </summary>
        public Pagination pagination { get; set; }

        /// <summary>
        /// 接口返回业务数据
        /// </summary>
        public object data { get; set; }
        /// <summary>
        /// 接口消息
        /// </summary>
        public string message { get; set; }
    }

    public class Pagination {
        public int page { get; set; }

        public int page_size { get; set; }

        public int total { get; set; }
    }
}
