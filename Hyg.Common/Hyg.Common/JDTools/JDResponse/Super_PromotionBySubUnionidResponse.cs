/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_PromotionBySubUnionidResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-26 14:03:10 
备注说明 : 社交媒体获取推广链接接口【申请】--转链结果

 =====================================End=======================================================*/
using Hyg.Common.JDTools.JDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDResponse
{
    /// <summary>
    /// 社交媒体获取推广链接接口【申请】--转链结果
    /// </summary>
    public class Super_PromotionBySubUnionidResponse
    {
        public Jd_union_open_promotion_bysubunionid_get_response jd_union_open_promotion_bysubunionid_get_response { get; set; }
    }

    public class Jd_union_open_promotion_bysubunionid_get_response : JD_Common_First_ResponseBase { }

    public class Super_PromotionBySubUnionidDetailResponse : JD_Common_Two_ResponseBase
    {
        public ConvertLinkResultEntity data { get; set; }
    }
}
