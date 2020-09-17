/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : MessageTypeEnum.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 16:38:02 
备注说明 : 微信操作枚举类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.WeChatTools.WeChatModel
{
    enum MessageTypeEnum
    {
        /// <summary>
        /// DEBUG消息
        /// </summary>
        MT_DEBUG_LOG = 11024,
        /// <summary>
        /// 登录消息
        /// </summary>
        MT_USER_LOGIN = 11025,
        /// <summary>
        /// 注销消息
        /// </summary>
        MT_USER_LOGOUT = 11026,
        /// <summary>
        /// 数据库查询
        /// </summary>
        MT_SQL_QUERY = 11027,
        /// <summary>
        /// 获取我的消息
        /// </summary>
        MT_DATA_OWNER_MSG = 11028,
        /// <summary>
        /// 获取单个好友消息
        /// </summary>
        MT_DATA_WXID_MSG = 11029,
        /// <summary>
        /// 获取好友列表消息
        /// </summary>
        MT_DATA_FRIENDS_MSG = 11030,
        /// <summary>
        /// 获取群聊列表消息
        /// </summary>
        MT_DATA_CHATROOMS_MSG = 11031,
        /// <summary>
        /// 获取群成员消息
        /// </summary>
        MT_DATA_CHATROOM_MEMBERS_MSG = 11032,
        /// <summary>
        /// 获取公众号消息
        /// </summary>
        MT_DATA_PUBLICS_MSG = 11033,
        /// <summary>
        /// 从网络更新单个好友信息消息
        /// </summary>
        MT_UPDATE_WXID_MSG = 11034,
        /// <summary>
        /// 从网络更新群成员信息消息
        /// </summary>
        MT_UPDATE_ROOM_MEMBER_MSG = 11035,
        /// <summary>
        /// 发送文本消息
        /// </summary>
        MT_SEND_TEXTMSG = 11036,
        /// <summary>
        /// 发送群@消息
        /// </summary>
        MT_SEND_CHATROOM_ATMSG = 11037,
        /// <summary>
        /// 发送名片消息
        /// </summary>
        MT_SEND_CARDMSG = 11038,
        /// <summary>
        /// 发送链接消息
        /// </summary>
        MT_SEND_LINKMSG = 11039,
        /// <summary>
        /// 发送图片消息
        /// </summary>
        MT_SEND_IMGMSG = 11040,
        /// <summary>
        /// 发送文件消息
        /// </summary>
        MT_SEND_FILEMSG = 11041,
        /// <summary>
        /// 发送视频消息
        /// </summary>
        MT_SEND_VIDEOMSG = 11042,
        /// <summary>
        /// 发送GIF消息
        /// </summary>
        MT_SEND_GIFMSG = 11043,
        /// <summary>
        /// 接收文本消息
        /// </summary>
        MT_RECV_TEXT_MSG = 11046,
        /// <summary>
        /// 接收图片消息
        /// </summary>
        MT_RECV_PICTURE_MSG = 11047,
        /// <summary>
        /// 接收视频消息
        /// </summary>
        MT_RECV_VOICE_MSG = 11048,
        /// <summary>
        /// 接收申请好友消息
        /// </summary>
        MT_RECV_FRIEND_MSG = 11049,
        /// <summary>
        /// 接收名片消息
        /// </summary>
        MT_RECV_CARD_MSG = 11050,
        /// <summary>
        /// 接收视频消息
        /// </summary>
        MT_RECV_VIDEO_MSG = 11051,
        /// <summary>
        /// 接收表情消息
        /// </summary>
        MT_RECV_EMOJI_MSG = 11052,
        /// <summary>
        /// 接收位置消息
        /// </summary>
        MT_RECV_LOCATION_MSG = 11053,
        /// <summary>
        /// 接收链接消息
        /// </summary>
        MT_RECV_LINK_MSG = 11054,
        /// <summary>
        /// 接收文件消息
        /// </summary>
        MT_RECV_FILE_MSG = 11055,
        /// <summary>
        /// 接收小程序消息
        /// </summary>
        MT_RECV_MINIAPP_MSG = 11056,
        /// <summary>
        /// 接收好友转账消息
        /// </summary>
        MT_RECV_WCPAY_MSG = 11057,
        /// <summary>
        /// 接收系统消息
        /// </summary>
        MT_RECV_SYSTEM_MSG = 11058,
        /// <summary>
        /// 接收撤回消息
        /// </summary>
        MT_RECV_REVOKE_MSG = 11059,
        /// <summary>
        /// 接收其他未知消息
        /// </summary>
        MT_RECV_OTHER_MSG = 11060,
        /// <summary>
        /// 接收应用类型未知消息
        /// </summary>
        MT_RECV_OTHER_APP_MSG = 11061,
        /// <summary>
        /// 发送加好友消息
        /// </summary>
        MT_ADD_FRIEND_MSG = 11062,
        /// <summary>
        /// 发送修改好友备注消息
        /// </summary>
        MT_MOD_FRIEND_REMARK_MSG = 11063,
        /// <summary>
        /// 发送删除好友消息
        /// </summary>
        MT_DEL_FRIEND_MSG = 11064,
        /// <summary>
        /// 发送同意加好友申请消息
        /// </summary>
        MT_ACCEPT_FRIEND_MSG = 11065,
        /// <summary>
        /// 发送接收好友转帐消息
        /// </summary>
        MT_ACCEPT_WCPAY_MSG = 11066,
        /// <summary>
        /// 发送同意进群邀请消息
        /// </summary>
        MT_ACCEPT_ROOM_MSG = 11067,
        /// <summary>
        /// 发送创建群聊消息
        /// </summary>
        MT_CREATE_ROOM_MSG = 11068,
        /// <summary>
        /// 发送邀请好友进群消息，40人以下
        /// </summary>
        MT_INVITE_TO_ROOM_MSG = 11069,
        /// <summary>
        /// 发送邀请好友进群消息，40人以上
        /// </summary>
        MT_INVITE_TO_ROOM_REQ_MSG = 11070,
        /// <summary>
        /// 发送删除群成员消息
        /// </summary>
        MT_DEL_ROOM_MEMBER_MSG = 11071,
        /// <summary>
        /// 发送修改群名称消息
        /// </summary>
        MT_MOD_ROOM_NAME_MSG = 11072,
        /// <summary>
        /// 发送修改群通知消息
        /// </summary>
        MT_MOD_ROOM_NOTICE_MSG = 11073,
        /// <summary>
        /// 发送修改我在本群的昵称消息
        /// </summary>
        MT_MOD_ROOM_MEMBER_NAME_MSG = 11074,
        /// <summary>
        /// 发送修改显示群昵称消息
        /// </summary>
        MT_MOD_ROOM_SHOW_NAME_MSG = 11075,
        /// <summary>
        /// 发送保存到联系人消息
        /// </summary>
        MT_SAVE_ROOM_TO_CONTACT_MSG = 11076,
        /// <summary>
        /// 发送退出并删除群消息
        /// </summary>
        MT_QUIT_DEL_ROOM_MSG = 11077,//	
        /// <summary>
        /// 发送消息免打扰消息
        /// </summary>
        MT_MOD_RECV_NOTIFY_MSG = 11078,
        /// <summary>
        /// 发送置顶消息
        /// </summary>
        MT_MOD_CHAT_SESSION_TOP_MSG = 11079,
        /// <summary>
        /// 发送无痕清粉消息
        /// </summary>
        MT_ZOMBIE_CHECK_MSG = 11080,
        /// <summary>
        /// 发送自动同意好友申请消息
        /// </summary>
        MT_AUTO_ACCEPT_FRIEND_MSG = 11081,
        /// <summary>
        /// 发送自动同意好友转帐消息
        /// </summary>
        MT_AUTO_ACCEPT_WCPAY_MSG = 11082,
        /// <summary>
        /// 发送自动进群邀请消息
        /// </summary>
        MT_AUTO_ACCEPT_ROOM_MSG = 11083,
        /// <summary>
        /// 发送自动加名片消息
        /// </summary>
        MT_AUTO_ACCPET_CARD_MSG = 11084,
        /// <summary>
        /// 发送解密图片消息
        /// </summary>
        MT_DECRYPT_IMG_MSG = 11085,
        /// <summary>
        /// 发送打开浏览器消息
        /// </summary>
        MT_OPEN_BROWSER_MSG = 11086,
        /// <summary>
        /// 获取用户登录二维码，于2019年5月28日新增
        /// </summary>
        MT_RECV_QRCODE_MSG = 11087
    }
}
