/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : ChengQuan_ApiManage.cs
创建人员 : Mr.Hu
创建时间 : 2021-04-06 15:32:24 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.ChengQuanTools.ChengQuanRequest;
using Hyg.Common.OtherTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.ChengQuanTools
{
    /// <summary>
    /// 橙券接口管理
    /// </summary>
    public class ChengQuan_ApiManage
    {
        const string host = "https://tq.jfshou.cn/";
        const string api_url_card_coupon_list = host + "seller/app/classify";//获取卡券集合页面
        const string api_url_card_coupon_order = host + "seller/app/myOrder";//获取卡券订单页面
        const string api_url_video_list = host + "seller/app/video";//获取视频直充集合页面
        const string api_url_video_order = host + "seller/app/rechargeOrder";//获取视频直充订单页面
        string secret_key = "";
        public ChengQuan_ApiManage(string SecretKey)
        {
            secret_key = SecretKey;
        }

        #region 获取卡券集合页面
        public string GetCardCouponList(CardCouponListRequest cardCouponListRequest)
        {
            string resultContent = "";
            try
            {
                resultContent = GeneralApiParam(api_url_card_coupon_list, cardCouponListRequest.ModelToUriParam());//请求参数
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetCardCouponList", ex);
            }
            return resultContent;
        }
        #endregion

        #region 获取卡券订单页面
        public string GetCardCouponOrder(CardCouponListRequest cardCouponListRequest)
        {
            string resultContent = "";
            try
            {
                resultContent = GeneralApiParam(api_url_card_coupon_order, cardCouponListRequest.ModelToUriParam());
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetCardCouponOrder", ex);
            }

            return resultContent;
        }
        #endregion

        #region 获取视频直充集合页面
        public string GetVideoList(CardCouponListRequest cardCouponListRequest)
        {
            string resultContent = "";
            try
            {
                resultContent = GeneralApiParam(api_url_video_list, cardCouponListRequest.ModelToUriParam());
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetVideoList", ex);
            }
            return resultContent;
        }
        #endregion

        #region 获取视频直充订单页面
        public string GetVideoOrder(CardCouponListRequest cardCouponListRequest)
        {
            string resultContent = "";
            try
            {
                resultContent = GeneralApiParam(api_url_video_order, cardCouponListRequest.ModelToUriParam());
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetVideoList", ex);
            }
            return resultContent;
        }
        #endregion

        #region 生成请求签名
        string GeneralApiParam(string api_url, string api_params)
        {
            string resultContent = "";
            try
            {
                api_url = api_url.EndsWith("?") ? api_url : api_url + "?";
                //api_params += string.Format("&appKey={0}", this.dtk_appkey);
                api_url += api_params + "&sign=" + makeSign(api_params);
                resultContent = AjaxRequest.HttpGet(api_url, "");

                resultContent = api_url;
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GeneralApiParam", ex);
            }
            return resultContent;
        }

        string makeSign(string api_params)
        {
            string[] parr = api_params.Split('&');
            Array.Sort(parr);

            string rst = "";
            foreach (string item in parr)
            {
                if (string.IsNullOrEmpty(item)) continue;
                rst += item + "&";
            }
            rst += string.Format("secretKey={0}", secret_key);

            return Md5Helper.Md5(rst).ToUpper();
        }
        #endregion
    }
}
