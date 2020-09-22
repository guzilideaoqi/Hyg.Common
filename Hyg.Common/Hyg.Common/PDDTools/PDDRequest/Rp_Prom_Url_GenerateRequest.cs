/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Rp_Prom_Url_GenerateRequest.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-22 16:22:44 
备注说明 : 生成营销工具推广链接

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDRequest
{
    /// <summary>
    /// 生成营销工具推广链接
    /// </summary>
    public class Rp_Prom_Url_GenerateRequest
    {
        /// <summary>
        /// -1-活动列表，0-默认红包，2–新人红包，3-刮刮卡，5-员工内购，6-购物车，7-大促会场，8-直播间列表集合页，10-生成绑定备案链接
        /// </summary>
        public int channel_type { get; set; }

        /// <summary>
        /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为：{"uid":"11111","sid":"22222"} ，其中 uid 为用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key。授权绑定备案支持优先对该自定义参数里面uid的解析绑定。
        /// </summary>
        public string custom_parameters { get; set; }

        /// <summary>
        /// 是否生成qq小程序
        /// </summary>
        public bool generate_qq_app { get; set; } = false;

        /// <summary>
        /// 是否返回 schema URL
        /// </summary>
        public bool generate_schema_url { get; set; } = false;

        /// <summary>
        /// 是否生成短链接。true-是，false-否，默认false
        /// </summary>
        public bool generate_short_url { get; set; } = false;

        /// <summary>
        /// 是否生成小程序推广
        /// </summary>
        public bool generate_we_app { get; set; } = false;

        /// <summary>
        /// 推广位列表，例如：["60005_612"]
        /// </summary>
        public string[] p_id_list { get; set; }
    }
}
