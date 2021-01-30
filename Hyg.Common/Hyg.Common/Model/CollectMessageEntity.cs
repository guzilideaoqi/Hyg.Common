/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : CollectMessageEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-12-05 11:04:15 
备注说明 : 采集的消息实体(包含淘宝口令商品、淘宝链接商品、京东链接商品、拼多多链接商品、普通文案、图片、视频、gif)

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.Model
{
    /// <summary>
    /// 采集消息实体类
    /// </summary>
    public class CollectMessageEntity
    {
        public string Xid { get; set; }
        /// <summary>
        /// 采集群ID
        /// </summary>
        public string CollectQunID { get; set; }
        /// <summary>
        /// 平台类型  1==淘宝  2==京东  3==拼多多  4==其他类型
        /// </summary>
        public CollectPlaformType PlaformType { get; set; }

        /// <summary>
        /// 消息类型 PlaformType不为4时都为文本消息  1==文本消息  2==图片消息  3==视频消息 4==gif消息
        /// </summary>
        public CollectMessageType MessageType { get; set; }

        /// <summary>
        /// 消息内容  MessageType==1：原始文本消息    MessageType==2：图片地址  MessageType==3：视频地址  MessageType==4：gif地址  
        /// </summary>
        public string MessageContent { get; set; }

        /// <summary>
        /// 采集商品列表(为了兼容多商品模式)
        /// </summary>
        public List<CollectGoodInfo> CollectGoodList { get; set; }

        /// <summary>
        /// 图片加密数据
        /// </summary>
        public ImageEncrptData imageencrptdata { get; set; }

        /// <summary>
        /// 微信原格式
        /// </summary>
        public string raw_msg { get; set; }
    }

    /// <summary>
    /// 采集到的商品信息
    /// </summary>
    public class CollectGoodInfo
    {
        /// <summary>
        /// 商品模式  1==ID模式   2==口令模式   3==链接模式
        /// </summary>
        public CollectGoodMode GoodModel { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public string ItemID { get; set; }

        /// <summary>
        /// 优惠券ID
        /// </summary>
        public string ActivityID { get; set; }

        /// <summary>
        /// 商品链接地址(存放的都是短链接)
        /// </summary>
        public string CollectGoodUrl { get; set; }

        /// <summary>
        /// 采集商品口令
        /// </summary>
        public string CollectGoodPwd { get; set; }
    }

    public enum CollectPlaformType
    {
        /// <summary>
        /// 淘宝
        /// </summary>
        TaoBao = 1,
        /// <summary>
        /// 京东
        /// </summary>
        JD = 2,
        /// <summary>
        /// 拼多多
        /// </summary>
        PDD = 3,
        /// <summary>
        /// 其他
        /// </summary>
        Other = 4
    }

    public enum CollectMessageType
    {
        /// <summary>
        /// 文本
        /// </summary>
        Text = 1,
        /// <summary>
        /// 图片
        /// </summary>
        Image = 2,
        /// <summary>
        /// 视频
        /// </summary>
        Video = 3,
        /// <summary>
        /// gif
        /// </summary>
        Gif = 4
    }

    public enum CollectGoodMode
    {
        /// <summary>
        /// 商品ID模式
        /// </summary>
        Mode_ID = 1,
        /// <summary>
        /// 口令模式
        /// </summary>
        Mode_Pwd = 2,
        /// <summary>
        /// 链接模式
        /// </summary>
        Mode_Link = 3
    }

    public class ImageEncrptData
    {
        public string aeskey { get; set; }
        public string encryver { get; set; }
        public string cdnthumbaeskey { get; set; }
        public string cdnthumburl { get; set; }
        public string cdnthumblength { get; set; }
        public string cdnthumbheight { get; set; }
        public string cdnthumbwidth { get; set; }
        public string cdnmidheight { get; set; }
        public string cdnmidwidth { get; set; }
        public string cdnhdheight { get; set; }
        public string cdnhdwidth { get; set; }
        public string cdnmidimgurl { get; set; }
        public string length { get; set; }
        public string md5 { get; set; }
    }
}
