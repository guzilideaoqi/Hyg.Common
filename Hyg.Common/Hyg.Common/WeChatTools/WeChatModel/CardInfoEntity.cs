/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : CardInfoEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:39:13 
备注说明 : 微信卡片消息构造类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    /// <summary>
    /// 微信卡片消息构造类
    /// </summary>
    public class CardInfoEntity
    {
        /// <summary>
        /// 卡牌标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 卡牌描述
        /// </summary>
        public string des { get; set; }
        /// <summary>
        /// 卡牌缩略图
        /// </summary>
        public string thumburl { get; set; }
        /// <summary>
        /// 卡牌跳转地址
        /// </summary>
        public string url { get; set; }
    }
}
