/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : HaoDanKu_ApiManage.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-23 9:38:49 
备注说明 : 好单库接口调用

 =====================================End=======================================================*/
using Hyg.Common.HaoDanKu.HaoDanKuModel;
using Hyg.Common.HaoDanKu.HaoDanKuRequest;
using Hyg.Common.HaoDanKu.HaoDanKuResponse;
using Hyg.Common.OtherTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.HaoDanKu
{
    /// <summary>
    /// 好单库接口调用
    /// </summary>
    public class HaoDanKu_ApiManage
    {
        #region 获取定向计划商品
        /// <summary>
        /// 获取定向计划商品
        /// </summary>
        /// <param name="haoDanKu_GetOrienteeringItemsRequest"></param>
        public HaoDanKu_GetOrienteeringItemsResponse GetOrienteeringItems(HaoDanKu_GetOrienteeringItemsRequest haoDanKu_GetOrienteeringItemsRequest)
        {
            HaoDanKu_GetOrienteeringItemsResponse haoDanKu_GetOrienteeringItemsResponse = null;
            try
            {
                string requestParam = haoDanKu_GetOrienteeringItemsRequest.ModelToUriParam();
                string resultContent = GetRequestResult(requestParam, "get_orienteeringitems");

                haoDanKu_GetOrienteeringItemsResponse = resultContent.ToJsonObject<HaoDanKu_GetOrienteeringItemsResponse>();
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetOrienteeringItems", ex);
            }
            return haoDanKu_GetOrienteeringItemsResponse;
        }
        #endregion

        #region 接口统一请求接口
        string GetRequestResult(string param_json, string api_name)
        {
            string resultContent = "";
            try
            {
                resultContent = AjaxRequest.HttpPost(CommonCacheConfig.haodanku_api_host + "get_orienteeringitems" + "?" + param_json, null, "", "application/json;charset=UTF-8");
            }
            catch (Exception)
            {
                throw;
            }

            return resultContent;
        }
        #endregion
    }
}
