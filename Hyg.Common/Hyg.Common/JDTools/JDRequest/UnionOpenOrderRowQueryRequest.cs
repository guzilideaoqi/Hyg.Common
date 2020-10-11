/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : UnionOpenOrderRowQueryRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-11 11:14:42 
备注说明 : 订单行查询请求参数

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools.JDRequest
{
    /// <summary>
    /// 订单行查询请求参数
    /// </summary>
    public class UnionOpenOrderRowQueryRequest
    {
        public UnionOpenOrderRowQueryDetailRequest orderReq { get; set; }
    }

    /// <summary>
    /// 订单行查询请求参数
    /// </summary>
    public class UnionOpenOrderRowQueryDetailRequest
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int pageIndex { get; set; } = 1;

        /// <summary>
        /// 每页包含条数，上限为500
        /// </summary>
        public int pageSize { get; set; } = 20;

        /// <summary>
        /// 订单时间查询类型(1：下单时间，2：完成时间（购买用户确认收货时间），3：更新时间
        /// </summary>
        public int type { get; set; } = 1;

        /// <summary>
        /// 开始时间 格式yyyy-MM-dd HH:mm:ss，与endTime间隔不超过1小时
        /// </summary>
        public string startTime { get; set; } = DateTime.Now.AddHours(-1).ToString("yyyy-MM-dd HH:mm:ss");

        /// <summary>
        /// 结束时间 格式yyyy-MM-dd HH:mm:ss，与startTime间隔不超过1小时
        /// </summary>
        public string endTime { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        /// <summary>
        /// 子推客unionID，传入该值可查询子推客的订单明细。（需要联系运营开通PID权限才能拿到数据，注意childUnionid和key不能同时传入）
        /// </summary>
        public long? childUnionId { get; set; }

        /// <summary>
        /// 工具商查询其他推客订单时，需传入该推客的授权key。推客可从以下网址获取自己的授权key：https://union.jd.com/myTools/myApi （注意childUnionid和key不能同时传入）
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// 支持出参数据筛选，逗号','分隔，目前可用：goodsInfo（商品信息）,categoryInfo(类目信息）
        /// </summary>
        public string fields { get; set; }
    }
}
