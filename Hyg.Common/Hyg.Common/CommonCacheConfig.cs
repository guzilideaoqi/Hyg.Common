/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : CommonCacheByHyg.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 15:41:28 
备注说明 : 公用类配置

 =====================================End=======================================================*/
using Hyg.Common.OtherTools;
using Hyg.Common.WeChatTools.WeChatModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common
{
    /// <summary>
    /// 缓存类配置
    /// </summary>
    public class CommonCacheConfig
    {
        #region 软件内部用户信息
        public static string token = "";
        #endregion

        #region 系统配置
        /// <summary>
        /// 随机时间实体
        /// </summary>
        public static RandomTimeEntity randomTimeEntity = new RandomTimeEntity();
        #endregion

        #region 微信工具类相关配置
        /// <summary>
        /// 配置过滤
        /// </summary>
        public static string[] filterList = new string[] { "qmessage", "medianote", "floatbottle", "tmessage", "weixin", "mphelper", "filehelper", "newsapp", "qqmail" };//"fmessage", 这个过滤条件去掉,否则自动同意加好友将失效
        /// <summary>
        /// 可登录微信数量
        /// </summary>
        public static int WeChatCount = 1;

        /// <summary>
        /// 当前已登录微信列表
        /// </summary>
        public static List<WeChat_UserInfo> Login_WeChat_UserInfo = new List<WeChat_UserInfo>();

        /// <summary>
        /// 存储多个微信的好友数据
        /// </summary>
        public static Dictionary<string, List<FriendInfoEntity>> AllFriendInfoList_Dic = new Dictionary<string, List<FriendInfoEntity>>();

        /// <summary>
        /// 微信群组列表
        /// </summary>
        public static List<ChatRoomInfoEntity> chatRoomInfoList = new List<ChatRoomInfoEntity>();

        /// <summary>
        /// 新好友队列
        /// </summary>
        public static Queue<NewFriendInfo> newFriendInfoList = new Queue<NewFriendInfo>();
        #endregion

        #region 大淘客账号配置
        /// <summary>
        /// 大淘客appkey
        /// </summary>
        public static string dtk_appkey = "";
        /// <summary>
        /// 大淘客appsecret
        /// </summary>
        public static string dtk_appsecret = "";
        /// <summary>
        /// 大淘客api域名地址
        /// </summary>
        public static string dtk_api_host = "https://openapi.dataoke.com/";
        #endregion
    }
}
