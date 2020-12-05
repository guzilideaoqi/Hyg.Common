/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : CollectHelper.cs
创建人员 : Mr.Hu
创建时间 : 2020-12-05 10:59:53 
备注说明 : 用于采集淘宝、京东、拼多多等商品

 =====================================End=======================================================*/
using Hyg.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public static CollectMessageEntity CollectOtherMessage(CollectMessageType collectMessageType, string TextContent)
        {
            CollectMessageEntity collectMessageEntity = null;
            try
            {
                collectMessageEntity = new CollectMessageEntity();
                collectMessageEntity.PlaformType = CollectPlaformType.Other;
                collectMessageEntity.MessageType = collectMessageType;
                collectMessageEntity.MessageContent = TextContent;
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
