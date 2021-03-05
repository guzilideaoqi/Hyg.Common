/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_TB_ActivityLinkRequest.cs
创建人员 : Mr.Hu
创建时间 : 2021-03-05 17:22:47 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// 大淘客-淘宝活动转链
    /// </summary>
    public class DTK_TB_ActivityLinkRequest
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string version { get; set; } = "v1.0.0";

        /// <summary>
        /// 联盟官方活动ID，从联盟官方活动页获取或从大淘客官方活动推广接口获取
        /// </summary>
        public string promotionSceneId { get; set; }

        /// <summary>
        /// 推广pid
        /// </summary>
        public string pid { get; set; }

        /// <summary>
        /// 渠道id将会和传入的pid进行验证，验证通过将正常转链，请确认填入的渠道id是正确的
        /// </summary>
        public string relationId { get; set; }

        /// <summary>
        /// 自定义输入串，英文和数字组成，长度不能大于12个字符，区分不同的推广渠道
        /// </summary>
        public string unionId { get; set; }
    }
}
