/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Recv_Image_MsgEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:31:56 
备注说明 : 微信图片消息

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// 微信图片消息
    /// </summary>
    public class Recv_Image_MsgEntity : BaseEntity
    {
        /// <summary>
        /// 图片原图(未解析)
        /// </summary>
        public string image { get; set; }
        /// <summary>
        /// 图片缩略图(未解析)
        /// </summary>
        public string image_thumb { get; set; }
        /// <summary>
        /// 图片地址(解析之后的)
        /// </summary>
        public string image_url { get; set; }
        /// <summary>
        /// 图片原始文案
        /// </summary>
        public string raw_msg { get; set; }
    }
}
