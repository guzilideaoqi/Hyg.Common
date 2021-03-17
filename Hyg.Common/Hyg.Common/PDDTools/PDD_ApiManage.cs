/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : PDD_ApiManage.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-21 15:39:07 
备注说明 : 拼多多Api管理

 =====================================End=======================================================*/
using Hyg.Common.Model;
using Hyg.Common.OtherTools;
using Hyg.Common.OtherTools.OtherModel;
using Hyg.Common.PDDTools.PDDModel;
using Hyg.Common.PDDTools.PDDRequest;
using Hyg.Common.PDDTools.PDDResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools
{
    /// <summary>
    /// 拼多多Api管理
    /// </summary>
    public class PDD_ApiManage
    {
        string pdd_appkey { get; set; }
        string pdd_appsecret { get; set; }
        string pdd_accesstoken { get; set; }

        public PDD_ApiManage(string p_appkey, string p_appsecret, string p_accesstoken)
        {
            this.pdd_appkey = p_appkey;
            this.pdd_appsecret = p_appsecret;
            this.pdd_accesstoken = p_accesstoken;
        }


        #region 拼多多商品转链(商品短链接)
        /// <summary>
        /// 拼多多商品转链
        /// </summary>
        /// <param name="goods_Zs_UnitGenerateRequest"></param>
        /// <returns></returns>
        public Goods_Zs_UnitGenerateResponse Good_Convert_Link(Goods_Zs_UnitGenerateRequest goods_Zs_UnitGenerateRequest)
        {
            Goods_Zs_UnitGenerateResponse goods_Zs_UnitGenerateResponse = null;
            try
            {
                string param = this.GetParam(goods_Zs_UnitGenerateRequest.ModelToUriParamByDic(), "pdd.ddk.goods.zs.unit.url.gen");
                string resultContent = AjaxRequest.HttpPost(CommonCacheConfig.pdd_api_host + "?" + param, "", null, "", "application/json;charset=UTF-8");

                goods_Zs_UnitGenerateResponse = resultContent.ToJsonObject<Goods_Zs_UnitGenerateResponse>();
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Good_Convert_Link", ex);
            }
            return goods_Zs_UnitGenerateResponse;
        }
        #endregion

        #region 获取拼多多商品推广链接(商品id)
        /// <summary>
        /// 获取拼多多商品推广链接
        /// </summary>
        /// <param name="goods_Promotion_Url_GenerateRequest"></param>
        /// <returns></returns>
        public Goods_Promotion_Url_GenerateResponse Good_Promotion_Url(Goods_Promotion_Url_GenerateRequest goods_Promotion_Url_GenerateRequest)
        {
            Goods_Promotion_Url_GenerateResponse goods_Promotion_Url_GenerateResponse = null;
            try
            {
                string param = this.GetParam(goods_Promotion_Url_GenerateRequest.ModelToUriParamByDic(), "pdd.ddk.goods.promotion.url.generate");
                string resultContent = AjaxRequest.HttpPost(CommonCacheConfig.pdd_api_host + "?" + param, "", null, "", "application/json;charset=UTF-8");

                goods_Promotion_Url_GenerateResponse = resultContent.ToJsonObject<Goods_Promotion_Url_GenerateResponse>();
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Good_Promotion_Url", ex);
            }

            return goods_Promotion_Url_GenerateResponse;
        }
        #endregion

        #region 获取拼多多增量订单数据
        /// <summary>
        /// 获取拼多多增量订单数据
        /// </summary>
        /// <param name="incrementOrderListRequest"></param>
        /// <returns></returns>
        public IncrementOrder_List_GetResponse GetIncrementOrderList(IncrementOrderListRequest incrementOrderListRequest)
        {
            IncrementOrder_List_GetResponse incrementOrder_List_GetResponse = null;
            try
            {
                string param = this.GetParam(incrementOrderListRequest.ModelToUriParamByDic(), "pdd.ddk.order.list.increment.get");
                string resultContent = AjaxRequest.HttpPost(CommonCacheConfig.pdd_api_host + "?" + param, "", null, "", "application/json;charset=UTF-8");

                incrementOrder_List_GetResponse = resultContent.ToJsonObject<IncrementOrder_List_GetResponse>();
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetIncrementOrderList", ex);
            }

            return incrementOrder_List_GetResponse;
        }
        #endregion

        #region 获取拼多多订单详情数据
        /// <summary>
        /// 获取拼多多订单详情
        /// </summary>
        /// <param name="order_Detail_GetRequest"></param>
        /// <returns></returns>
        public Order_Detail_GetResponse GetOrderDetailInfo(Order_Detail_GetRequest order_Detail_GetRequest)
        {
            Order_Detail_GetResponse order_Detail_GetResponse = null;
            try
            {
                string param = this.GetParam(order_Detail_GetRequest.ModelToUriParamByDic(), "pdd.ddk.order.detail.get");
                string resultContent = AjaxRequest.HttpPost(CommonCacheConfig.pdd_api_host + "?" + param, "", null, "", "application/json;charset=UTF-8");

                order_Detail_GetResponse = resultContent.ToJsonObject<Order_Detail_GetResponse>();
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetOrderDetailInfo", ex);
            }
            return order_Detail_GetResponse;
        }
        #endregion

        #region 通过时间段获取拼多多订单列表
        /// <summary>
        /// 通过时间段获取拼多多订单列表
        /// </summary>
        /// <param name="order_List_Range_GetRequest"></param>
        /// <returns></returns>
        public Order_List_Range_List_GetResponse GetRangeOrderList(Order_List_Range_GetRequest order_List_Range_GetRequest)
        {
            Order_List_Range_List_GetResponse order_List_Range_List_GetResponse = null;
            try
            {
                string resultContent = GetRequestResult(order_List_Range_GetRequest.ModelToUriParamByDic(), "pdd.ddk.order.list.range.get");

                order_List_Range_List_GetResponse = resultContent.ToJsonObject<Order_List_Range_List_GetResponse>();
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetRangeOrderList", ex);
            }
            return order_List_Range_List_GetResponse;
        }
        #endregion

        #region 查询是否绑定备案
        /// <summary>
        /// 查询是否绑定备案
        /// </summary>
        /// <param name="member_Authority_QueryRequest"></param>
        /// <returns></returns>
        public Member_Authority_QueryResponse GetMemberAuthorityQuery(Member_Authority_QueryRequest member_Authority_QueryRequest)
        {
            Member_Authority_QueryResponse member_Authority_QueryResponse = null;
            try
            {
                string param = this.GetParam(member_Authority_QueryRequest.ModelToUriParamByDic(), "pdd.ddk.member.authority.query");
                string resultContent = AjaxRequest.HttpPost(CommonCacheConfig.pdd_api_host + "?" + param, "", null, "", "application/json;charset=UTF-8");

                member_Authority_QueryResponse = resultContent.ToJsonObject<Member_Authority_QueryResponse>();
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetMemberAuthorityQuery", ex);
            }
            return member_Authority_QueryResponse;
        }
        #endregion

        #region 生成营销工具推广链接
        /// <summary>
        /// 生成营销工具推广链接
        /// </summary>
        /// <param name="rp_Prom_Url_GenerateRequest"></param>
        /// <returns></returns>
        public Rp_Prom_Url_GenerateResponse Get_Rp_Prom_Url_Generate(Rp_Prom_Url_GenerateRequest rp_Prom_Url_GenerateRequest)
        {
            Rp_Prom_Url_GenerateResponse rp_Prom_Url_GenerateResponse = null;
            try
            {
                string param = this.GetParam(rp_Prom_Url_GenerateRequest.ModelToUriParamByDic(), "pdd.ddk.rp.prom.url.generate");
                string resultContent = AjaxRequest.HttpPost(CommonCacheConfig.pdd_api_host + "?" + param, "", null, "", "application/json;charset=UTF-8");

                rp_Prom_Url_GenerateResponse = resultContent.ToJsonObject<Rp_Prom_Url_GenerateResponse>();
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Get_Rp_Prom_Url_Generate", ex);
            }
            return rp_Prom_Url_GenerateResponse;
        }
        #endregion

        #region 商品搜索
        public Good_Search_ListResponse Good_Search_List(Good_SearchRequest good_SearchRequest)
        {
            Good_Search_ListResponse good_Search_ListResponse = null;
            try
            {
                string resultContent = GetRequestResult(good_SearchRequest.ModelToUriParamByDic(), "pdd.ddk.goods.search");

                good_Search_ListResponse = resultContent.ToJsonObject<Good_Search_ListResponse>();


                if (!good_Search_ListResponse.IsEmpty() && !good_Search_ListResponse.IsError && good_SearchRequest.IsReturnCommonInfo)
                {
                    if (good_Search_ListResponse.goods_search_response.IsEmpty() || good_Search_ListResponse.goods_search_response.goods_list.IsEmpty())
                    {
                        LogHelper.WriteDebugLog("Good_Search_List", resultContent);
                    }
                    else
                    {
                        good_Search_ListResponse.CommonGoodInfoList = ConvertCommonGoodInfo(good_Search_ListResponse.goods_search_response.goods_list);
                    }
                }
                else
                {
                    LogHelper.WriteDebugLog("Good_Search_List", resultContent);
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Good_Search_List", ex);
            }
            return good_Search_ListResponse;
        }
        #endregion

        #region 获取单品详情
        public PDD_GoodDetailItem SuperQueryGoodDetail(Super_Query_Good_DetailRequest super_Query_Good_DetailRequest)
        {
            PDD_GoodDetailItem pDD_GoodDetailItem = null;
            try
            {
                string resultContent = GetRequestResult(super_Query_Good_DetailRequest.ModelToUriParamByDic(), "pdd.ddk.goods.detail");

                Super_Query_Good_DetailResponse super_Query_Good_DetailResponse = resultContent.ToJsonObject<Super_Query_Good_DetailResponse>();

                if (!super_Query_Good_DetailResponse.goods_detail_response.IsEmpty())
                {
                    List<PDD_GoodDetailItem> goodDetailItems = super_Query_Good_DetailResponse.goods_detail_response.goods_details;
                    if (!goodDetailItems.IsEmpty() && goodDetailItems.Count > 0)
                    {
                        pDD_GoodDetailItem = goodDetailItems[0];
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("SuperQueryGoodDetail", ex);
            }
            return pDD_GoodDetailItem;
        }
        #endregion

        #region 生成token
        /// <summary>
        /// 生成拼多多接口访问token
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Pdd_TokenInfoEntity General_pdd_Token(string code)
        {
            Pdd_TokenInfoEntity pdd_TokenInfoEntity = null;
            try
            {
                Dictionary<string, string> paramDic = new Dictionary<string, string>();
                paramDic.Add("code", code);
                string param = this.GetParam(paramDic, "pdd.pop.auth.token.create");
                string resultContent = AjaxRequest.HttpPost(CommonCacheConfig.pdd_api_host + "?" + param, "", null, "", "application/json;charset=UTF-8");

                pdd_TokenInfoEntity = resultContent.ToJsonObject<Pdd_TokenInfoResponse>().pop_auth_token_create_response;

                LogHelper.WriteLog("General_pdd_Token", resultContent);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("General_pdd_Token", ex);
            }

            return pdd_TokenInfoEntity;
        }
        #endregion

        #region 刷新token
        public Pdd_TokenInfoEntity Refersh_pdd_Token(string refresh_token)
        {
            Pdd_TokenInfoEntity pdd_TokenInfoEntity = null;
            try
            {
                Dictionary<string, string> paramDic = new Dictionary<string, string>();
                paramDic.Add("refresh_token", refresh_token);
                string param = this.GetParam(paramDic, "pdd.pop.auth.token.refresh");
                string resultContent = AjaxRequest.HttpPost(CommonCacheConfig.pdd_api_host + "?" + param, "", null, "", "application/json;charset=UTF-8");

                pdd_TokenInfoEntity = resultContent.ToJsonObject<Pdd_TokenInfoResponse>().pop_auth_token_refresh_response;

                LogHelper.WriteLog("Refersh_pdd_Token", resultContent);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Refersh_pdd_Token", ex);
            }

            return pdd_TokenInfoEntity;
        }
        #endregion

        /*---------------以下是多多进宝工具商接口---------------*/
        #region 查询所有授权的多多客订单(工具商)
        /// <summary>
        /// 查询所有授权的多多客订单
        /// </summary>
        public IncrementOrder_List_GetResponse Super_GetAllIncrementOrder(Super_GetAllIncrementOrderRequest super_GetAllIncrementOrderRequest)
        {
            IncrementOrder_List_GetResponse incrementOrder_List_GetResponse = null;
            try
            {
                string resultContent = GetRequestResult(super_GetAllIncrementOrderRequest.ModelToUriParamByDic(), "pdd.ddk.all.order.list.increment.get");
                incrementOrder_List_GetResponse = resultContent.ToJsonObject<IncrementOrder_List_GetResponse>();
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_GetAllIncrementOrder", ex);
            }

            return incrementOrder_List_GetResponse;
        }
        #endregion

        #region 多多进宝转链接口(工具商)
        public Goods_Zs_UnitGenerateResponse Super_Good_Convert_Link(Goods_Zs_UnitGenerateRequest goods_Zs_UnitGenerateRequest)
        {
            Goods_Zs_UnitGenerateResponse goods_Zs_UnitGenerateResponse = null;
            try
            {
                goods_Zs_UnitGenerateResponse = Good_Convert_Link(goods_Zs_UnitGenerateRequest);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_Good_Convert_Link", ex);
            }
            return goods_Zs_UnitGenerateResponse;
        }
        #endregion

        #region 生成商城推广链接接口(工具商)
        /// <summary>
        /// 生成商城推广链接接口
        /// </summary>
        public Cms_promotion_url_generate_response Super_General_CMS_Prom_Url(Super_General_CMS_Prom_UrlRequest super_General_CMS_Prom_UrlRequest)
        {
            Cms_promotion_url_generate_response cms_Promotion_Url_Generate_Response = null;
            try
            {
                string resultContent = GetRequestResult(super_General_CMS_Prom_UrlRequest.ModelToUriParamByDic(), "pdd.ddk.oauth.cms.prom.url.generate");
                Super_General_CMS_Prom_UrlResponse super_General_CMS_Prom_UrlResponse = resultContent.ToJsonObject<Super_General_CMS_Prom_UrlResponse>();
                cms_Promotion_Url_Generate_Response = super_General_CMS_Prom_UrlResponse.cms_promotion_url_generate_response;
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_General_CMS_Prom_Url", ex);
            }
            return cms_Promotion_Url_Generate_Response;
        }
        #endregion

        #region 多多进宝推广位创建接口(工具商)
        public Super_GeneralGoodPIDResponse Super_GeneralGoodPID(Super_GeneralGoodPIDRequest super_GeneralGoodPIDRequest)
        {
            Super_GeneralGoodPIDResponse super_GeneralGoodPIDResponse = null;
            try
            {
                string resultContent = GetRequestResult(super_GeneralGoodPIDRequest.ModelToUriParamByDic(), "pdd.ddk.oauth.goods.pid.generate");
                super_GeneralGoodPIDResponse = resultContent.ToJsonObject<Super_GeneralGoodPIDResponse>();
                if (super_GeneralGoodPIDResponse.IsEmpty())
                {
                    LogHelper.WriteLog("Super_GeneralGoodPID", resultContent);
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_GeneralGoodPID", ex);
            }

            return super_GeneralGoodPIDResponse;
        }
        #endregion

        #region 多多客已生成推广位信息查询(工具商)
        public P_id_query_response Super_QueryGoodPID(Super_QueryGoodPIDRequest super_QueryGoodPIDRequest)
        {
            P_id_query_response p_Id_Query_Response = null;
            try
            {
                string resultContent = GetRequestResult(super_QueryGoodPIDRequest.ModelToUriParamByDic(), "pdd.ddk.oauth.goods.pid.query");
                Super_QueryGoodPIDResponse super_QueryGoodPIDResponse = resultContent.ToJsonObject<Super_QueryGoodPIDResponse>();
                p_Id_Query_Response = super_QueryGoodPIDResponse.p_id_query_response;
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_QueryGoodPID", ex);
            }

            return p_Id_Query_Response;
        }
        #endregion

        #region 生成多多进宝推广链接(工具商)
        /// <summary>
        /// 生成多多进宝推广链接(工具商)
        /// </summary>
        /// <param name="super_GeneralGoodPromUrlRequest"></param>
        /// <returns></returns>
        public Goods_Promotion_Url_GenerateResponse Super_GeneralGoodPromUrl(Super_GeneralGoodPromUrlRequest super_GeneralGoodPromUrlRequest)
        {
            Goods_Promotion_Url_GenerateResponse goods_Promotion_Url_GenerateResponse = null;
            try
            {
                string resultContent = GetRequestResult(super_GeneralGoodPromUrlRequest.ModelToUriParamByDic(), "pdd.ddk.oauth.goods.prom.url.generate");
                goods_Promotion_Url_GenerateResponse = resultContent.ToJsonObject<Goods_Promotion_Url_GenerateResponse>();
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_GetAllIncrementOrder", ex);
            }

            return goods_Promotion_Url_GenerateResponse;
        }
        #endregion

        #region 运营频道商品查询API(工具商)
        /// <summary>
        /// 运营频道商品查询API
        /// </summary>
        /// <param name="super_QueryRecommendGoodRequest"></param>
        /// <returns></returns>
        public Goods_basic_detail_response Super_GetRecommendGoodList(Super_QueryRecommendGoodRequest super_QueryRecommendGoodRequest)
        {
            Goods_basic_detail_response goods_Basic_Detail_Response = null;
            try
            {
                string resultContent = GetRequestResult(super_QueryRecommendGoodRequest.ModelToUriParamByDic(), "pdd.ddk.oauth.goods.recommend.get");
                Super_QueryRecommendGoodResponse super_QueryRecommendGoodResponse = resultContent.ToJsonObject<Super_QueryRecommendGoodResponse>();
                goods_Basic_Detail_Response = super_QueryRecommendGoodResponse.goods_Basic_Detail_Response;
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_GetRecommendGoodList", ex);
            }

            return goods_Basic_Detail_Response;
        }
        #endregion

        #region 生成招商推广链接(工具商)
        /// <summary>
        /// 生成招商推广链接(工具商)
        /// </summary>
        /// <param name="super_General_ZS_Unit_UrlRequest"></param>
        /// <returns></returns>
        public ZS_Unit_UrlEntity Super_General_ZS_Unit_Url(Super_General_ZS_Unit_UrlRequest super_General_ZS_Unit_UrlRequest)
        {
            ZS_Unit_UrlEntity zS_Unit_UrlEntity = null;
            try
            {
                string resultContent = GetRequestResult(super_General_ZS_Unit_UrlRequest.ModelToUriParamByDic(), "pdd.ddk.oauth.goods.zs.unit.url.gen");
                Super_General_ZS_Unit_UrlResponse super_General_ZS_Unit_UrlResponse = resultContent.ToJsonObject<Super_General_ZS_Unit_UrlResponse>();
                zS_Unit_UrlEntity = super_General_ZS_Unit_UrlResponse.goods_zs_unit_generate_response;
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_General_ZS_Unit_Url", ex);
            }

            return zS_Unit_UrlEntity;
        }
        #endregion

        #region 多多客工具生成转盘抽免单url(工具商)
        /// <summary>
        /// 多多客工具生成转盘抽免单url(工具商)
        /// </summary>
        /// <param name="super_General_Lottery_UrlRequest"></param>
        /// <returns></returns>
        public Lottery_url_response Super_General_Lottery_Url(Super_General_Lottery_UrlRequest super_General_Lottery_UrlRequest)
        {
            Lottery_url_response lottery_Url_Response = null;
            try
            {
                string resultContent = GetRequestResult(super_General_Lottery_UrlRequest.ModelToUriParamByDic(), "pdd.ddk.oauth.lottery.url.gen");
                Super_General_Lottery_UrlResponse super_General_Lottery_UrlResponse = resultContent.ToJsonObject<Super_General_Lottery_UrlResponse>();
                lottery_Url_Response = super_General_Lottery_UrlResponse.lottery_url_response;
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_General_ZS_Unit_Url", ex);
            }

            return lottery_Url_Response;
        }
        #endregion

        #region 多多客工具生成店铺推广链接API(工具商)
        public Mall_coupon_generate_url_response Super_General_Mall_Url(Super_General_Mall_UrlRequest super_General_Mall_UrlRequest)
        {
            Mall_coupon_generate_url_response mall_Coupon_Generate_Url_Response = null;
            try
            {
                string resultContent = GetRequestResult(super_General_Mall_UrlRequest.ModelToUriParamByDic(), "pdd.ddk.oauth.mall.url.gen");
                Super_General_Mall_UrlResponse super_General_Mall_UrlResponse = resultContent.ToJsonObject<Super_General_Mall_UrlResponse>();
                mall_Coupon_Generate_Url_Response = super_General_Mall_UrlResponse.mall_coupon_generate_url_response;
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_General_Mall_Url", ex);
            }

            return mall_Coupon_Generate_Url_Response;
        }
        #endregion

        #region 查询是否绑定备案(工具商)
        /// <summary>
        /// 查询是否绑定备案(工具商)
        /// </summary>
        public Authority_query_response Super_Query_Member_Authority(Super_Query_Member_AuthorityRequest super_Query_Member_AuthorityRequest)
        {
            Authority_query_response authority_Query_Response = null;
            try
            {
                string resultContent = GetRequestResult(super_Query_Member_AuthorityRequest.ModelToUriParamByDic(), "pdd.ddk.oauth.member.authority.query");
                Super_Query_Member_AuthorityResponse super_Query_Member_AuthorityResponse = resultContent.ToJsonObject<Super_Query_Member_AuthorityResponse>();
                authority_Query_Response = super_Query_Member_AuthorityResponse.authority_query_response;
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_Query_Member_Authority", ex);
            }

            return authority_Query_Response;
        }
        #endregion

        #region 拼多多主站频道推广接口(工具商)
        public Resource_url_response Super_General_Resource_Url(Super_General_Resource_UrlRequest super_General_Resource_UrlRequest)
        {
            Resource_url_response resource_Url_Response = null;
            try
            {
                string resultContent = GetRequestResult(super_General_Resource_UrlRequest.ModelToUriParamByDic(), "pdd.ddk.oauth.resource.url.gen");
                Super_General_Resource_UrlResponse super_General_Resource_UrlResponse = resultContent.ToJsonObject<Super_General_Resource_UrlResponse>();
                resource_Url_Response = super_General_Resource_UrlResponse.resource_url_response;
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_General_Resource_Url", ex);
            }

            return resource_Url_Response;
        }
        #endregion

        #region 生成营销工具推广链接(工具商)
        public Rp_promotion_url_generate_response Super_General_RP_Prom_Url(Super_General_RP_Prom_UrlRequest super_General_RP_Prom_UrlRequest)
        {
            Rp_promotion_url_generate_response rp_Promotion_Url_Generate_Response = null;
            try
            {
                string resultContent = GetRequestResult(super_General_RP_Prom_UrlRequest.ModelToUriParamByDic(), "pdd.ddk.oauth.rp.prom.url.generate");
                Super_General_RP_Prom_UrlResponse super_General_RP_Prom_UrlResponse = resultContent.ToJsonObject<Super_General_RP_Prom_UrlResponse>();
                rp_Promotion_Url_Generate_Response = super_General_RP_Prom_UrlResponse.rp_promotion_url_generate_response;
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_General_Resource_Url", ex);
            }

            return rp_Promotion_Url_Generate_Response;
        }
        #endregion

        #region 多多进宝主题推广链接生成接口(工具商)
        public Theme_promotion_url_generate_response Super_General_Theme_Prom_Url(Super_General_Theme_Prom_UrlRequest super_General_Theme_Prom_UrlRequest)
        {
            Theme_promotion_url_generate_response theme_Promotion_Url_Generate_Response = null;
            try
            {
                string resultContent = GetRequestResult(super_General_Theme_Prom_UrlRequest.ModelToUriParamByDic(), "pdd.ddk.oauth.theme.prom.url.generate");
                Super_General_Theme_Prom_UrlResponse super_General_Theme_Prom_UrlResponse = resultContent.ToJsonObject<Super_General_Theme_Prom_UrlResponse>();
                theme_Promotion_Url_Generate_Response = super_General_Theme_Prom_UrlResponse.theme_promotion_url_generate_response;
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_General_Theme_Prom_Url", ex);
            }

            return theme_Promotion_Url_Generate_Response;
        }
        #endregion

        #region 多多客生成单品推广小程序二维码url(工具商)
        public Weapp_qrcode_generate_response Super_WeApp_Qrcode_Url(Super_WeApp_Qrcode_UrlRequest super_WeApp_Qrcode_UrlRequest)
        {
            Weapp_qrcode_generate_response weapp_Qrcode_Generate_Response = null;
            try
            {
                string resultContent = GetRequestResult(super_WeApp_Qrcode_UrlRequest.ModelToUriParamByDic(), "pdd.ddk.weapp.qrcode.url.gen");
                Super_WeApp_Qrcode_UrlResponse super_WeApp_Qrcode_UrlResponse = resultContent.ToJsonObject<Super_WeApp_Qrcode_UrlResponse>();
                weapp_Qrcode_Generate_Response = super_WeApp_Qrcode_UrlResponse.weapp_qrcode_generate_response;
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Super_WeApp_Qrcode_Url", ex);
            }

            return weapp_Qrcode_Generate_Response;
        }
        #endregion

        /*----------------------end--------------------------*/

        #region 接口统一请求接口
        string GetRequestResult(Dictionary<string, string> dicParam, string apiType)
        {
            string resultContent = "";
            try
            {
                string param = this.GetParam(dicParam, apiType);
                resultContent = AjaxRequest.HttpPost(CommonCacheConfig.pdd_api_host + "?" + param, "", null, "", "application/json;charset=UTF-8");
            }
            catch (Exception)
            {
                throw;
            }
            return resultContent;
        }
        #endregion

        #region 拼多多签名生成部分
        public string GetParam(IDictionary<string, string> dic, string type)
        {
            dic.Add("client_id", this.pdd_appkey);
            dic.Add("data_type", "JSON");
            dic.Add("timestamp", DateTimeHelper.ConvertDateTimeToInt(DateTime.Now));
            dic.Add("type", type);
            dic.Add("access_token", this.pdd_accesstoken);
            string inputText = this.pdd_appsecret + GetSignContent(dic) + this.pdd_appsecret;
            string value = Md5Helper.Md5(inputText).ToUpper();
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
                    stringBuilder.Append(key).Append("").Append(value).Append("");
                }
            }
            return stringBuilder.ToString();
        }
        #endregion

        #region 公用商品接口转换
        List<CommonGoodInfoEntity> ConvertCommonGoodInfo(object WaitConvertGoodInfoList)
        {
            List<CommonGoodInfoEntity> commonGoodInfoList = new List<CommonGoodInfoEntity>();
            try
            {
                if (WaitConvertGoodInfoList is List<Good_Search_Item>)
                {
                    List<Good_Search_Item> good_Search_ItemList = WaitConvertGoodInfoList as List<Good_Search_Item>;
                    foreach (Good_Search_Item item in good_Search_ItemList)
                    {
                        string[] images = new string[] { item.goods_image_url };
                        commonGoodInfoList.Add(new CommonGoodInfoEntity
                        {
                            skuid = item.goods_id.ToString(),
                            title = item.goods_name,
                            shopId = item.mall_id.ToString(),
                            shopName = item.mall_name,
                            coupon_after_price = Math.Round((item.min_group_price - item.coupon_discount) / 100, 2).ToString(),
                            coupon_price = Math.Round(item.coupon_discount / 100, 2).ToString(),
                            origin_price = Math.Round(item.min_group_price / 100, 2).ToString(),
                            coupon_end_time = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss"),
                            coupon_start_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            detail_images = images,
                            images = images,
                            image = item.goods_thumbnail_url,
                            month_sales = item.coupon_total_quantity,
                            TotalCommission = Math.Round((double)((item.min_group_price - item.coupon_discount) * item.promotion_rate) / 100000, 2),
                            PlaformType = 4,
                            afterServiceScore = item.serv_txt,
                            logisticsLvyueScore = item.lgst_txt,
                            userEvaluateScore = item.desc_txt,
                            remark = item.goods_desc,
                            coupon_link = item.mall_coupon_id.ToString()
                        });
                    }
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
