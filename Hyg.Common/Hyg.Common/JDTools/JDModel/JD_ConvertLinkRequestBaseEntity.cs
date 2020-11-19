/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : JD_ConvertLinkRequestBaseEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-26 12:01:44 
备注说明 : 京东转链接请求基础类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDModel
{
    /// <summary>
    /// 京东转链接请求基础类
    /// </summary>
    public class JD_ConvertLinkRequestBaseEntity
    {
        /// <summary>
        /// 推广物料url，例如活动链接、商品链接等；不支持仅传入skuid
        /// </summary>
        public string materialId { get; set; }

        /// <summary>
        /// 子渠道标识，您可自定义传入字母、数字或下划线，最多支持80个字符，该参数会在订单行查询接口中展示（需申请权限，申请方法请见https://union.jd.com/helpcenter/13246-13247-46301）
        /// </summary>
        public string subUnionId { get; set; }

        /// <summary>
        /// 推广位ID
        /// </summary>
        public string positionId { get; set; }

        /// <summary>
        /// 联盟子推客身份标识（不能传入接口调用者自己的pid）
        /// </summary>
        public string pid { get; set; }

        /// <summary>
        /// 优惠券领取链接，在使用优惠券、商品二合一功能时入参，且materialId须为商品详情页链接
        /// </summary>
        public string couponUrl { get; set; }
    }
}
