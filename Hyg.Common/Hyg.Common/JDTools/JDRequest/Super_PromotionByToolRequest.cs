/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_PromotionByToolRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-26 14:17:42 
备注说明 : 工具商获取推广链接接口【申请】--请求参数

 =====================================End=======================================================*/
using Hyg.Common.JDTools.JDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDRequest
{
    /// <summary>
    /// 工具商获取推广链接接口【申请】--请求参数
    /// </summary>
    public class Super_PromotionByToolRequest
    {
        public Super_PromotionByTool promotionCodeReq { get; set; }
    }

    public class Super_PromotionByTool : JD_ConvertLinkRequestBaseEntity
    {
        /// <summary>
        /// 转链类型，1：长链， 2 ：短链 ，3： 长链+短链，默认短链，短链有效期60天
        /// </summary>
        public int chainType { get; set; }

        /// <summary>
        /// 目标推客的联盟ID
        /// </summary>
        public string unionId { get; set; }
    }
}
