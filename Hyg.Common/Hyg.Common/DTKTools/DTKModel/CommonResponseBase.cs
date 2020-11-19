/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : CommonResponseBase.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 9:38:56 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// 通用返回信息基类
    /// </summary>
    public class CommonResponseBase
    {
        /// <summary>
        /// 请求时间
        /// </summary>
        public long time { get; set; }
        /// <summary>
        /// 错误编号 0正常   -1服务器错误、稍后尝试访问  1参数错误，请根据msg提示信息进行修改  10007参数错误，开始时间必须小于或等于结束时间
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 接口返回消息
        /// </summary>
        public string msg { get; set; }

        /// <summary>
        /// 公用商品信息列表
        /// </summary>
        public List<CommonGoodInfoEntity> CommonGoodInfoList { get; set; }
    }
}
