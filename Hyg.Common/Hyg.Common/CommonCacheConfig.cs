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
        public static Dictionary<string, List<ChatRoomInfoEntity>> chatRoomInfoList = new Dictionary<string, List<ChatRoomInfoEntity>>();

        /// <summary>
        /// 新好友队列
        /// </summary>
        public static Queue<NewFriendInfo> newFriendInfoList = new Queue<NewFriendInfo>();

        //图片列表(用于存储异步的图片接收)
        public static Dictionary<string, Recv_Image_MsgEntity> WeChat_ImageList = new Dictionary<string, Recv_Image_MsgEntity>();
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
        public const string dtk_api_host = "https://openapi.dataoke.com/";
        #endregion

        #region 京东账号配置
        /// <summary>
        /// 京东appkey
        /// </summary>
        public static string jd_appkey = "";
        /// <summary>
        /// 京东appsecret
        /// </summary>
        public static string jd_appsecret = "";
        /// <summary>
        /// 京东accesstoken
        /// </summary>
        public static string jd_accesstoken = "";
        /// <summary>
        /// 京东接口域名地址
        /// </summary>
        public const string jd_api_host = "https://router.jd.com/api";
        #endregion

        #region 拼多多账号配置
        /// <summary>
        /// 拼多多appkey
        /// </summary>
        public static string pdd_appkey = "";
        /// <summary>
        /// 拼多多appsecret
        /// </summary>
        public static string pdd_appsecret = "";
        /// <summary>
        /// 拼多多accesstoken
        /// </summary>
        public static string pdd_accesstoken = "";
        /// <summary>
        /// 拼多多接口域名地址
        /// </summary>
        public const string pdd_api_host = "http://gw-api.pinduoduo.com/api/router";
        #endregion

        #region 好单库配置
        /// <summary>
        /// 好单库apikey
        /// </summary>
        public static string haodanku_apikey = "";
        public const string haodanku_api_host = "https://v2.api.haodanku.com/";
        #endregion

        #region 京推推配置
        public const string jingtuitui_api_host = "http://japi.jingtuitui.com/";
        #endregion

        public static bool Log_Debug = false;//debug日志模式
    }
}
