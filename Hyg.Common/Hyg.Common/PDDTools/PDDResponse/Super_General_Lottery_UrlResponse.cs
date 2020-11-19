/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Super_General_Lottery_UrlResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-27 14:16:28 
备注说明 : 多多客工具生成转盘抽免单url--返回参数

 =====================================End=======================================================*/
using Hyg.Common.PDDTools.PDDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    /// <summary>
    /// 多多客工具生成转盘抽免单url--返回参数
    /// </summary>
    public class Super_General_Lottery_UrlResponse
    {
        public Lottery_url_response lottery_url_response { get; set; }
    }

    public class Lottery_url_response {
        public int total { get; set; }
        public List<Lottery_Prom_Url> url_list { get; set; }
    }

    public class Lottery_Prom_Url : Prom_UrlEntity {
        /// <summary>
        /// schema的链接
        /// </summary>
        public string schema_url { get; set; }
    }
}
