/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_LiveMaterialGoodTemplate.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-11 16:44:10 
备注说明 : 直播商品模板消息

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// 直播商品模板消息  
    /// 1、type=1 发送content
    /// 2、type=2 下载content对应地址的图片(url_content为null时有可能是gif)
    /// 3、type=3 下载content对应地址的视频
    /// </summary>
    public class DTK_LiveMaterialGoodTemplate
    {
        /// <summary>
        /// 条目ID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 类型  1=文本   2=图片   3=视频
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 带表情的文案内容(也可能是动图地址)
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 纯文本内容
        /// </summary>
        public string text_content { get; set; }

        /// <summary>
        /// 图片或视频地址
        /// </summary>
        public string url_content { get; set; }

        /// <summary>
        /// 视频缩略图地址
        /// </summary>
        public string thumb_url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool isEdit { get; set; }
    }
}
