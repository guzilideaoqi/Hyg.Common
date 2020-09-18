/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_TB_Topic_ListRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:17:45 
备注说明 : 官方活动推广

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// 官方活动推广
    /// </summary>
    public class DTK_TB_Topic_ListRequest
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v1.2.0";
        /// <summary>
        /// 分页id
        /// </summary>
        public string pageId { get; set; }
        /// <summary>
        /// 每页显示条数
        /// </summary>
        public int pageSize { get; set; }
        /// <summary>
        /// 输出的端口类型：0.全部（默认），1.PC，2.无线
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 渠道ID 阿里妈妈上申请的渠道id
        /// </summary>
        public long channelID { get; set; }
    }
}
