/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : JD_ApiManage.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-29 14:16:49 
备注说明 : 京东接口调用类

 =====================================End=======================================================*/
using Hyg.Common.JDTools.JDRequest;
using Hyg.Common.JDTools.JDResponse;
using Hyg.Common.OtherTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JDTools
{
    /// <summary>
    /// 京东接口调用类
    /// </summary>
    public class JD_ApiManage
    {
        #region 查询商品
        public List<JFGoodsRespRow> GetGoodQueryResult(GoodQueryRequest goodQueryRequest)
        {
            List<JFGoodsRespRow> JFGoodsRespRows = null;
            try
            {
                string resultContent = GetRequestResult(goodQueryRequest.ToJsonStr(), "jd.union.open.goods.jingfen.query");

                GoodQueryResponse jdGoodInfoReponse = resultContent.ToJsonObject<GoodQueryResponse>();
                Jd_GoodInfo_Reponse jd_GoodInfo_Reponse = jdGoodInfoReponse.jd_union_open_goods_jingfen_query_response.result.ToJsonObject<Jd_GoodInfo_Reponse>();

                JFGoodsRespRows = ConvertJFGoods(jd_GoodInfo_Reponse.data);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetGoodQueryResult", ex);
            }
            return JFGoodsRespRows;
        }

        List<JFGoodsRespRow> ConvertJFGoods(JFGoodsResp[] jFGoodsResps)
        {
            try
            {
                List<JFGoodsRespRow> jFGoodsRespRows = new List<JFGoodsRespRow>();
                foreach (JFGoodsResp item in jFGoodsResps)
                {
                    CategoryInfo categoryInfo = item.categoryInfo;
                    CommissionInfo commissionInfo = item.commissionInfo;

                    JFGoodsRespRow jFGoodsRespRow = new JFGoodsRespRow();
                    jFGoodsRespRow.cid1 = categoryInfo.cid1;
                    jFGoodsRespRow.cid1Name = categoryInfo.cid1Name;
                    jFGoodsRespRow.cid2 = categoryInfo.cid2;
                    jFGoodsRespRow.cid2Name = categoryInfo.cid2Name;
                    jFGoodsRespRow.cid3 = categoryInfo.cid3;
                    jFGoodsRespRow.cid3Name = categoryInfo.cid3Name;
                    jFGoodsRespRow.comments = item.comments;
                    jFGoodsRespRow.commission = commissionInfo.commission;
                    jFGoodsRespRow.commissionShare = commissionInfo.commissionShare;
                    jFGoodsRespRow.couponCommission = commissionInfo.couponCommission;
                    jFGoodsRespRow.goodCommentsShare = item.goodCommentsShare;
                    jFGoodsRespRow.inOrderCount30Days = item.inOrderCount30Days;
                    jFGoodsRespRow.inOrderCount30DaysSku = item.inOrderCount30DaysSku;
                    jFGoodsRespRow.isHot = item.isHot;
                    jFGoodsRespRow.spuid = item.spuid;
                    jFGoodsRespRow.skuId = item.skuId;
                    jFGoodsRespRow.skuName = item.skuName;

                    jFGoodsRespRow.owner = item.owner;
                    jFGoodsRespRow.brandCode = item.brandCode;
                    jFGoodsRespRow.brandName = item.brandName;
                    jFGoodsRespRow.price = item.priceInfo.lowestPrice;

                    List<string> images = new List<string>();
                    if (item.imageInfo != null && item.imageInfo.imageList.Length > 0)
                    {
                        for (int i = 0; i < item.imageInfo.imageList.Length; i++)
                        {
                            UrlInfo urlInfo = item.imageInfo.imageList[i];
                            images.Add(urlInfo.url);
                        }
                    }
                    jFGoodsRespRow.images = images.ToArray();

                    CouponInfo couponInfo = item.couponInfo;
                    if (couponInfo.couponList.Length > 0)
                    {
                        Coupon coupon = couponInfo.couponList[couponInfo.couponList.Length - 1];
                        jFGoodsRespRow.bindType = coupon.bindType;
                        jFGoodsRespRow.discount = coupon.discount;
                        jFGoodsRespRow.link = coupon.link;
                        jFGoodsRespRow.platformType = coupon.platformType;
                        jFGoodsRespRow.quota = coupon.quota;
                        jFGoodsRespRow.getStartTime = coupon.getStartTime;
                        jFGoodsRespRow.getEndTime = coupon.getEndTime;
                        jFGoodsRespRow.useStartTime = coupon.useStartTime;
                        jFGoodsRespRow.useEndTime = coupon.useEndTime;
                    }
                    if (item.shopInfo != null)
                    {
                        jFGoodsRespRow.shopId = item.shopInfo.shopId;
                        jFGoodsRespRow.shopName = item.shopInfo.shopName;
                    }

                    jFGoodsRespRows.Add(jFGoodsRespRow);
                }

                return jFGoodsRespRows;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region 获取推广链接
        public string GetConvertLink(UnionOpenPromotionCommonRequest unionOpenPromotionCommonRequest)
        {
            string result = "";
            try
            {
                string resultContent = GetRequestResult(unionOpenPromotionCommonRequest.ToJsonStr(), "jd.union.open.promotion.common.get");

                ConvertLinkResponse convertLinkResponse = resultContent.ToJsonObject<ConvertLinkResponse>();
                if (convertLinkResponse.jd_union_open_promotion_common_get_response.code == 0)
                {
                    ConvertLinkResultDetailResponse convertLinkResultDetailResponse = convertLinkResponse.jd_union_open_promotion_common_get_response.result.ToJsonObject<ConvertLinkResultDetailResponse>();
                    if (convertLinkResultDetailResponse.code == 200)
                    {
                        result = convertLinkResultDetailResponse.data.clickURL;
                    }
                    else
                    {
                        LogHelper.WriteDebugLog("GetConvertLink", resultContent);
                    }
                }
                else
                {
                    LogHelper.WriteDebugLog("GetConvertLink", resultContent);
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetConvertLink", ex);
            }

            return result;
        }
        #endregion

        #region 订单行查询接口
        public List<UnionOpenOrderRowQueryInfo> UnionOpenOrderRowQuery(UnionOpenOrderRowQueryRequest unionOpenOrderRowQueryRequest)
        {
            List<UnionOpenOrderRowQueryInfo> UnionOpenOrderRowQueryInfoList = new List<UnionOpenOrderRowQueryInfo>();
            try
            {
                string resultContent = GetRequestResult(unionOpenOrderRowQueryRequest.ToJsonStr(), "jd.union.open.order.row.query");

                UnionOpenOrderRowQueryResponse unionOpenOrderRowQueryResponse = resultContent.ToJsonObject<UnionOpenOrderRowQueryResponse>();
                if (!unionOpenOrderRowQueryResponse.jd_union_open_order_row_query_response.IsEmpty() && unionOpenOrderRowQueryResponse.jd_union_open_order_row_query_response.code == 0)
                {
                    UnionOpenOrderRowQueryResultDetail unionOpenOrderRowQueryResultDetail = unionOpenOrderRowQueryResponse.jd_union_open_order_row_query_response.result.ToJsonObject<UnionOpenOrderRowQueryResultDetail>();
                    if (!unionOpenOrderRowQueryResultDetail.IsEmpty() && unionOpenOrderRowQueryResultDetail.code == 200)
                    {
                        UnionOpenOrderRowQueryInfoList = unionOpenOrderRowQueryResultDetail.data;
                    }
                    else
                    {
                        LogHelper.WriteDebugLog("UnionOpenOrderRowQuery", resultContent);
                    }
                }
                else
                {
                    LogHelper.WriteDebugLog("UnionOpenOrderRowQuery", resultContent);
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("UnionOpenOrderRowQuery", ex);
            }

            return UnionOpenOrderRowQueryInfoList;
        }
        #endregion

        #region 接口统一请求接口
        string GetRequestResult(string param_json, string api_name)
        {
            string resultContent = "";
            try
            {
                Dictionary<string, string> dic = new System.Collections.Generic.Dictionary<string, string>();
                dic.Add("param_json", param_json);

                string param = this.GetParam(dic, api_name);
                resultContent = AjaxRequest.HttpPost(CommonCacheConfig.jd_api_host + "?" + param, null, "", "application/json;charset=UTF-8");
            }
            catch (Exception)
            {
                throw;
            }

            return resultContent;
        }
        #endregion

        #region 京东签名生成部分
        private string GetSignContent(IDictionary<string, string> parameters)
        {
            IDictionary<string, string> dictionary = new SortedDictionary<string, string>(parameters);
            IEnumerator<KeyValuePair<string, string>> enumerator = dictionary.GetEnumerator();
            StringBuilder stringBuilder = new StringBuilder("");
            while (enumerator.MoveNext())
            {
                KeyValuePair<string, string> current = enumerator.Current;
                string key = current.Key;
                current = enumerator.Current;
                string value = current.Value;
                if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
                {
                    if (key == "param_json")
                        value = value.ToUrlDecode();
                    stringBuilder.Append(key).Append("").Append(value).Append("");
                }
            }
            return stringBuilder.ToString();
        }
        private string GetParam(IDictionary<string, string> dic, string type)
        {
            dic.Add("app_key", CommonCacheConfig.jd_appkey);
            //dic.Add("format", "json");
            dic.Add("timestamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));//this.ConvertDateTimeToInt(DateTime.Now)//DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            dic.Add("method", type);
            dic.Add("v", "1.0");
            //dic.Add("sign_method", "md5");
            //dic.Add("access_token", this.access_token);
            string inputText = CommonCacheConfig.jd_appsecret + this.GetSignContent(dic) + CommonCacheConfig.jd_appsecret;
            string value = Md5Helper.Md5Hex(inputText).ToUpper();
            IEnumerator<KeyValuePair<string, string>> enumerator = dic.GetEnumerator();
            StringBuilder stringBuilder = new StringBuilder("");
            while (enumerator.MoveNext())
            {
                KeyValuePair<string, string> current = enumerator.Current;
                string key = current.Key;
                current = enumerator.Current;
                string value2 = current.Value;
                if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value2))
                {
                    stringBuilder.Append(key).Append("=").Append(value2).Append("&");
                }
            }
            return stringBuilder.Append("sign").Append("=").Append(value).ToString();
        }
        #endregion
    }
}
