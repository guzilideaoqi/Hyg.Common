/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : DuoMai_ApiManage.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-19 9:28:21 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.DuoMaiTools.DuoMaiModel;
using Hyg.Common.DuoMaiTools.DuoMaiRequest;
using Hyg.Common.DuoMaiTools.DuoMaiResponse;
using Hyg.Common.OtherTools;
using Hyg.Common.OtherTools.OtherModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DuoMaiTools
{
    /// <summary>
    /// 多麦接口管理
    /// </summary>
    public class DuoMai_ApiManage
    {
        const string api_host = "https://open.duomai.com/apis?";
        string dm_appkey = "", dm_appsecret = "";
        public DuoMai_ApiManage(string _dm_appkey, string _dm_appsecret)
        {
            dm_appkey = _dm_appkey;
            dm_appsecret = _dm_appsecret;
        }

        #region 推广计划查询
        /// <summary>
        /// 推广计划查询
        /// </summary>
        /// <param name="query_CPS_Stores_PlansRequest"></param>
        /// <returns></returns>
        public List<CPS_Stores_PlansEntity> Query_CPS_Stores_Plans(Query_CPS_Stores_PlansRequest query_CPS_Stores_PlansRequest)
        {
            List<CPS_Stores_PlansEntity> cPS_Stores_PlansEntities = new List<CPS_Stores_PlansEntity>();
            try
            {
                bool IsSuccess = false; string Msg = "";
                string paramJson = query_CPS_Stores_PlansRequest.ToJsonStr();
                cPS_Stores_PlansEntities = Convert_TemplateResponse<List<CPS_Stores_PlansEntity>>("cps-mesh.open.stores.plans.get", paramJson, ref IsSuccess, ref Msg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Query_CPS_Stores_Plans", ex);
            }

            return cPS_Stores_PlansEntities;
        }
        #endregion

        #region 推广计划详情
        /// <summary>
        /// 推广计划详情
        /// </summary>
        /// <param name="query_Cps_Stores_PlansDetailRequest"></param>
        /// <returns></returns>
        public CPS_Stores_Plans_DetailEntity Get_CPS_Stores_Plans_Detail(Query_Cps_Stores_PlansDetailRequest query_Cps_Stores_PlansDetailRequest)
        {
            CPS_Stores_Plans_DetailEntity cPS_Stores_Plans_DetailEntity = null;
            try
            {
                bool IsSuccess = false; string Msg = "";
                string paramJson = query_Cps_Stores_PlansDetailRequest.ToJsonStr();
                cPS_Stores_Plans_DetailEntity = Convert_TemplateResponse<CPS_Stores_Plans_DetailEntity>("cps-mesh.open.stores.plan.detail.get", paramJson, ref IsSuccess, ref Msg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Get_CPS_Stores_Plans_Detail", ex);
            }

            return cPS_Stores_Plans_DetailEntity;
        }
        #endregion

        #region 商城列表
        public List<CPS_Open_StoresEntity> Get_CPS_Stores_List(Query_CPS_Open_StoreRequest query_CPS_Open_StoreRequest)
        {
            List<CPS_Open_StoresEntity> CPS_Open_StoresList = new List<CPS_Open_StoresEntity>();
            try
            {
                bool IsSuccess = false; string Msg = "";
                string paramJson = query_CPS_Open_StoreRequest.ToJsonStr();
                CPS_Open_StoresList = Convert_TemplateResponse<List<CPS_Open_StoresEntity>>("cps-mesh.open.stores.query.get", paramJson, ref IsSuccess, ref Msg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Get_CPS_Stores_List", ex);
            }

            return CPS_Open_StoresList;
        }
        #endregion

        #region 订单结算变动查询
        /// <summary>
        /// 订单结算变动查询
        /// </summary>
        /// <param name="get_Open_Order_SettlementRequest"></param>
        /// <returns></returns>
        public List<CPS_Open_Order_SettlementEntity> Get_Open_Order_SettlementList(Get_Open_Order_SettlementRequest get_Open_Order_SettlementRequest)
        {
            List<CPS_Open_Order_SettlementEntity> CPS_Open_Order_SettlementList = new List<CPS_Open_Order_SettlementEntity>();
            try
            {
                bool IsSuccess = false; string Msg = "";
                string paramJson = get_Open_Order_SettlementRequest.ToJsonStr();
                CPS_Open_Order_SettlementList = Convert_TemplateResponse<List<CPS_Open_Order_SettlementEntity>>("cps-mesh.open.orders.settlement.get", paramJson, ref IsSuccess, ref Msg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Get_Open_Order_SettlementList", ex);
            }

            return CPS_Open_Order_SettlementList;
        }
        #endregion

        #region 订单详情明细查询
        /// <summary>
        /// 订单详情明细查询
        /// </summary>
        /// <param name="query_Open_Order_DetailRequest"></param>
        /// <returns></returns>
        public CPS_Open_Order_ItemEntity Get_Open_Order_Detail(Query_Open_Order_DetailRequest query_Open_Order_DetailRequest)
        {
            CPS_Open_Order_ItemEntity cPS_Open_Order_ItemEntity = null;
            try
            {
                bool IsSuccess = false; string Msg = "";
                string paramJson = query_Open_Order_DetailRequest.ToJsonStr();
                cPS_Open_Order_ItemEntity = Convert_TemplateResponse<CPS_Open_Order_ItemEntity>("cps-mesh.open.orders.detail.get", paramJson, ref IsSuccess, ref Msg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Get_Open_Order_Detail", ex);
            }

            return cPS_Open_Order_ItemEntity;
        }
        #endregion

        #region 订单列表查询
        /// <summary>
        /// 订单列表查询
        /// </summary>
        /// <param name="query_Open_Order_ListRequest"></param>
        /// <returns></returns>
        public List<CPS_Open_Order_ItemEntity> Query_Open_Order_List(Query_Open_Order_ListRequest query_Open_Order_ListRequest)
        {
            List<CPS_Open_Order_ItemEntity> cPS_Open_Order_ItemList = new List<CPS_Open_Order_ItemEntity>();
            try
            {
                bool IsSuccess = false; string Msg = "";
                string paramJson = query_Open_Order_ListRequest.ToJsonStr(true);
                cPS_Open_Order_ItemList = Convert_TemplateResponse<List<CPS_Open_Order_ItemEntity>>("cps-mesh.open.orders.query.get", paramJson, ref IsSuccess, ref Msg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Query_Open_Order_List", ex);
            }

            return cPS_Open_Order_ItemList;
        }
        #endregion

        #region 推广计划转链
        /// <summary>
        /// 推广计划转链
        /// </summary>
        public CPS_Convert_LinkResponse Get_CPS_Convert_Link(CPS_Convert_LinkRequest cPS_Convert_LinkRequest)
        {
            CPS_Convert_LinkResponse cPS_Convert_LinkResponse = null;
            try
            {
                bool IsSuccess = false; string Msg = "";
                string paramJson = cPS_Convert_LinkRequest.ToJsonStr();

                cPS_Convert_LinkResponse = Convert_TemplateResponse<CPS_Convert_LinkResponse>("cps-mesh.cpslink.links.post", paramJson, ref IsSuccess, ref Msg);
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("Get_CPS_Convert_Link", ex);
            }

            return cPS_Convert_LinkResponse;
        }
        #endregion

        #region 统一请求接口
        string GetApiResponse(string api_type, string paramJson, bool is_post = true)
        {
            string returnContent = "";
            Dictionary<string, string> header = new Dictionary<string, string>();
            //header.Add("Connection", "Upgrade ");
            header.Add("Upgrade", "HTTP/3.0 ");
            if (is_post)
                returnContent = AjaxRequest.HttpPost(api_host + makeRequestParam(api_type, paramJson), paramJson, header, "", "application/json");
            else
                returnContent = AjaxRequest.HttpGet(api_host + makeRequestParam(api_type, paramJson), paramJson);

            return returnContent;
        }

        T Convert_TemplateResponse<T>(string api_type, string paramJson, ref bool IsSuccess, ref string msg)
        {
            try
            {
                string returnContent = GetApiResponse(api_type, paramJson);
                CommonResponseData commonResponseData = returnContent.ToJsonObject<CommonResponseData>();
                if (!commonResponseData.IsEmpty() && commonResponseData.status == 0)
                {
                    IsSuccess = true;
                    return commonResponseData.data.ToJsonStr().ToJsonObject<T>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return default(T);
        }
        #endregion

        #region 生成请求参数
        string makeRequestParam(string api_type, string json_data)
        {
            string timestamp = DateTimeHelper.ConvertDateTimeToInt(DateTime.Now);
            string api_param = string.Format("app_key={0}&service={1}&timestamp={2}", dm_appkey, api_type, timestamp);
            string sign_content = dm_appsecret + api_param.Replace("&", "").Replace("=", "") + json_data + dm_appsecret;
            string sign = Md5Helper.Md5(sign_content).ToUpper();
            api_param += "&sign=" + sign;

            return api_param;
        }
        #endregion
    }
}
