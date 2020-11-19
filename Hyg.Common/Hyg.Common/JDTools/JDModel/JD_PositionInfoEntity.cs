/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : JD_PositionInfoEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-26 15:46:17 
备注说明 : 京东推广位信息

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDModel
{
    /// <summary>
    /// 京东推广位信息
    /// </summary>
    public class JD_PositionInfoEntity
    {
        /// <summary>
        /// 推广位ID
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// 站点ID，如网站ID/appID/snsID
        /// </summary>
        public long siteId { get; set; }

        /// <summary>
        /// 推广位名称
        /// </summary>
        public string spaceName { get; set; }

        /// <summary>
        /// 站点类型 1.网站推广位2.APP推广位3.导购媒体推广位4.聊天工具推广位
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// pid：仅uniontype传4时，展示pid；可用于内容平台推广
        /// </summary>
        public string pid { get; set; }
    }
}
