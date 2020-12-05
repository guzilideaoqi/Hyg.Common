/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : WeChatParseHelper.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 16:55:15 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.OtherTools;
using Hyg.Common.WeChatTools.WeChatModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Hyg.Common.WeChatTools
{
    public class WeChatParseHelper
    {
        #region Json转实体
        public static T ConvertObjToModel<T>(object data) where T : new()
        {
            string myJson = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            //到上面步骤已经完成了object转化json，接下来由json转化自定model
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(myJson);
        }
        #endregion

        #region 解析当前用户信息
        /// <summary>
        /// 解析当前用户信息
        /// </summary>
        /// <param name="data"></param>
        /// <param name="ClientId"></param>
        /// <returns></returns>
        public WeChat_UserInfo ParseCurrentUserInfo(object data, uint ClientId)
        {
            try
            {
                WeChat_UserInfo wXInfo = ConvertObjToModel<WeChat_UserInfo>(data);
                wXInfo.wx_clientid = ClientId;

                CommonCacheConfig.Login_WeChat_UserInfo.Add(wXInfo);

                return wXInfo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region 解析好友列表数据
        /// <summary>
        /// 解析好友列表数据
        /// </summary>
        /// <param name="data"></param>
        /// <param name="sourcewxid">所属微信ID</param>
        /// <returns></returns>
        public List<FriendInfoEntity> ParseCurrentFriendList(object data, string sourcewxid)
        {
            List<FriendInfoEntity> friendInfoList = new List<FriendInfoEntity>();
            try
            {
                friendInfoList = ConvertObjToModel<List<FriendInfoEntity>>(data);

                ConvertFriendList(sourcewxid, friendInfoList);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("ParseCurrentFriendList", ex);
            }
            return friendInfoList;
        }

        void ConvertFriendList(string sourcewxid, List<FriendInfoEntity> friendInfoList)
        {
            if (CommonCacheConfig.AllFriendInfoList_Dic.ContainsKey(sourcewxid))
            {
                CommonCacheConfig.AllFriendInfoList_Dic[sourcewxid] = friendInfoList;
            }
            else
            {
                CommonCacheConfig.AllFriendInfoList_Dic.Add(sourcewxid, friendInfoList);
            }
        }
        #endregion

        #region 解析群组列表数据
        /// <summary>
        /// 解析群组列表数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<ChatRoomInfoEntity> ParseCurrentChatRoomList(object data, string sourcewxid)
        {
            List<ChatRoomInfoEntity> chatRoomInfoList = new List<ChatRoomInfoEntity>();
            try
            {
                chatRoomInfoList = ConvertObjToModel<List<ChatRoomInfoEntity>>(data);

                if (CommonCacheConfig.chatRoomInfoList.ContainsKey(sourcewxid))
                {
                    CommonCacheConfig.chatRoomInfoList[sourcewxid] = chatRoomInfoList;
                }
                else
                {
                    CommonCacheConfig.chatRoomInfoList.Add(sourcewxid, chatRoomInfoList);
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("ParseCurrentChatRoomList", ex);
            }
            return chatRoomInfoList;
        }
        #endregion

        #region 解析群成员数据

        #endregion

        #region 解析文本数据
        public Recv_Text_MsgEntity ParseRecvTextMsg(object data)
        {
            try
            {
                Recv_Text_MsgEntity recv_Text_MsgEntity = ConvertObjToModel<Recv_Text_MsgEntity>(data);

                return recv_Text_MsgEntity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region 解析图片数据
        public Recv_Image_MsgEntity ParseImageMsg(object data)
        {
            try
            {
                Recv_Image_MsgEntity recv_Image_MsgEntity = ConvertObjToModel<Recv_Image_MsgEntity>(data);

                return recv_Image_MsgEntity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region 解析文件数据
        public Recv_File_MsgEntity ParseFileMsg(object data)
        {
            try
            {
                Recv_File_MsgEntity recv_File_MsgEntity = ConvertObjToModel<Recv_File_MsgEntity>(data);
                return recv_File_MsgEntity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region 解析视频数据
        public Recv_Video_MsgEntity ParseRecvVideo(object data)
        {
            try
            {
                Recv_Video_MsgEntity recv_Video_MsgEntity = ConvertObjToModel<Recv_Video_MsgEntity>(data);

                return recv_Video_MsgEntity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region 解析gif数据

        #endregion

        #region 解析名片数据
        public CardInfoEntity ParseRecvCard(object data)
        {
            try
            {
                Recv_Link_MsgEntity recv_Card_MsgEntity = ConvertObjToModel<Recv_Link_MsgEntity>(data);

                CardInfoEntity cardInfoEntity = new CardInfoEntity();
                cardInfoEntity.title = XMLHelper.ResolveXML(recv_Card_MsgEntity.raw_msg, "msg/appmsg/title", false).InnerText;
                cardInfoEntity.des = XMLHelper.ResolveXML(recv_Card_MsgEntity.raw_msg, "msg/appmsg/des", false).InnerText;
                cardInfoEntity.url = XMLHelper.ResolveXML(recv_Card_MsgEntity.raw_msg, "msg/appmsg/url", false).InnerText;
                cardInfoEntity.thumburl = XMLHelper.ResolveXML(recv_Card_MsgEntity.raw_msg, "msg/appmsg/thumburl", false).InnerText;

                return cardInfoEntity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion


        #region 解析emoji数据
        public Recv_Emoji_MsgEntity ParseRecvEmoji(object data)
        {
            try
            {
                Recv_Emoji_MsgEntity emojiInfoEntity = ConvertObjToModel<Recv_Emoji_MsgEntity>(data);
                XmlAttribute xmlAttribute = XMLHelper.ResolveXML(emojiInfoEntity.raw_msg, "msg/emoji", false).Attributes["cdnurl"];
                if (xmlAttribute.IsEmpty())
                    return null;
                emojiInfoEntity.ImageUrl = xmlAttribute.Value;
                return emojiInfoEntity;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region 解析小程序数据

        #endregion

        #region 存储解密后的文件路径
        public Recv_Decrypt_ImageEntity ParseDecryptImage(object data)
        {
            try
            {
                Recv_Decrypt_ImageEntity decrypt_ImageEntity = ConvertObjToModel<Recv_Decrypt_ImageEntity>(data);

                return decrypt_ImageEntity;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region 解析接受加好友请求消息
        public NewFriendInfo ParseAcceptFriend(object data)
        {
            try
            {
                Recv_Accept_Friend_MsgEntity recv_Accept_Friend_MsgEntity = ConvertObjToModel<Recv_Accept_Friend_MsgEntity>(data);

                NewFriendInfo newFriendInfo = new NewFriendInfo();
                XmlNode xmlNode = XMLHelper.ResolveXML(recv_Accept_Friend_MsgEntity.raw_msg, "msg", false);
                newFriendInfo.wxid = XMLHelper.GetAttribute(xmlNode, "fromusername");
                newFriendInfo.nickname = XMLHelper.GetAttribute(xmlNode, "fromnickname");
                newFriendInfo.alias = XMLHelper.GetAttribute(xmlNode, "alias");
                newFriendInfo.v1 = XMLHelper.GetAttribute(xmlNode, "encryptusername");
                newFriendInfo.v2 = XMLHelper.GetAttribute(xmlNode, "ticket");
                newFriendInfo.bigheadimgurl = XMLHelper.GetAttribute(xmlNode, "bigheadimgurl");
                newFriendInfo.smallheadimgurl = XMLHelper.GetAttribute(xmlNode, "smallheadimgurl");
                newFriendInfo.parent_wxid = XMLHelper.GetAttribute(xmlNode, "sourceusername");
                newFriendInfo.parent_nickname = XMLHelper.GetAttribute(xmlNode, "sourcenickname");

                CommonCacheConfig.newFriendInfoList.Enqueue(newFriendInfo);

                return newFriendInfo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
