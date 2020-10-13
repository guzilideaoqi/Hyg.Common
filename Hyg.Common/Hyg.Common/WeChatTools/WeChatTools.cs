/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : WeChatTools.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 16:55:40 
备注说明 : 微信方法操作类

 =====================================End=======================================================*/
using Hyg.Common.OtherTools;
using Hyg.Common.WeChatTools.WeChatModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Hyg.Common.WeChatTools
{
    /// <summary>
    /// 微信方法操作类
    /// </summary>
    public class WeChatTools
    {
        static void SendWeChatData(uint dwClienId, string strMsg)
        {
            WeChatHelper.SendWeChatData(dwClienId, strMsg);
        }
        /// <summary>
        /// 获取好友信息列表
        /// </summary>
        public static void GetFriendInfoList(uint WxClientId)
        {
            try
            {
                string strMsg = "{\"data\":{},\"type\":" + (int)MessageTypeEnum.MT_DATA_FRIENDS_MSG + "}";
                SendWeChatData(WxClientId, strMsg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetFriendInfoList", ex);
            }
        }

        /// <summary>
        /// 获取群组信息列表
        /// </summary>
        public static void GetChatRoomInfoList(uint WxClientId)
        {
            try
            {
                string strMsg = "{\"data\":{},\"type\":" + (int)MessageTypeEnum.MT_DATA_CHATROOMS_MSG + "}";
                SendWeChatData(WxClientId, strMsg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetChatRoomInfoList", ex);
            }
        }

        /// <summary>
        /// 获取群成员信息列表
        /// </summary>
        public static void GetChatRoomInfoList(uint WxClientId, string room_wxid, bool IsNetWork = false)
        {
            try
            {
                string strMsg = "";
                if (IsNetWork)
                {
                    strMsg = "{\"data\":{\"room_wxid\": \"" + room_wxid + "\"},\"type\":" + (int)MessageTypeEnum.MT_UPDATE_ROOM_MEMBER_MSG + "}";
                }
                else
                {
                    strMsg = "{\"data\":{\"room_wxid\": \"" + room_wxid + "\"},\"type\":" + (int)MessageTypeEnum.MT_DATA_CHATROOM_MEMBERS_MSG + "}";
                }
                SendWeChatData(WxClientId, strMsg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetChatRoomInfoList", ex);
            }
        }

        /// <summary>
        /// 发送解析图片指令
        /// </summary>
        /// <param name="WxClientId"></param>
        /// <param name="src_file"></param>
        public static void SendDecryptImage(uint WxClientId, string src_file)
        {
            try
            {
                string dirPath = Directory.GetCurrentDirectory() + "\\cache\\image";
                if (!Directory.Exists(dirPath))
                    Directory.CreateDirectory(dirPath);

                string image_name = Guid.NewGuid().ToString();
                string filePath = dirPath + "\\" + image_name + ".jpg";

                string strMsg = "{\"data\":{\"src_file\":\"" + src_file.Replace(@"\", @"/\") + "\",\"dest_file\":\"" + filePath.Replace(@"\", @"/\") + "\"},\"type\":" + (int)MessageTypeEnum.MT_DECRYPT_IMG_MSG + "}";
                SendWeChatData(WxClientId, strMsg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("SendDecryptImage", ex);
            }
        }

        /// <summary>
        /// 发送自动加名片好友消息(不可用)
        /// <paramre name="status">1自动  0取消自动</paramre>
        /// </summary>
        public static void SendAutoAddCard(uint WxClientId, int status)
        {
            try
            {
                String strMsg = "{\"data\":{\"auto\":" + status + "},\"type\":" + (int)MessageTypeEnum.MT_AUTO_ACCPET_CARD_MSG + "}";
                SendWeChatData(WxClientId, strMsg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("SendAutoAddCard", ex);
            }
        }

        /// <summary>
        /// 自动同意好友请求
        /// </summary>
        /// <param name="WxClientId"></param>
        /// <param name="xml"></param>
        public static bool SendAutoAgreeFriend(NewFriendInfo newFriendInfo)
        {
            bool returnStatus = false;
            try
            {
                Dictionary<string, string> labelData = new Dictionary<string, string>();
                uint clientID = newFriendInfo.sourcewxid.GetClientIDByWxid(); //判断使用哪个微信的自动同意
                if (clientID > 0)
                {
                    String strMsg = "{\"data\":{\"v1\":\"" + newFriendInfo.v1 + "\",\"v2\":\"" + newFriendInfo.v2 + "\",\"scene\":17},\"type\":" + (int)MessageTypeEnum.MT_ACCEPT_FRIEND_MSG + "}";//"{\"data\":{\"auto\":" + status + "},\"type\":" + (int)MessageTypeEnum.MT_AUTO_ACCPET_CARD_MSG + "}";
                    SendWeChatData(clientID, strMsg);

                    LogHelper.WriteDebugLog("SendAutoAgreeFriend", "新好友" + newFriendInfo.nickname + "自动同意成功!");

                    if (!labelData.ContainsKey("weixincheng"))
                    {
                        labelData.Add("weixincheng", newFriendInfo.nickname);
                    }

                    if (!labelData.ContainsKey("xiajicheng"))
                    {
                        labelData.Add("xiajicheng", newFriendInfo.nickname);
                    }

                    #region 提交邀请的绑定关系
                    /*if (!newFriendInfo.parent_wxid.IsEmpty() && newFriendInfo.wxid != newFriendInfo.parent_wxid)
                    {
                        if (RequstDataOperate.SubmitBindRelation(newFriendInfo, ref labelData))
                        {
                            List<Robot_MessageContentEntity> robot_MessageContentList = JsonConvert.DeserializeObject<List<Robot_MessageContentEntity>>(CommonCache.robot_BaseSettingEntity.base_info.inviter_award_msg);
                            foreach (Robot_MessageContentEntity item in robot_MessageContentList)
                            {
                                CommonCache.weChatHelper.SendTextMsg(clientID, newFriendInfo.parent_wxid, LabelConvertHelper.ConvertResultStr(labelData, item.content));
                                //CommonCache.weChatHelper.SendTextMsg(clientID, newFriendInfo.parent_wxid, LabelConvertHelper.ConvertResultStr(labelData, "您的下级【{微信昵称}】已绑定成功,本次奖励{邀请奖励金额}元,再接再厉哟"));
                            }
                        }
                    }*/
                    #endregion

                    #region 新好友自动同意成功之后发送欢迎语
                    //MessageOperateHelper.SendWelcomeMessage(clientID, 1, newFriendInfo.wxid, labelData);
                    #endregion

                    returnStatus = true;
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("SendAutoAgreeFriend", ex);
            }

            return returnStatus;
        }

        public static void UpdateFriendRemarkMsg(uint WxClientId, string wxid, string remark)
        {
            try
            {
                remark = remark.Replace("\"", "\\\"").Replace(@"\", @"\\");
                //String strMsg = "{\"type\": 11036, \"data\":{\"to_wxid\":\"" + to_wxid + "\", \"content\":\"" + UnicodeHelper.EnUnicode(content) + "\"}}";
                String strMsg = "{\"type\":" + (int)MessageTypeEnum.MT_MOD_FRIEND_REMARK_MSG + ",\"data\":{\"wxid\":\"" + wxid + "\",\"remark\":\"" + UnicodeHelper.EnUnicode(remark) + "\"}}";
                SendWeChatData(WxClientId, strMsg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("UpdateFriendRemarkMsg", ex);
            }
        }

        /// <summary>
        /// 发送文本内容
        /// </summary>
        public static void SendTextMsg(uint WxClientId, string to_wxid, string content)
        {
            try
            {
                content = content.Replace(@"\", @"\\").Replace("\"", "\\\"");
                //String strMsg = "{\"type\": 11036, \"data\":{\"to_wxid\":\"" + to_wxid + "\", \"content\":\"" + UnicodeHelper.EnUnicode(content) + "\"}}";
                String strMsg = "{\"type\":" + (int)MessageTypeEnum.MT_SEND_TEXTMSG + ",\"data\":{\"to_wxid\":\"" + to_wxid + "\",\"content\":\"" + UnicodeHelper.EnUnicode(content) + "\"}}";
                SendWeChatData(WxClientId, strMsg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("SendTextMsg", ex);
            }
        }

        /// <summary>
        /// 发送文本消息(针对群聊@某人使用)
        /// </summary>
        /// <param name="WxClientId">微信客户端id</param>
        /// <param name="to_wxid">接受人</param>
        /// <param name="content">消息内容</param>
        /// <param name="at_wxid">at用户id  传入格式("123","456")</param>
        public static void SendTextMsg(uint WxClientId, string to_wxid, string content, string[] at_wxidList)
        {
            try
            {
                string at_wxid = "";
                for (int i = 0; i < at_wxidList.Length; i++)
                {
                    if (at_wxid != "")
                        at_wxid += ",";
                    at_wxid += "\"" + at_wxidList[i] + "\"";
                }

                content = content.Replace(@"\", @"\\").Replace("\"", "\\\"");
                //String strMsg = "{\"type\": 11036, \"data\":{\"to_wxid\":\"" + to_wxid + "\", \"content\":\"" + UnicodeHelper.EnUnicode(content) + "\"}}";
                String strMsg = "{\"type\":" + (int)MessageTypeEnum.MT_SEND_CHATROOM_ATMSG + ",\"data\":{\"to_wxid\":\"" + to_wxid + "\",\"content\":\"" + UnicodeHelper.EnUnicode(content) + "\",\"at_list\":[" + at_wxid + "]}}";
                SendWeChatData(WxClientId, strMsg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("SendTextMsg", ex);
            }
        }

        /// <summary>
        /// 发送图片消息
        /// </summary>
        /// <param name="WxClientId">微信客户端id</param>
        /// <param name="to_wxid">接收人</param>
        /// <param name="ImageUrl">图片地址(本地地址)</param>
        public static void SendImageMsg(uint WxClientId, string to_wxid, string ImageUrl)
        {
            try
            {
                string image_extend = Path.GetExtension(ImageUrl);//获取图片后缀
                if (!image_extend.IsEmpty())
                {
                    if (image_extend.ToUpper() == ".GIF")
                    {
                        SendGifMsg(WxClientId, to_wxid, ImageUrl);
                    }
                    else
                    {
                        String strMsg = "{\"type\":" + (int)MessageTypeEnum.MT_SEND_IMGMSG + ",\"data\":{\"to_wxid\":\"" + to_wxid + "\",\"file\":\"" + ImageUrl.FileUrlReplace() + "\"}}";
                        SendWeChatData(WxClientId, strMsg);
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("SendImageMsg", ex);
            }
        }

        /// <summary>
        /// 发送名片消息
        /// </summary>
        /// <param name="WxClientId">微信客户端id</param>
        /// <param name="to_wxid">接收者的wxid</param>
        /// <param name="card_wxid">名片人的wxid</param>
        public static void SendCardMsg(uint WxClientId, string to_wxid, string card_wxid)
        {
            try
            {
                String strMsg = "{\"type\":" + (int)MessageTypeEnum.MT_SEND_CARDMSG + ",\"data\":{\"to_wxid\":\"" + to_wxid + "\",\"card_wxid\":\"" + card_wxid + "\"}}";
                SendWeChatData(WxClientId, strMsg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("SendCardMsg", ex);
            }
        }

        /// <summary>
        /// 发送链接消息(卡牌消息)
        /// </summary>
        /// <param name="WxClientId">微信客户端id</param>
        /// <param name="to_wxid">接收者的wxid</param>
        /// <param name="cardInfoEntity"></param>
        public static void SendLinkMsg(uint WxClientId, string to_wxid, CardInfoEntity cardInfoEntity)
        {
            try
            {
                String strMsg = "{\"type\":" + (int)MessageTypeEnum.MT_SEND_LINKMSG + ",\"data\":{\"to_wxid\":\"" + to_wxid + "\",\"title\":\"" + cardInfoEntity.title + "\",\"desc\":\"" + UnicodeHelper.EnUnicode(cardInfoEntity.des) + "\",\"url\":\"" + cardInfoEntity.url + "\",\"image_url\":\"" + cardInfoEntity.thumburl + "\"}}";
                SendWeChatData(WxClientId, strMsg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("SendLinkMsg", ex);
            }
        }

        /// <summary>
        /// 发送视频消息
        /// </summary>
        /// <param name="WxClientId">微信客户端id</param>
        /// <param name="to_wxid">接收者的wxid</param>
        /// <param name="videoUrl">视频地址</param>
        public static void SendVideoMsg(uint WxClientId, string to_wxid, string VideoUrl)
        {
            try
            {
                String strMsg = "{\"type\":" + (int)MessageTypeEnum.MT_SEND_VIDEOMSG + ",\"data\":{\"to_wxid\":\"" + to_wxid + "\",\"file\":\"" + VideoUrl.FileUrlReplace() + "\"}}";
                SendWeChatData(WxClientId, strMsg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("SendVideoMsg", ex);
            }
        }

        /// <summary>
        /// 发送文件消息
        /// </summary>
        /// <param name="WxClientId">微信客户端id</param>
        /// <param name="to_wxid">接收者的wxid</param>
        /// <param name="FileUrl"></param>
        public static void SendFileMsg(uint WxClientId, string to_wxid, string FileUrl)
        {
            try
            {
                String strMsg = "{\"type\":" + (int)MessageTypeEnum.MT_SEND_FILEMSG + ",\"data\":{\"to_wxid\":\"" + to_wxid + "\",\"file\":\"" + FileUrl.FileUrlReplace() + "\"}}";
                SendWeChatData(WxClientId, strMsg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("SendFileMsg", ex);
            }
        }

        /// <summary>
        /// 发送Gif动画表情
        /// </summary>
        /// <param name="WxClientId">微信客户端id</param>
        /// <param name="to_wxid">接收者的wxid</param>
        /// <param name="FileUrl">gif地址</param>
        public static void SendGifMsg(uint WxClientId, string to_wxid, string FileUrl)
        {
            try
            {
                String strMsg = "{\"type\":" + (int)MessageTypeEnum.MT_SEND_GIFMSG + ",\"data\":{\"to_wxid\":\"" + to_wxid + "\",\"file\":\"" + FileUrl.FileUrlReplace() + "\"}}";
                SendWeChatData(WxClientId, strMsg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetChatRoomInfoList", ex);
            }
        }

        /// <summary>
        /// 发送群公告
        /// </summary>
        public static void SendRoomNoticeMsg(uint WxClientId, string room_wxid, string notice)
        {
            try
            {
                notice = notice.Replace(@"\", @"\\").Replace("\"", "\\\"");
                String strMsg = "{\"type\":" + (int)MessageTypeEnum.MT_MOD_ROOM_NOTICE_MSG + ",\"data\":{\"room_wxid\":\"" + room_wxid + "\",\"notice\":\"" + UnicodeHelper.EnUnicode(notice) + "\"}}";
                SendWeChatData(WxClientId, strMsg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("SendRoomNoticeMsg", ex);
            }
        }

        public static void SendWeChatMessage(SendMessageEntity sendMessageEntity)
        {
            try
            {
                #region 发送图片消息
                if (sendMessageEntity.ImageList.HasData())
                {
                    foreach (var item in sendMessageEntity.ImageList)
                    {
                        if (File.Exists(item))
                        {
                            SendImageMsg(sendMessageEntity.dwClientID, sendMessageEntity.to_wxid, item);
                            Thread.Sleep(RandomHelper.GetRandomTimeByConfig());
                        }
                        else
                        {
                            throw new Exception("图片未下载成功,跳过发送!");
                        }
                    }

                    ///应对发送商品图片多少秒后发送文案设置
                    if (sendMessageEntity.img_reply_waittime > 0)
                        Thread.Sleep(RandomHelper.GetRandomSecond(sendMessageEntity.img_reply_waittime, sendMessageEntity.img_reply_waittime));
                }
                #endregion

                #region 发送文本消息
                if (sendMessageEntity.TextList.HasData())
                {
                    string at_wxid = "";

                    foreach (var item in sendMessageEntity.TextList)
                    {
                        if (!at_wxid.IsEmpty())//@人不为空则为群组@消息
                            SendTextMsg(sendMessageEntity.dwClientID, sendMessageEntity.to_wxid, item, sendMessageEntity.at_user_wxid);
                        else
                            SendTextMsg(sendMessageEntity.dwClientID, sendMessageEntity.to_wxid, item);
                    }
                }
                #endregion

                #region 发送视频消息
                if (sendMessageEntity.VideoList.HasData())
                {
                    foreach (var item in sendMessageEntity.VideoList)
                    {
                        if (File.Exists(item))
                        {
                            SendVideoMsg(sendMessageEntity.dwClientID, sendMessageEntity.to_wxid, item);
                            Thread.Sleep(RandomHelper.GetRandomTimeByConfig());
                        }
                        else
                        {
                            throw new Exception("视频未下载成功,跳过发送!");
                        }
                    }
                }
                #endregion

                #region 发送卡牌消息
                if (sendMessageEntity.CardInfoList.HasData())
                {
                    foreach (CardInfoEntity item in sendMessageEntity.CardInfoList)
                    {
                        SendLinkMsg(sendMessageEntity.dwClientID, sendMessageEntity.to_wxid, item);
                    }
                }
                #endregion

                #region 发送文件消息
                if (sendMessageEntity.FileList.HasData())
                {
                    foreach (var item in sendMessageEntity.FileList)
                    {
                        if (File.Exists(item))
                        {
                            SendFileMsg(sendMessageEntity.dwClientID, sendMessageEntity.to_wxid, item);
                            Thread.Sleep(RandomHelper.GetRandomTimeByConfig());
                        }
                        else
                        {
                            throw new Exception("文件未下载成功,跳过发送!");
                        }
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("SendWeChatMessage", ex);
            }
        }
    }
}
