/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_OP_ListRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:14:15 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// 9.9包邮精选
    /// </summary>
    public class DTK_OP_ListRequest : CommonGoodRequestParam
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v2.0.0";
        /// <summary>
        /// 每页显示的数量
        /// </summary>
        public int pageSize { get; set; }
        /// <summary>
        /// 分页id 常规分页方式，请直接传入对应页码
        /// </summary>
        public string pageId { get; set; }
        /// <summary>
        /// 精选类目Id
        /// </summary>
        public string nineCid { get; set; }
    }
}
