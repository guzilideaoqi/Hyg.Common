/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_Order_DataRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 17:42:29 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKRequest
{
    /// <summary>
    /// 订单请求实体类
    /// </summary>
    public class DTK_Order_DataRequest
    {
        public string version { get; set; } = "v1.0.0";

        /// <summary>
        /// 查询时间类型，1：按照订单淘客创建时间查询，2:按照订单淘客付款时间查询，3:按照订单淘客结算时间查询
        /// </summary>
        public int queryType { get; set; }

        /// <summary>
        /// 位点，除第一页之外，都需要传递；前端原样返回。
        /// </summary>
        public string positionIndex { get; set; }

        /// <summary>
        /// 页大小，默认20，1~100
        /// </summary>
        public int pageSize { get; set; } = 20;

        /// <summary>
        /// 推广者角色类型,2:二方，3:三方，不传，表示所有角色
        /// </summary>
        public int? memberType { get; set; }

        /// <summary>
        /// 淘客订单状态，12-付款，13-关闭，14-确认收货，3-结算成功;不传，表示所有状态
        /// </summary>
        public int? tkStatus { get; set; }

        /// <summary>
        /// 订单查询结束时间，订单开始时间至订单结束时间，中间时间段日常要求不超过3个小时，但如618、双11、年货节等大促期间预估时间段不可超过20分钟，超过会提示错误，调用时请务必注意时间段的选择，以保证亲能正常调用！ 时间格式：YYYY-MM-DD HH:MM:SS
        /// </summary>
        public string endTime { get; set; }

        /// <summary>
        /// 订单查询开始时间。时间格式：YYYY-MM-DD HH:MM:SS
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        /// 跳转类型，当向前或者向后翻页必须提供,-1: 向前翻页,1：向后翻页
        /// </summary>
        public int jumpType { get; set; }

        /// <summary>
        /// 第几页，默认1，1~100
        /// </summary>
        public int pageNo { get; set; } = 1;

        /// <summary>
        /// 场景订单场景类型，1:常规订单，2:渠道订单，3:会员运营订单，默认为1
        /// </summary>
        public int orderScene { get; set; } = 1;
    }
}
