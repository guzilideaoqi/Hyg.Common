/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Goods_Promotion_Url_GenerateRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-21 16:47:21 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// Goods_Promotion_Url_GenerateRequest
    /// </summary>
    public class Goods_Promotion_Url_GenerateRequest: GeneralPromUrlParam_BaseEntity
    {
        /// <summary>
        /// 直播间id列表，如果生成直播间推广链接该参数必填，goods_id_list填[1]
        /// </summary>
        public string[] room_id_list { get; set; }

        /// <summary>
        /// 直播预约id列表，如果生成直播间预约推广链接该参数必填，goods_id_list填[1]，room_id_list不填
        /// </summary>
        public string[] target_id_list { get; set; }
    }
}
