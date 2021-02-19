/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : CPS_Open_StoresEntity.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-19 16:41:20 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DuoMaiTools.DuoMaiModel
{
    /// <summary>
    /// CPS_Open_StoresEntity
    /// </summary>
    public class CPS_Open_StoresEntity
    {
        /// <summary>
        /// 商城id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 商城名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string en_name { get; set; }
        /// <summary>
        /// 商城logo图片地址
        /// </summary>
        public string logo { get; set; }
        /// <summary>
        /// 国家名称	
        /// </summary>
        public string country_name { get; set; }
        /// <summary>
        /// pc官网地址集合
        /// </summary>
        public List<string> pc_websites { get; set; }
        /// <summary>
        /// h5官网地址集合
        /// </summary>
        public List<string> mobile_websites { get; set; }
        /// <summary>
        /// 商城域名集合
        /// </summary>
        public List<string> domains { get; set; }
        /// <summary>
        /// 是否国内：-1非国内，1国内
        /// </summary>
        public int is_domestic { get; set; }
        /// <summary>
        /// 是否推荐：-1不推荐，1推荐
        /// </summary>
        public string recommend { get; set; }
        /// <summary>
        /// 商城描述
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 商城佣金说明
        /// </summary>
        public string commission { get; set; }
        /// <summary>
        /// 商城标签
        /// </summary>
        public List<tag_item> tags { get; set; }
    }

    public class tag_item
    {
        public int id { get; set; }
        public int type { get; set; }
        public string name { get; set; }
        public int sort { get; set; }
        public int platformId { get; set; }
        public string typeName { get; set; }
    }
}
