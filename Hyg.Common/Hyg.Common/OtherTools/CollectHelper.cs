/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : CollectHelper.cs
创建人员 : Mr.Hu
创建时间 : 2020-12-05 10:59:53 
备注说明 : 用于采集淘宝、京东、拼多多等商品

 =====================================End=======================================================*/
using Hyg.Common.Model;
using Hyg.Common.WeChatTools.WeChatModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Hyg.Common.OtherTools
{
    /// <summary>
    /// 采集助手
    /// </summary>
    public class CollectHelper
    {
        #region 采集消息
        /// <summary>
        /// 针对图片、视频、gif的采集
        /// </summary>
        /// <param name="collectMessageType"></param>
        /// <param name="FileUrl"></param>
        /// <returns></returns>
        public static CollectMessageEntity CollectOtherMessage(CollectMessageType collectMessageType, string TextContent, object recv_MsgEntity = null)
        {
            CollectMessageEntity collectMessageEntity = null;
            try
            {
                collectMessageEntity = new CollectMessageEntity();
                collectMessageEntity.PlaformType = CollectPlaformType.Other;
                collectMessageEntity.MessageType = collectMessageType;
                collectMessageEntity.MessageContent = TextContent;

                if (collectMessageType == CollectMessageType.Image&& !recv_MsgEntity.IsEmpty() && recv_MsgEntity is Recv_Image_MsgEntity)
                {
                    Recv_Image_MsgEntity recv_Image_MsgEntity = recv_MsgEntity as Recv_Image_MsgEntity;
                    if (!recv_Image_MsgEntity.IsEmpty())
                    {
                        string raw_msg = recv_Image_MsgEntity.raw_msg;
                        collectMessageEntity.raw_msg = raw_msg;

                        XmlNode xmlNode = XMLHelper.ResolveXML(raw_msg, "msg/img", false);
                        ImageEncrptData imageEncrptData = new ImageEncrptData
                        {
                            aeskey = XMLHelper.GetAttribute(xmlNode, "aeskey"),
                            cdnhdheight = XMLHelper.GetAttribute(xmlNode, "cdnhdheight"),
                            cdnhdwidth = XMLHelper.GetAttribute(xmlNode, "cdnhdwidth"),
                            cdnmidheight = XMLHelper.GetAttribute(xmlNode, "cdnmidheight"),
                            cdnmidimgurl = XMLHelper.GetAttribute(xmlNode, "cdnmidimgurl"),
                            cdnmidwidth = XMLHelper.GetAttribute(xmlNode, "cdnmidwidth"),
                            cdnthumbaeskey = XMLHelper.GetAttribute(xmlNode, "cdnthumbaeskey"),
                            cdnthumbheight = XMLHelper.GetAttribute(xmlNode, "cdnthumbheight"),
                            cdnthumblength = XMLHelper.GetAttribute(xmlNode, "cdnthumblength"),
                            cdnthumburl = XMLHelper.GetAttribute(xmlNode, "cdnthumburl"),
                            cdnthumbwidth = XMLHelper.GetAttribute(xmlNode, "cdnthumbwidth"),
                            length = XMLHelper.GetAttribute(xmlNode, "length"),
                            encryver = XMLHelper.GetAttribute(xmlNode, "encryver"),
                            md5 = XMLHelper.GetAttribute(xmlNode, "md5")
                        };

                        collectMessageEntity.imageencrptdata = imageEncrptData;
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("CollectMessage", ex);
            }

            return collectMessageEntity;
        }

        /// <summary>
        /// 采集商品消息
        /// </summary>
        /// <param name="collectPlaformType"></param>
        /// <param name="TextContent"></param>
        /// <returns></returns>
        public static CollectMessageEntity CollectGoodMessage(CollectPlaformType collectPlaformType, string TextContent)
        {
            CollectMessageEntity collectMessageEntity = null;
            try
            {
                collectMessageEntity = new CollectMessageEntity();
                collectMessageEntity.PlaformType = collectPlaformType;
                collectMessageEntity.MessageType = CollectMessageType.Text;
                List<CollectGoodInfo> CollectGoodList = new List<CollectGoodInfo>();

                bool returnStatus = false;
                #region 开始解析文本内容
                switch (collectPlaformType)
                {
                    case CollectPlaformType.TaoBao:
                        #region 开始解析淘宝商品
                        returnStatus = RegularHelper.GoodRegularParseByTB_Mutiple(ref TextContent, ref CollectGoodList);
                        #endregion
                        break;
                    case CollectPlaformType.JD:
                        #region 开始解析京东商品
                        returnStatus = RegularHelper.GoodRegularParseByJD_Mutiple(ref TextContent, ref CollectGoodList);
                        #endregion
                        break;
                    case CollectPlaformType.PDD:
                        #region 开始解析拼多多商品
                        returnStatus = RegularHelper.GoodRegularParseByPDD_Mutiple(ref TextContent, ref CollectGoodList);
                        #endregion
                        break;
                    default:
                        break;
                }

                if (returnStatus)
                {
                    collectMessageEntity.MessageContent = TextContent;
                    collectMessageEntity.CollectGoodList = CollectGoodList;
                }
                #endregion
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("CollectMessage", ex);
            }

            return collectMessageEntity;
        }
        #endregion
    }
}
