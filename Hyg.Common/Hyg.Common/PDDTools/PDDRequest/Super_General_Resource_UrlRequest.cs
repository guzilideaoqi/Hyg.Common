/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_General_Resource_UrlRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 14:57:52 
备注说明 : 拼多多主站频道推广接口--请求参数

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 拼多多主站频道推广接口--请求参数
    /// </summary>
    public class Super_General_Resource_UrlRequest : Custom_ParamterEntity
    {
        /// <summary>
        /// 是否生成小程序
        /// </summary>
        public bool generate_we_app { get; set; }

        /// <summary>
        /// 推广位
        /// </summary>
        public string pid { get; set; }

        /// <summary>
        /// 频道来源：4-限时秒杀,39997-充值中心, 39998-转链type，39999-电器城，39996-百亿补贴
        /// </summary>
        public int resource_type { get; set; }

        /// <summary>
        /// 原链接
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 是否返回 schema URL
        /// </summary>
        public bool generate_schema_url { get; set; }

        /// <summary>
        /// 是否生成qq小程序
        /// </summary>
        public bool generate_qq_app { get; set; }
    }
}
