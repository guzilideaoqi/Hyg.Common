/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Rp_Prom_Url_GenerateEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-22 16:32:09 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{
    /// <summary>
    /// Rp_Prom_Url_GenerateEntity
    /// </summary>
    public class Rp_Prom_Url_GenerateEntity
    {
        public List<Rp_Prom_Url_List> resource_list { get; set; }

        public List<Rp_Prom_Url_List_Item> url_list { get; set; }
    }


    public class Rp_Prom_Url_List
    {
        /// <summary>
        /// 活动描述
        /// </summary>
        public string desc { get; set; }

        public string url { get; set; }
    }

    public class Rp_Prom_Url_List_Item : GenerateLink_BaseEntity
    {
        public string schema_url { get; set; }

        /// <summary>
        /// qq小程序信息
        /// </summary>
        public QQ_app_info qq_app_info { get; set; }

        /// <summary>
        /// 小程序信息
        /// </summary>
        public We_app_info we_app_info { get; set; }
    }

}
