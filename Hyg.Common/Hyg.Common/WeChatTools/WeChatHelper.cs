/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : WeChatHelper.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 14:53:35 
备注说明 : 微信操作类

 =====================================End=======================================================*/
using Hyg.Common.OtherTools;
using Hyg.Common.WeChatTools.WeChatModel;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Hyg.Common.WeChatTools
{
    /// <summary>
    /// 微信操作类
    /// 1、操作微信文件请放在系统根目录的dll里面
    /// 2、文件夹里面包含微信的运行目录
    /// </summary>
    public class WeChatHelper
    {
        WeChatParseHelper weChatParseHelper = new WeChatParseHelper();
        #region 微信消息回调
        /// <summary>
        /// 声明添加日志的委托事件
        /// </summary>
        /// <param name="s"></param>
        public delegate void AddLogsHandler(string s);

        // 基于上面的委托定义事件
        public event AddLogsHandler AddLogs;

        public delegate void CallBackWeChatMessageHandler(object WeChatMessage, uint dwClient);
        public event CallBackWeChatMessageHandler CallBackWeChatMessage;
        #endregion

        #region 微信操作类初始化信息
        public delegate void AcceptCallbackFunc(uint dwClientId);
        public delegate void RecvCallbackFunc(uint dwClientId, IntPtr intPtr, uint dwSize);
        public delegate void CloseCallbackFunc(uint dwClientId);
        private static AcceptCallbackFunc m_AcceptCallbackFunc;
        private static RecvCallbackFunc m_RecvCallbackFunc;
        private static CloseCallbackFunc m_CloseCallbackFunc;

        // 引入DLL导出函数
        [DllImport(@"dll\WxLoader.dll")]
        public static extern bool InitWeChatSocket(AcceptCallbackFunc acceptCallback,
            RecvCallbackFunc recvCallback, CloseCallbackFunc closeCallback);
        [DllImport(@"dll\WxLoader.dll")]
        public static extern uint InjectWeChat(String strDllPath);
        [DllImport(@"dll\WxLoader.dll")]
        public static extern bool SendWeChatData(uint dwClienId, String strJsonData);
        [DllImport(@"dll\WxLoader.dll")]
        public static extern bool DestroyWeChat();

        [DllImport(@"dll\WxLoader.dll")]
        public static extern bool UseUtf8();

        [DllImport(@"dll\WxLoader.dll")]
        public static extern bool UseRecvJsUnicode();

        // 存一个clientId，用于发送消息 （多客户端自己来维护clientId）
        public static uint WxClientId = 0;
        #endregion

        #region 初始化微信插件
        public void InitWeChat()
        {
            //UseUtf8();
            m_AcceptCallbackFunc = WxAcceptCallback;
            m_RecvCallbackFunc = WxRecvCallback;
            m_CloseCallbackFunc = WxCloseCallback;
            // 初始化Callback
            InitWeChatSocket(m_AcceptCallbackFunc, m_RecvCallbackFunc, m_CloseCallbackFunc);
            UseRecvJsUnicode();

            StartWeChat();//启动微信
        }
        #endregion

        #region 信息处理方法
        // 注入成功回调
        void WxAcceptCallback(uint dwClientId)
        {
            WxClientId = dwClientId;
        }
        // 接收消息回调
        void WxRecvCallback(uint dwClient, IntPtr intPtr, uint dwSize)
        {
            //if (CommonCacheConfig.Login_WeChat_UserInfo.Select(t => t.wx_clientid).Contains(dwClient) || CommonCacheConfig.Login_WeChat_UserInfo.Count >= CommonCacheConfig.WeChatCount)//防止漏洞双开多获取个微信的数据
            //    return;

            String recvData = Marshal.PtrToStringAnsi(intPtr);
            try
            {
                string new_RecvData = UnicodeHelper.DeUnicode(recvData);

                WeChat_ResponseInfo reponseInfo = JsonConvert.DeserializeObject<WeChat_ResponseInfo>(new_RecvData);
                MessageTypeEnum messageTypeEnum = (MessageTypeEnum)reponseInfo.type;

                string logText = "";

                switch (messageTypeEnum)
                {
                    case MessageTypeEnum.MT_DEBUG_LOG:
                        logText = "微信启动成功!";
                        break;
                    case MessageTypeEnum.MT_USER_LOGIN:
                        WeChat_UserInfo wXInfo = weChatParseHelper.ParseCurrentUserInfo(reponseInfo.data, dwClient);
                        CallBackWeChatMessage(wXInfo, dwClient);
                        logText = "【" + wXInfo.nickname + "】登录成功!";

                        #region 提交微信信息
                        //TaskHelper.ExcuteNewTask(() =>
                        //{
                        //    RequstDataOperate.SubmitWeChatInfo(wXInfo);
                        //}, 50);
                        #endregion

                        #region 获取当前微信未自动同意的好友信息
                        /*List<NewFriendInfo> newFriendInfoList = NewFriendService.GetNewFriendList(wXInfo.wxid);
                        if (newFriendInfoList.Count > 0)
                        {
                            logText += "当前有" + newFriendInfoList.Count + "个好友未执行自动同意!";

                            foreach (NewFriendInfo item in newFriendInfoList)
                            {
                                CommonCache.newFriendInfoList.Enqueue(item);
                            }
                        }*/
                        #endregion

                        #region 获取好友和群组消息
                        WeChatTools.GetFriendInfoList(dwClient);
                        WeChatTools.GetChatRoomInfoList(dwClient);
                        #endregion
                        break;
                    case MessageTypeEnum.MT_USER_LOGOUT:
                        LogoutWeChat logoutWeChat = reponseInfo.data.ToString().ToJsonObject<LogoutWeChat>();
                        CallBackWeChatMessage(logoutWeChat, dwClient);

                        WeChat_UserInfo exit_wXInfo = CommonCacheConfig.Login_WeChat_UserInfo.Where(t => t.wxid == logoutWeChat.wxid).FirstOrDefault();
                        if (!exit_wXInfo.IsEmpty())
                            CommonCacheConfig.Login_WeChat_UserInfo.Remove(exit_wXInfo);
                        break;
                    case MessageTypeEnum.MT_SQL_QUERY:
                        break;
                    case MessageTypeEnum.MT_DATA_OWNER_MSG:
                        break;
                    case MessageTypeEnum.MT_DATA_WXID_MSG:
                        break;
                    case MessageTypeEnum.MT_DATA_FRIENDS_MSG:
                        TaskHelper.ExcuteNewTask(() => { List<FriendInfoEntity> friendInfoList = weChatParseHelper.ParseCurrentFriendList(reponseInfo.data, dwClient.GetWxidByClientID()); CallBackWeChatMessage(friendInfoList, dwClient); }, 500);
                        break;
                    case MessageTypeEnum.MT_DATA_CHATROOMS_MSG:
                        TaskHelper.ExcuteNewTask(() => { List<ChatRoomInfoEntity> chatRoomInfoList = weChatParseHelper.ParseCurrentChatRoomList(reponseInfo.data, dwClient.GetWxidByClientID()); CallBackWeChatMessage(chatRoomInfoList, dwClient); }, 500);
                        break;
                    case MessageTypeEnum.MT_DATA_CHATROOM_MEMBERS_MSG:
                        TaskHelper.ExcuteNewTask(() =>
                        {
                            GroupMemberResponseEntity groupMemberResponseEntity = WeChatParseHelper.ConvertObjToModel<GroupMemberResponseEntity>(reponseInfo.data);
                            CallBackWeChatMessage(groupMemberResponseEntity, dwClient);
                            //GroupMemberService.BatchUpdateGroupMember(groupMemberResponseEntity);
                        }, 50);
                        break;
                    case MessageTypeEnum.MT_DATA_PUBLICS_MSG:
                        break;
                    case MessageTypeEnum.MT_UPDATE_WXID_MSG:
                        break;
                    case MessageTypeEnum.MT_UPDATE_ROOM_MEMBER_MSG:
                        break;
                    case MessageTypeEnum.MT_SEND_TEXTMSG:
                        break;
                    case MessageTypeEnum.MT_SEND_CHATROOM_ATMSG:
                        break;
                    case MessageTypeEnum.MT_SEND_CARDMSG:
                        break;
                    case MessageTypeEnum.MT_SEND_LINKMSG:
                        break;
                    case MessageTypeEnum.MT_SEND_IMGMSG:
                        break;
                    case MessageTypeEnum.MT_SEND_FILEMSG:
                        break;
                    case MessageTypeEnum.MT_SEND_VIDEOMSG:
                        break;
                    case MessageTypeEnum.MT_SEND_GIFMSG:
                        break;
                    case MessageTypeEnum.MT_RECV_TEXT_MSG:
                        Recv_Text_MsgEntity recv_Text_MsgEntity = weChatParseHelper.ParseRecvTextMsg(reponseInfo.data);
                        //logText = "消息文本->" + recv_Text_MsgEntity.from_wxid + "->" + recv_Text_MsgEntity.msg;

                        TaskHelper.ExcuteNewTask(() =>
                        {
                            if (!recv_Text_MsgEntity.from_wxid.IsSelf(dwClient) && !recv_Text_MsgEntity.from_wxid.FilterMessage())
                            {
                                CallBackWeChatMessage(recv_Text_MsgEntity, dwClient);
                            }
                        }, 20);
                        break;
                    case MessageTypeEnum.MT_RECV_PICTURE_MSG:
                        Recv_Image_MsgEntity recv_Image_MsgEntity = weChatParseHelper.ParseImageMsg(reponseInfo.data);
                        if (recv_Image_MsgEntity.from_wxid.IsSelf(dwClient))
                            return;
                        if (!CommonCacheConfig.WeChat_ImageList.ContainsKey(recv_Image_MsgEntity.image))
                        {
                            CommonCacheConfig.WeChat_ImageList.Add(recv_Image_MsgEntity.image, recv_Image_MsgEntity);
                            //间隔500毫秒下载图片
                            TaskHelper.ExcuteNewTask((() => { WeChatTools.SendDecryptImage(dwClient, recv_Image_MsgEntity.image); }), 500);
                        }
                        break;
                    case MessageTypeEnum.MT_RECV_VOICE_MSG:
                        //Recv_Video_MsgEntity recv_Video_MsgEntity = weChatParseHelper.ParseRecvVideo(reponseInfo.data);
                        //logText = "语音消息:" + recv_Video_MsgEntity.video;
                        break;
                    case MessageTypeEnum.MT_RECV_FRIEND_MSG:
                        NewFriendInfo newFriendInfo = weChatParseHelper.ParseAcceptFriend(reponseInfo.data);
                        newFriendInfo.sourcewxid = dwClient.GetWxidByClientID();//保存该条数据来源于哪条微信

                        CallBackWeChatMessage(newFriendInfo, dwClient);
                        //NewFriendService.AddNewFriend(newFriendInfo);
                        break;
                    case MessageTypeEnum.MT_RECV_CARD_MSG:
                        //SendAutoAddCard(dwClient, 1);
                        break;
                    case MessageTypeEnum.MT_RECV_VIDEO_MSG:
                        Recv_Video_MsgEntity recv_Video_MsgEntity = weChatParseHelper.ParseRecvVideo(reponseInfo.data);
                        if (recv_Video_MsgEntity.from_wxid.IsSelf(dwClient))
                            return;
                        TaskHelper.ExcuteNewTask((() =>
                        {
                            CallBackWeChatMessage(recv_Video_MsgEntity, dwClient);
                            /*string video_url = RequstDataOperate.UploadFile(recv_Video_MsgEntity.video);
                            logText = "视频地址:" + video_url;
                            recv_Video_MsgEntity.video = video_url;
                            #region 发送消息到客服
                            SocketHelper.SendCustomerMessage(recv_Video_MsgEntity, GetWxidByClientID(dwClient));
                            #endregion*/
                        }), 500);
                        break;
                    case MessageTypeEnum.MT_RECV_EMOJI_MSG:
                        Recv_Emoji_MsgEntity recv_Emoji_MsgEntity = weChatParseHelper.ParseRecvEmoji(reponseInfo.data);
                        if (!recv_Emoji_MsgEntity.IsEmpty())
                        {
                            if (recv_Emoji_MsgEntity.from_wxid.IsSelf(dwClient))
                                return;
                            CallBackWeChatMessage(recv_Emoji_MsgEntity, dwClient);
                        }

                        break;
                    case MessageTypeEnum.MT_RECV_LOCATION_MSG:
                        break;
                    case MessageTypeEnum.MT_RECV_LINK_MSG:
                        Recv_Text_MsgEntity recv_Text_MsgEntity_card = weChatParseHelper.ParseRecvTextMsg(reponseInfo.data);
                        if (recv_Text_MsgEntity_card.from_wxid.IsSelf(dwClient))
                            return;
                        TaskHelper.ExcuteNewTask(() =>
                        {
                            CardInfoEntity cardInfoEntity = weChatParseHelper.ParseRecvCard(reponseInfo.data);
                            recv_Text_MsgEntity_card.msg = cardInfoEntity.url;

                            CallBackWeChatMessage(recv_Text_MsgEntity_card, dwClient);

                            //MessageOperateHelper.OperateMessage(recv_Text_MsgEntity_card, dwClient, GetWxidByClientID(dwClient));
                            logText = "卡牌标题:" + cardInfoEntity.title;
                        }, 50);
                        break;
                    case MessageTypeEnum.MT_RECV_FILE_MSG:
                        Recv_File_MsgEntity recv_File_MsgEntity = weChatParseHelper.ParseFileMsg(reponseInfo.data);
                        if (recv_File_MsgEntity.from_wxid.IsSelf(dwClient))
                            return;
                        TaskHelper.ExcuteNewTask((() =>
                        {
                            //string file_url = RequstDataOperate.UploadFile(recv_File_MsgEntity.file);
                            //logText = "文件地址:" + file_url;
                            //recv_File_MsgEntity.file = file_url;
                            CallBackWeChatMessage(recv_File_MsgEntity, dwClient);
                        }), 500);
                        break;
                    case MessageTypeEnum.MT_RECV_MINIAPP_MSG:
                        break;
                    case MessageTypeEnum.MT_RECV_WCPAY_MSG:
                        break;
                    case MessageTypeEnum.MT_RECV_SYSTEM_MSG://接受系统消息(处理新人进群)
                        TaskHelper.ExcuteNewTask(() =>
                        {
                            Recv_System_MsgEntity recv_System_MsgEntity = JsonConvert.DeserializeObject<Recv_System_MsgEntity>(reponseInfo.data.ToString());
                            CallBackWeChatMessage(recv_System_MsgEntity, dwClient);
                            string raw_msg = recv_System_MsgEntity.raw_msg.Trim();
                            if (recv_System_MsgEntity.wx_type == 10000 && ((raw_msg.Contains("邀请") && raw_msg.Contains("加入了群聊")) || (raw_msg.Contains("通过扫描") && raw_msg.Contains("分享的二维码加入群聊"))))
                            {
                                //if (CommonCache.robot_BaseSettingEntity.base_info.in_qun_wmsg_switch == 1)
                                //{//开启欢迎新人进群
                                //    MessageOperateHelper.WelComePersonInChatRoom(recv_System_MsgEntity, dwClient);
                                //}

                                #region 只要有人进群就更新群成员信息
                                //CommonCache.weChatHelper.GetChatRoomInfoList(dwClient, recv_System_MsgEntity.room_wxid);
                                #endregion
                            }
                            else if (recv_System_MsgEntity.wx_type == 10000 && raw_msg.Contains("修改群名为"))
                            {
                                /*string chatRoomName = RegularHelper.getValue("(?<=“).*?(?=”)", raw_msg);
                                recv_System_MsgEntity.room_wxid*/
                            }
                            else if (raw_msg.Contains("拍了拍你"))
                            {
                                //MessageOperateHelper.PaiMessage(recv_System_MsgEntity, dwClient);
                            }
                            else if (raw_msg.StartsWith("你已添加了") && raw_msg.EndsWith("，现在可以开始聊天了。"))
                            {
                                //非自动同意状态下才用此回复
                                //if (!CommonCache.robot_BaseSettingEntity.add_friend_info.IsEmpty() && CommonCache.robot_BaseSettingEntity.add_friend_info.auto_pass_switch == 0 && CommonCache.robot_BaseSettingEntity.add_friend_info.hand_pass_switch == 1)
                                //{
                                //    MessageOperateHelper.SendWelcomeMessage(dwClient, 1, recv_System_MsgEntity.from_wxid, new Dictionary<string, string>());
                                //}
                            }
                        }, 50);
                        break;
                    case MessageTypeEnum.MT_RECV_REVOKE_MSG:
                        break;
                    case MessageTypeEnum.MT_RECV_OTHER_MSG:
                        break;
                    case MessageTypeEnum.MT_RECV_OTHER_APP_MSG:
                        break;
                    case MessageTypeEnum.MT_ADD_FRIEND_MSG:
                        break;
                    case MessageTypeEnum.MT_MOD_FRIEND_REMARK_MSG:
                        break;
                    case MessageTypeEnum.MT_DEL_FRIEND_MSG:
                        break;
                    case MessageTypeEnum.MT_ACCEPT_FRIEND_MSG:
                        break;
                    case MessageTypeEnum.MT_ACCEPT_WCPAY_MSG:
                        break;
                    case MessageTypeEnum.MT_ACCEPT_ROOM_MSG:
                        break;
                    case MessageTypeEnum.MT_CREATE_ROOM_MSG:
                        break;
                    case MessageTypeEnum.MT_INVITE_TO_ROOM_MSG:
                        break;
                    case MessageTypeEnum.MT_INVITE_TO_ROOM_REQ_MSG:
                        break;
                    case MessageTypeEnum.MT_DEL_ROOM_MEMBER_MSG:
                        break;
                    case MessageTypeEnum.MT_MOD_ROOM_NAME_MSG:
                        break;
                    case MessageTypeEnum.MT_MOD_ROOM_NOTICE_MSG:
                        break;
                    case MessageTypeEnum.MT_MOD_ROOM_MEMBER_NAME_MSG:
                        break;
                    case MessageTypeEnum.MT_MOD_ROOM_SHOW_NAME_MSG:
                        break;
                    case MessageTypeEnum.MT_SAVE_ROOM_TO_CONTACT_MSG:
                        break;
                    case MessageTypeEnum.MT_QUIT_DEL_ROOM_MSG:
                        break;
                    case MessageTypeEnum.MT_MOD_RECV_NOTIFY_MSG:
                        break;
                    case MessageTypeEnum.MT_MOD_CHAT_SESSION_TOP_MSG:
                        break;
                    case MessageTypeEnum.MT_ZOMBIE_CHECK_MSG:
                        break;
                    case MessageTypeEnum.MT_AUTO_ACCEPT_FRIEND_MSG:
                        break;
                    case MessageTypeEnum.MT_AUTO_ACCEPT_WCPAY_MSG:
                        break;
                    case MessageTypeEnum.MT_AUTO_ACCEPT_ROOM_MSG:
                        break;
                    case MessageTypeEnum.MT_AUTO_ACCPET_CARD_MSG:
                        break;
                    case MessageTypeEnum.MT_DECRYPT_IMG_MSG:
                        Recv_Decrypt_ImageEntity decrypt_ImageEntity = weChatParseHelper.ParseDecryptImage(reponseInfo.data);
                        if (decrypt_ImageEntity.status == 1)
                        {
                            if (CommonCacheConfig.WeChat_ImageList.ContainsKey(decrypt_ImageEntity.src_file))
                            {
                                Recv_Image_MsgEntity recv_Image_MsgEntity_decry = CommonCacheConfig.WeChat_ImageList[decrypt_ImageEntity.src_file];
                                recv_Image_MsgEntity_decry.image_url = decrypt_ImageEntity.dest_file;

                                CallBackWeChatMessage(recv_Image_MsgEntity_decry, dwClient);
                            }
                        }
                        break;
                    case MessageTypeEnum.MT_OPEN_BROWSER_MSG:
                        break;
                    case MessageTypeEnum.MT_RECV_QRCODE_MSG:
                        break;
                    default:
                        break;
                }

                if (logText != "")
                    AddLogs(logText);
            }
            catch (Exception ex)
            {
                AddLogs(ex.Message);
            }

        }
        // 关闭回调
        void WxCloseCallback(uint dwClient)
        {
            try
            {
                WeChat_UserInfo wXInfo = CommonCacheConfig.Login_WeChat_UserInfo.Where(t => t.wx_clientid == dwClient).FirstOrDefault();
                if (wXInfo != null)
                {
                    CommonCacheConfig.Login_WeChat_UserInfo.Remove(wXInfo);
                    AddLogs("【" + wXInfo.nickname + "】退出成功!");
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("WxCloseCallback", ex);
            }
        }
        #endregion

        #region 销毁微信注入的方法
        public void Destroy_WeChat()
        {
            DestroyWeChat();
        }
        #endregion

        #region 启动微信程序目录启动
        public void StartWeChat()
        {
            AddLogs("正在启动微信...");
            new Thread(() =>
            {
                CheckRegistryKey();
                // 注入并多开                                                                                                                                                      
                String dllPath = System.IO.Directory.GetCurrentDirectory() + "\\dll\\WeChatHelper_2.8.0.121.dll";
                InjectWeChat(dllPath);
            }).Start();
        }

        /// <summary>
        /// 检测注册表信息
        /// </summary>
        void CheckRegistryKey()
        {
            string InstallPath = Directory.GetCurrentDirectory() + "\\WeChat";
            string Version = "1644691577";

            RegistryKey currentUser = Registry.CurrentUser;
            RegistryKey registryKey = currentUser.OpenSubKey("Software\\Tencent\\WeChat", true);

            if (registryKey == null)
            {
                registryKey = currentUser.CreateSubKey("Software\\Tencent\\WeChat");
            }

            object existInstallPath = registryKey.GetValue("InstallPath");
            ///未安装微信则注入免安装微信的地址
            if (existInstallPath == null)
            {
                registryKey.SetValue("InstallPath", InstallPath);
                registryKey.SetValue("ChannelId", "1000", RegistryValueKind.DWord);
                registryKey.SetValue("CrashCnt", "0", RegistryValueKind.DWord);
                registryKey.SetValue("CrashVersion", Version, RegistryValueKind.DWord);
                registryKey.SetValue("LANG_ID", "4", RegistryValueKind.DWord);
                registryKey.SetValue("Version", Version, RegistryValueKind.DWord);
            }
            else//已经安装微信  则使用内置微信
            {
                if (existInstallPath.ToString() != InstallPath)
                {
                    registryKey.SetValue("InstallPath", InstallPath);
                    registryKey.SetValue("Version", Version, RegistryValueKind.DWord);
                    registryKey.SetValue("CrashVersion", Version, RegistryValueKind.DWord);
                }
            }
        }
        #endregion
    }
}
