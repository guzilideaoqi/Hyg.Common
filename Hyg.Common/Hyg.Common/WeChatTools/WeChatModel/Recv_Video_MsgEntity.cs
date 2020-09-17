/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Recv_Video_MsgEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:33:46 
备注说明 : 微信视频消息类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// 微信视频消息类
    /// </summary>
    public class Recv_Video_MsgEntity:BaseEntity
    {
        /// <summary>
        /// 消息加密文本
        /// </summary>
        public string raw_msg { get; set; }
        /// <summary>
        /// 视频地址
        /// </summary>
        public string video { get; set; }
        /// <summary>
        /// 视频首帧图片
        /// </summary>
        public string video_thumb { get; set; }
    }
}
