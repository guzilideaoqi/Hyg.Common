/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : SendMessageEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 18:11:47 
备注说明 : 待发送消息保存实体

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// 待发送消息保存实体
    /// </summary>
    public class SendMessageEntity
    {
        /// <summary>
        /// 客户端ID(主要用来区分多微信)
        /// </summary>
        public uint dwClientID { get; set; }
        /// <summary>
        /// 消息接收者   有可能是群或个人
        /// </summary>
        public string to_wxid { get; set; }

        /// <summary>
        /// 发送消息@的人
        /// </summary>
        public string[] at_user_wxid { get; set; }

        private List<string> textList;
        /// <summary>
        /// 文本消息列表
        /// </summary>
        public List<string> TextList { get { if (textList == null) textList = new List<string>(); return textList; } set { textList = value; } }

        private List<string> imageList;
        /// <summary>
        /// 图片消息列表(存储的统一为本地路径)
        /// </summary>
        public List<string> ImageList { get { if (imageList == null) imageList = new List<string>(); return imageList; } set { imageList = value; } }

        private List<string> videoList;
        /// <summary>
        /// 视频消息列表(存储的统一为本地路径)
        /// </summary>
        public List<string> VideoList { get { if (videoList == null) videoList = new List<string>(); return videoList; } set { videoList = value; } }

        private List<string> fileList;
        /// <summary>
        /// 文件消息
        /// </summary>
        public List<string> FileList { get { if (fileList == null) fileList = new List<string>(); return fileList; } set { fileList = value; } }

        private List<CardInfoEntity> cardInfoList;
        /// <summary>
        /// 卡牌消息列表
        /// </summary>
        public List<CardInfoEntity> CardInfoList { get { if (cardInfoList == null) cardInfoList = new List<CardInfoEntity>(); return cardInfoList; } set { cardInfoList = value; } }

        /// <summary>
        /// 消息发送间隔时间
        /// </summary>
        public int StepTime { get; set; }

        /// <summary>
        /// 发送图片多少秒之后发送文案
        /// </summary>
        public int img_reply_waittime { get; set; }
    }
}
