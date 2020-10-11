/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : LiveMaterialGoodList.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-11 16:22:26 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// LiveMaterialGoodList
    /// </summary>
    public class DTK_LiveMaterialGoodResult
    {
        public List<DTK_LiveMaterialGood> list { get; set; }
        /// <summary>
        /// 总数量
        /// </summary>
        public int totalNum { get; set; }

        /// <summary>
        /// 页码ID
        /// </summary>
        public string pageId { get; set; }
    }
}
