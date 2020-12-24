/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : JTT_ApiManage.cs
创建人员 : Mr.Hu
创建时间 : 2020-12-24 11:49:09 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.JTT_Tools.JTTRequest;
using Hyg.Common.JTT_Tools.JTTResponse;
using Hyg.Common.OtherTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JTT_Tools
{
    /// <summary>
    /// JTT_ApiManage
    /// </summary>
    public class JTT_ApiManage
    {
        string api_get_super_category = CommonCacheConfig.jingtuitui_api_host + "api/get_super_category";//获取超级分类
        string api_get_bug_goods = CommonCacheConfig.jingtuitui_api_host + "api/get_goods_list";//京东漏洞单
        string api_get_collection_goods = CommonCacheConfig.jingtuitui_api_host + "api/get_collection_goods";//我的收藏


        string app_id = "", app_key = "";
        public JTT_ApiManage(string AppID, string AppKey)
        {
            app_id = AppID;
            app_key = AppKey;
        }

        #region 获取商品类别
        public JTT_SuperCategoryResponse GetSuperCategory(JTT_SuperCategoryRequest jTT_SuperCategoryRequest)
        {
            JTT_SuperCategoryResponse jTT_SuperCategoryResponse = new JTT_SuperCategoryResponse();
            try
            {
                string resultContent = GeneralApiParam(api_get_super_category, jTT_SuperCategoryRequest.ModelToUriParam());
                if (IsSuccess(resultContent))
                {
                    jTT_SuperCategoryResponse = resultContent.ToJsonObject<JTT_SuperCategoryResponse>();
                }
                else
                {
                    jTT_SuperCategoryResponse.Return = -1;
                    jTT_SuperCategoryResponse.Msg = resultContent;
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetSuperCategory", ex);
            }
            return jTT_SuperCategoryResponse;
        }
        #endregion

        #region 我的收藏
        public JTT_CollectionGoodsResponse GetCollection_Goods(JTT_CollectionGoodsRequest jTT_CollectionGoodsRequest)
        {
            JTT_CollectionGoodsResponse jTT_CollectionGoodsResponse = new JTT_CollectionGoodsResponse();
            try
            {
                string resultContent = GeneralApiParam(api_get_collection_goods, jTT_CollectionGoodsRequest.ModelToUriParam());
                if (IsSuccess(resultContent))
                {
                    jTT_CollectionGoodsResponse = resultContent.ToJsonObject<JTT_CollectionGoodsResponse>();
                }
                else {
                    jTT_CollectionGoodsResponse.Return = -1;
                    jTT_CollectionGoodsResponse.Msg = resultContent;
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetCollection_Goods", ex);
            }

            return jTT_CollectionGoodsResponse;
        }
        #endregion

        #region 京东漏洞单
        public JTT_BugGoodsResponse GetBug_GoodsList(JTT_BugGoodsRequest jTT_BugGoodsRequest)
        {
            JTT_BugGoodsResponse jTT_BugGoodsResponse = new JTT_BugGoodsResponse();
            try
            {
                string resultContent = GeneralApiParam(api_get_bug_goods, jTT_BugGoodsRequest.ModelToUriParam());
                if (IsSuccess(resultContent))
                {
                    jTT_BugGoodsResponse = resultContent.ToJsonObject<JTT_BugGoodsResponse>();
                }
                else {
                    jTT_BugGoodsResponse.Return = -1;
                    jTT_BugGoodsResponse.Msg = resultContent;
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GetBug_GoodsList", ex);
            }
            return jTT_BugGoodsResponse;
        }
        #endregion

        #region 判断接口是否成功
        bool IsSuccess(string resultContent) {
            JTT_CommonResponse jTT_CommonResponse = resultContent.ToJsonObject<JTT_CommonResponse>();
            if (jTT_CommonResponse.Return == 0)
            {
                return true;
            }
            else {
                return false;
            }
        }
        #endregion

        #region 构造京推推请求参数
        string GeneralApiParam(string api_url, string api_params)
        {
            string resultContent = "";
            try
            {
                api_url = api_url.EndsWith("?") ? api_url : api_url + "?";
                api_params += string.Format("&appid={0}&appkey={1}", this.app_id, this.app_key);
                api_url += api_params;
                resultContent = AjaxRequest.HttpGet(api_url, "");
            }
            catch (Exception ex)
            {
                LogHelper.WriteException("GeneralApiParam", ex);
            }
            return resultContent;
        }
        #endregion
    }
}
