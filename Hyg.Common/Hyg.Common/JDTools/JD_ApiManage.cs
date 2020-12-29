/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : JD_ApiManage.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-29 14:16:49 
备注说明 : 京东接口调用类

 =====================================End=======================================================*/
using Hyg.Common.JDTools.JDModel;
using Hyg.Common.JDTools.JDRequest;
using Hyg.Common.JDTools.JDResponse;
using Hyg.Common.Model;
using Hyg.Common.OtherTools;
using Hyg.Common.OtherTools.OtherModel;
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
        string jd_appkey = "", jd_appsecret = "", jd_accesstoken = "";
        public JD_ApiManage(string j_appkey, string j_appsecret, string j_accesstoken)
        {
            this.jd_appkey = j_appkey;
            this.jd_appsecret = j_appsecret;
            this.jd_accesstoken = j_accesstoken;
        }

        #region 京粉精选商品查询接口
        public List<JFGoodsRespRow> GetGoodQueryResultByKeyWord(GoodQueryRequest goodQueryRequest)
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

        #region 关键词商品查询接口【申请】
        public List<JFGoodsRespRow> Super_GetGoodQueryResultByKeyWord(Super_GoodQueryRequest super_GoodQueryRequest)
        {
            List<JFGoodsRespRow> JFGoodsRespRows = null;
            try
            {
                string resultContent = GetRequestResult(super_GoodQueryRequest.ToJsonStr(), "jd.union.open.goods.query");

                Super_GoodQueryResponse super_GoodQueryResponse = resultContent.ToJsonObject<Super_GoodQueryResponse>();
                Super_Jd_GoodInfo_Reponse super_Jd_GoodInfo_Reponse = super_GoodQueryResponse.jd_union_open_goods_query_response.result.ToJsonObject<Super_Jd_GoodInfo_Reponse>();

                JFGoodsRespRows = ConvertJFGoods(super_Jd_GoodInfo_Reponse.data);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_GetGoodQueryResultByKeyWord", ex);
            }

            return JFGoodsRespRows;
        }

        /// <summary>
        /// 公用商品接口
        /// </summary>
        /// <param name="super_GoodQueryRequest"></param>
        /// <returns></returns>
        public List<CommonGoodInfoEntity> Super_GetGoodQueryResultByKeyWord_CommonGoodInfo(Super_GoodQueryRequest super_GoodQueryRequest)
        {
            List<CommonGoodInfoEntity> CommonGoodInfoList = null;
            try
            {
                CommonGoodInfoList = ConvertCommonGoodInfo(Super_GetGoodQueryResultByKeyWord(super_GoodQueryRequest));
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_GetGoodQueryResultByKeyWord_CommonGoodInfo", ex);
            }

            return CommonGoodInfoList;
        }
        #endregion

        #region 优惠券领取情况查询接口【申请】
        public List<Super_QueryCoupon_Detail> Super_QueryCouponInfo(Super_QueryCouponRequest super_QueryCouponRequest)
        {
            List<Super_QueryCoupon_Detail> Super_QueryCoupon_DetailList = null;
            try
            {
                string resultContent = GetRequestResult(super_QueryCouponRequest.ToJsonStr(), "jd.union.open.coupon.query");

                Super_QueryCouponResponse super_QueryCouponResponse = resultContent.ToJsonObject<Super_QueryCouponResponse>();
                Super_QueryCoupon_Result super_QueryCoupon_Result = super_QueryCouponResponse.jd_union_open_coupon_query_response.result.ToJsonObject<Super_QueryCoupon_Result>();

                Super_QueryCoupon_DetailList = super_QueryCoupon_Result.data;
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_QueryCouponInfo", ex);
            }

            return Super_QueryCoupon_DetailList;
        }
        #endregion

        #region 网站/APP获取推广链接接口
        public ConvertLinkResultEntity GetConvertLink(UnionOpenPromotionCommonRequest unionOpenPromotionCommonRequest)
        {
            ConvertLinkResultEntity convertLinkResultEntity = null;
            try
            {
                string resultContent = GetRequestResult(unionOpenPromotionCommonRequest.ToJsonStr(), "jd.union.open.promotion.common.get");

                ConvertLinkResponse convertLinkResponse = resultContent.ToJsonObject<ConvertLinkResponse>();
                if (convertLinkResponse.jd_union_open_promotion_common_get_response.code == 0)
                {
                    ConvertLinkResultDetailResponse convertLinkResultDetailResponse = convertLinkResponse.jd_union_open_promotion_common_get_response.result.ToJsonObject<ConvertLinkResultDetailResponse>();
                    if (convertLinkResultDetailResponse.code == 200)
                    {
                        convertLinkResultEntity = convertLinkResultDetailResponse.data;
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

            return convertLinkResultEntity;
        }
        #endregion

        #region 社交媒体获取推广链接接口【申请】
        public ConvertLinkResultEntity GetConvertLinkBySubUnionID(Super_PromotionBySubUnionidRequest super_PromotionBySubUnionidRequest)
        {
            ConvertLinkResultEntity convertLinkResultEntity = null;
            try
            {
                string resultContent = GetRequestResult(super_PromotionBySubUnionidRequest.ToJsonStr(), "jd.union.open.promotion.bysubunionid.get");

                Super_PromotionBySubUnionidResponse super_PromotionBySubUnionidResponse = resultContent.ToJsonObject<Super_PromotionBySubUnionidResponse>();


                if (super_PromotionBySubUnionidResponse.jd_union_open_promotion_bysubunionid_get_response.code == 0)
                {
                    Super_PromotionBySubUnionidDetailResponse super_PromotionBySubUnionidDetailResponse = super_PromotionBySubUnionidResponse.jd_union_open_promotion_bysubunionid_get_response.result.ToJsonObject<Super_PromotionBySubUnionidDetailResponse>();
                    if (super_PromotionBySubUnionidDetailResponse.code == 200)
                    {
                        convertLinkResultEntity = super_PromotionBySubUnionidDetailResponse.data;
                    }
                    else
                    {
                        LogHelper.WriteDebugLog("GetConvertLinkBySubUnionID", resultContent);
                    }
                }
                else
                {
                    LogHelper.WriteDebugLog("GetConvertLinkBySubUnionID", resultContent);
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetConvertLinkBySubUnionID", ex);
            }

            return convertLinkResultEntity;
        }
        #endregion

        #region 工具商获取推广链接接口【申请】
        public ConvertLinkResultEntity GetConvertLinkByTool(Super_PromotionByToolRequest super_PromotionByToolRequest)
        {
            ConvertLinkResultEntity convertLinkResultEntity = null;
            try
            {
                string resultContent = GetRequestResult(super_PromotionByToolRequest.ToJsonStr(), "jd.union.open.promotion.byunionid.get");

                Super_PromotionByUnionidResponse super_PromotionByUnionidResponse = resultContent.ToJsonObject<Super_PromotionByUnionidResponse>();

                if (super_PromotionByUnionidResponse.jd_union_open_promotion_byunionid_get_response.code == 0)
                {
                    Super_PromotionByUnionidDetailResponse super_PromotionByUnionidDetailResponse = super_PromotionByUnionidResponse.jd_union_open_promotion_byunionid_get_response.result.ToJsonObject<Super_PromotionByUnionidDetailResponse>();
                    if (super_PromotionByUnionidDetailResponse.code == 200)
                    {
                        convertLinkResultEntity = super_PromotionByUnionidDetailResponse.data;
                    }
                    else
                    {
                        LogHelper.WriteDebugLog("GetConvertLinkByTool", resultContent);
                    }
                }
                else
                {
                    LogHelper.WriteDebugLog("GetConvertLinkByTool", resultContent);
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetConvertLinkByTool", ex);
            }

            return convertLinkResultEntity;
        }
        #endregion

        #region 查询推广位【申请】
        public Super_QueryPositionResultInfo Get_PositionList(Super_QueryPositionRequest super_QueryPositionRequest)
        {
            Super_QueryPositionResultInfo super_QueryPositionResultInfo = null;
            try
            {
                string resultContent = GetRequestResult(super_QueryPositionRequest.ToJsonStr(), "jd.union.open.position.query");

                Super_QueryPositionResponse super_QueryPositionResponse = resultContent.ToJsonObject<Super_QueryPositionResponse>();
                if (super_QueryPositionResponse.jd_union_open_position_query_response.code == 0)
                {
                    Super_QueryPositionData super_QueryPositionData = super_QueryPositionResponse.jd_union_open_position_query_response.result.ToJsonObject<Super_QueryPositionData>();
                    if (super_QueryPositionData.code == 200)
                    {
                        super_QueryPositionResultInfo = super_QueryPositionData.data;
                    }
                    else
                    {
                        LogHelper.WriteDebugLog("Get_PositionList", resultContent);
                    }
                }
                else
                {
                    LogHelper.WriteDebugLog("Get_PositionList", resultContent);
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Get_PositionList", ex);
            }
            return super_QueryPositionResultInfo;
        }
        #endregion

        #region 创建推广位【申请】
        /// <summary>
        /// 创建推广位【申请】
        /// </summary>
        public Super_CreatePositionResult CreatePositionInfo(Super_CreatePositionRequest super_CreatePositionRequest)
        {
            Super_CreatePositionResult super_CreatePositionResult = null;
            try
            {
                string resultContent = GetRequestResult(super_CreatePositionRequest.ToJsonStr(), "jd.union.open.position.create");
                Super_CreatePositionResponse super_CreatePositionResponse = resultContent.ToJsonObject<Super_CreatePositionResponse>();
                if (super_CreatePositionResponse.jd_union_open_position_create_response.code == 0)
                {
                    Super_CreatePositionData super_CreatePositionData = super_CreatePositionResponse.jd_union_open_position_create_response.result.ToJsonObject<Super_CreatePositionData>();
                    if (super_CreatePositionData.code == 200)
                    {
                        super_CreatePositionResult = super_CreatePositionData.data;
                    }
                    else
                    {
                        LogHelper.WriteDebugLog("CreatePositionInfo", resultContent);
                    }
                }
                else
                {
                    LogHelper.WriteDebugLog("CreatePositionInfo", resultContent);
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("CreatePositionInfo", ex);
            }

            return super_CreatePositionResult;
        }
        #endregion

        #region 获取PID【申请】 废弃的方法
        public void QueryPIDList(Super_QueryPIDRequest super_QueryPIDRequest)
        {
            try
            {
                string resultContent = GetRequestResult(super_QueryPIDRequest.ToJsonStr(), "jd.union.open.user.pid.get");
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region 订单行查询接口
        public UnionOpenOrderRowQueryResultDetail UnionOpenOrderRowQuery(UnionOpenOrderRowQueryRequest unionOpenOrderRowQueryRequest)
        {
            //List<UnionOpenOrderRowQueryInfo> UnionOpenOrderRowQueryInfoList = new List<UnionOpenOrderRowQueryInfo>();
            UnionOpenOrderRowQueryResultDetail unionOpenOrderRowQueryResultDetail = null;
            try
            {
                string resultContent = GetRequestResult(unionOpenOrderRowQueryRequest.ToJsonStr(), "jd.union.open.order.row.query");

                UnionOpenOrderRowQueryResponse unionOpenOrderRowQueryResponse = resultContent.ToJsonObject<UnionOpenOrderRowQueryResponse>();
                if (!unionOpenOrderRowQueryResponse.jd_union_open_order_row_query_response.IsEmpty() && unionOpenOrderRowQueryResponse.jd_union_open_order_row_query_response.code == 0)
                {
                    unionOpenOrderRowQueryResultDetail = unionOpenOrderRowQueryResponse.jd_union_open_order_row_query_response.result.ToJsonObject<UnionOpenOrderRowQueryResultDetail>();
                    /*UnionOpenOrderRowQueryResultDetail unionOpenOrderRowQueryResultDetail = unionOpenOrderRowQueryResponse.jd_union_open_order_row_query_response.result.ToJsonObject<UnionOpenOrderRowQueryResultDetail>();
                    if (!unionOpenOrderRowQueryResultDetail.IsEmpty() && unionOpenOrderRowQueryResultDetail.code == 200)
                    {
                        UnionOpenOrderRowQueryInfoList = unionOpenOrderRowQueryResultDetail.data;
                    }
                    else
                    {
                        LogHelper.WriteDebugLog("UnionOpenOrderRowQuery", resultContent);
                    }*/
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

            return unionOpenOrderRowQueryResultDetail;
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
            dic.Add("app_key", this.jd_appkey);
            //dic.Add("format", "json");
            dic.Add("timestamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));//this.ConvertDateTimeToInt(DateTime.Now)//DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            dic.Add("method", type);
            dic.Add("v", "1.0");
            dic.Add("sign_method", "md5");
            dic.Add("access_token", this.jd_accesstoken);
            string inputText = this.jd_appsecret + this.GetSignContent(dic) + this.jd_appsecret;
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

        #region 公用商品接口转换
        List<CommonGoodInfoEntity> ConvertCommonGoodInfo(object WaitConvertGoodInfoList)
        {
            List<CommonGoodInfoEntity> commonGoodInfoList = new List<CommonGoodInfoEntity>();
            try
            {
                if (WaitConvertGoodInfoList is List<JFGoodsRespRow>)
                {
                    #region 京粉商品查询
                    List<JFGoodsRespRow> JFGoodsRespRowList = WaitConvertGoodInfoList as List<JFGoodsRespRow>;
                    foreach (JFGoodsRespRow item in JFGoodsRespRowList)
                    {
                        string[] images = item.images;
                        commonGoodInfoList.Add(new CommonGoodInfoEntity
                        {
                            skuid = item.skuId,
                            title = item.skuName,
                            shopId = item.shopId,
                            shopName = item.shopName,
                            coupon_after_price = (item.price - item.discount).ToString(),
                            coupon_price = item.discount.ToString(),
                            origin_price = item.price.ToString(),
                            coupon_end_time = DateTimeHelper.GetDateTimeFrom1970Ticks(item.getEndTime, true).ToString("yyyy-MM-dd HH:mm:ss"),
                            coupon_start_time = DateTimeHelper.GetDateTimeFrom1970Ticks(item.getStartTime, true).ToString("yyyy-MM-dd HH:mm:ss"),
                            detail_images = images,
                            images = images,
                            image = images != null ? images[0] : "",
                            month_sales = item.inOrderCount30Days,
                            TotalCommission = item.discount > 0 ? item.couponCommission : item.commission,
                            PlaformType = 3,
                            afterServiceScore = "4.9",
                            logisticsLvyueScore = "4.85",
                            userEvaluateScore = "4.8",
                            remark = item.brandName,
                            coupon_link = item.link
                        });
                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("ConvertCommonGoodInfo", ex);
            }

            return commonGoodInfoList;
        }
        #endregion
    }
}
