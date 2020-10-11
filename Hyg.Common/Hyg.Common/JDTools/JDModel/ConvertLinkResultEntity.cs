/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : ConvertLinkResultEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-11 10:42:35 
备注说明 : 转链结果实体

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDModel
{
    /// <summary>
    /// 转链结果实体
    /// </summary>
    public class ConvertLinkResultEntity
    {
        /// <summary>
        /// 生成的目标推广链接，长期有效
        /// </summary>
        public string clickURL { get; set; }
    }
}
