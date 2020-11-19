/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_Query_Good_DetailResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-11-19 15:16:44 
备注说明 : 订单详情返回信息

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// 订单详情返回信息
    /// </summary>
    public class Super_Query_Good_DetailResponse
    {
        public GoodDetailData goods_detail_response { get; set; }
    }

    public class GoodDetailData
    {
        public List<PDD_GoodDetailItem> goods_details { get; set; }
    }

    public class PDD_GoodDetailItem : Good_BaseEntity
    {

    }
}
