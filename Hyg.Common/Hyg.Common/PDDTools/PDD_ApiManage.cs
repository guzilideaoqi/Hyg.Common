/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : PDD_ApiManage.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-21 15:39:07 
备注说明 : 拼多多Api管理

 =====================================End=======================================================*/
using Hyg.Common.OtherTools;
using Hyg.Common.OtherTools.OtherModel;
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
        public Order_List_Range_List_GetResponse GetRangeOrderList(Order_List_Range_GetRequest order_List_Range_GetRequest) {
            Order_List_Range_List_GetResponse order_List_Range_List_GetResponse = null;
            try
            {
                string param = this.GetParam(order_List_Range_GetRequest.ModelToUriParamByDic(), "pdd.ddk.order.list.range.get");
                string resultContent = AjaxRequest.HttpPost(CommonCacheConfig.pdd_api_host + "?" + param, "", null, "", "application/json;charset=UTF-8");

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
        public Member_Authority_QueryResponse GetMemberAuthorityQuery(Member_Authority_QueryRequest member_Authority_QueryRequest) {
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
        public Rp_Prom_Url_GenerateResponse Get_Rp_Prom_Url_Generate(Rp_Prom_Url_GenerateRequest rp_Prom_Url_GenerateRequest) {
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
        public Good_Search_ListResponse Good_Search_List(Good_SearchRequest good_SearchRequest) {
            Good_Search_ListResponse good_Search_ListResponse = null;
            try
            {
                string param = this.GetParam(good_SearchRequest.ModelToUriParamByDic(), "pdd.ddk.goods.search");
                string resultContent = AjaxRequest.HttpPost(CommonCacheConfig.pdd_api_host + "?" + param, "", null, "", "application/json;charset=UTF-8");

                good_Search_ListResponse = resultContent.ToJsonObject<Good_Search_ListResponse>();
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Good_Search_List", ex);
            }
            return good_Search_ListResponse;
        }
        #endregion

        #region 拼多多签名生成部分
        private string GetParam(IDictionary<string, string> dic, string type)
        {
            dic.Add("client_id", CommonCacheConfig.pdd_appkey);
            dic.Add("data_type", "JSON");
            dic.Add("timestamp", DateTimeHelper.ConvertDateTimeToInt(DateTime.Now));
            dic.Add("type", type);
            dic.Add("access_token", CommonCacheConfig.pdd_accesstoken);
            string inputText = CommonCacheConfig.pdd_appsecret + GetSignContent(dic) + CommonCacheConfig.pdd_appsecret;
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
    }
}
