/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Good_Search_ListResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-22 18:45:53 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.Model;
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// Good_Search_ListResponse
    /// </summary>
    public class Good_Search_ListResponse
    {
       public Good_Search_ListEntity goods_search_response { get; set; }

        /// <summary>
        /// 公用商品信息
        /// </summary>
        public List<CommonGoodInfoEntity> CommonGoodInfoList { get; set; }
    }
}
