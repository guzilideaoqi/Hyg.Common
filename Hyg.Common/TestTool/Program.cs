using Hyg.Common;
using Hyg.Common.DTKTools;
using Hyg.Common.DTKTools.DTKRequest;
using Hyg.Common.DTKTools.DTKResponse;
using Hyg.Common.JDTools;
using Hyg.Common.JDTools.JDRequest;
using Hyg.Common.OtherTools;
using Hyg.Common.OtherTools.OtherModel;
using Hyg.Common.PDDTools;
using Hyg.Common.PDDTools.PDDRequest;
using Hyg.Common.PDDTools.PDDResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TestTool
{
    class Program
    {
        const int plaformType = 1;//1=淘宝  2=京东  3=拼多多
        static void Main(string[] args)
        {
            try
            {
                //string str = "<msg fromusername=\"wxid_54foqo0ljj8o22\" encryptusername=\"v3_020b3826fd030100000000000820218c94415f000000501ea9a3dba12f95f6b60a0536a1adb638b49bee2336de06a68d500849630220d5d551dcf955e29006ee779c5c42d39231eae976a7661b1df69e336e26e7606ce25ebbc530a51c9c6955388459@stranger\" fromnickname=\"pretty girl\" content=\"陈涛\" fullpy=\"prettygirl\" shortpy=\"PRETTYGIRL\" imagestatus=\"3\" scene=\"17\" country=\"AE\" province=\"Al Fujayrah\" city=\"\" sign=\"涛少\" percard=\"1\" sex=\"1\" alias=\"aawjwj\" weibo=\"\" albumflag=\"0\" albumstyle=\"0\" albumbgimgid=\"\" snsflag=\"257\" snsbgimgid=\"http://szmmsns.qpic.cn/mmsns/PDHwiaPWZh0fPh5YzXyH5IS9uvUC4O4omVa3h9SCGGhadEKlJgv9BPsibtCKcJx7cP9iaA0Z2tzUlI/0\" snsbgobjectid=\"13391932798898090074\" mhash=\"b607b1a83276a3be0e0aa7974445022a\" mfullhash=\"b607b1a83276a3be0e0aa7974445022a\" bigheadimgurl=\"http://wx.qlogo.cn/mmhead/ver_1/xQUKJxs4mQrJNzhYsOMqn1LjBr3uhNbBoIfYbQbHJ26dmTMv09gb5qcYZnc5QEib0TaX6QzVmibjNpzgibicJWB8vtEBD7mFfhCOMn5jKdy2JLk/0\" smallheadimgurl=\"http://wx.qlogo.cn/mmhead/ver_1/xQUKJxs4mQrJNzhYsOMqn1LjBr3uhNbBoIfYbQbHJ26dmTMv09gb5qcYZnc5QEib0TaX6QzVmibjNpzgibicJWB8vtEBD7mFfhCOMn5jKdy2JLk/96\" ticket=\"v4_000b708f0b040000010000000000ffe375e707cbd824f3d77246745f1000000050ded0b020927e3c97896a09d47e6e9e288fd4394783ba8b82f3b8c372064c0a5d30fae7976a7d4fa49fba9b7e83ef0fb48d3c5ec017fa72b6ee868cff77fadc2b9133c2d75f792b1530aa960709438df7d0d7a8b7058d5324b543e81acc349da850e9b4bd2d773f5a8d29f40db6e437a885ae8dd57038434b23bc0baf605942b847b844a495c6286f2d148a314e51515744c5dffe6d735799ab4e722cc718dcc77671380fc435cf3dd95f721cf9aec35d33d40d7fdf349c3e173a77b0210f35047f156f46f3edbffd17c6c0e366e3a237255d66611b701691ce9590aaacfea9ae67d5e8d156674788c2e51133bfa89d9f8aa63360130d2ddc7960a4a602e4f02905ccc88026accb72c0ca7d280a79528a5914d710fc12eb7bfc223ef5dd5498fd7a969078bdfb7cf8@stranger\" opcode=\"2\" googlecontact=\"\" qrticket=\"\" chatroomusername=\"\" sourceusername=\"wxid_z7rjwki6i9yk22\" sourcenickname=\"心凉&她\" sharecardusername=\"wxid_z7rjwki6i9yk22\" sharecardnickname=\"心凉&amp;她\" cardversion=\"0\"><brandlist count=\"0\" ver=\"657547423\"></brandlist></msg>";

                //System.Xml.XmlNode xmlList = XMLHelper.ResolveXML(str, "msg", true);

                CommonCacheConfig.dtk_appkey = "5d2fd0a674e69"; CommonCacheConfig.dtk_appsecret = "7ac9d649468d3603ef506224c9298497";
                CommonCacheConfig.pdd_appkey = "ac48d84bf6064db4be917cd26d71f9bb"; CommonCacheConfig.pdd_appsecret = "ec47368867643a48b5beab50dd97ebaf7fe96f55";
                CommonCacheConfig.jd_appkey = "a666eb66d3c749e4857354b69476efab"; CommonCacheConfig.jd_appsecret = "2c6e68722c4047de9a95f0ef9519ea14"; CommonCacheConfig.jd_accesstoken = "e4209eac5db9f8e2762718c5ab2212e8fc9d5c76edce579ab144095bbb95ce392c3b86569f18f09a";


                if (plaformType == 1)
                {
                    DTK_ApiManage dTK_ApiManage = new DTK_ApiManage();
                    int apiType = 19;
                    object apiData = null;
                    switch (apiType)
                    {
                        case 1:
                            #region 超级分类
                            DTK_Super_CategoryRequest dTK_Super_CategoryRequest = new DTK_Super_CategoryRequest();
                            apiData = dTK_ApiManage.GetSuperCategory(dTK_Super_CategoryRequest);
                            #endregion
                            break;
                        case 2:
                            #region 热搜词
                            DTK_Top100_Request dTK_Top100_Request = new DTK_Top100_Request();
                            apiData = dTK_ApiManage.GetTop100(dTK_Top100_Request);
                            #endregion
                            break;
                        case 3:
                            #region 各大榜单
                            DTK_Ranking_ListRequest dTK_Ranking_ListRequest = new DTK_Ranking_ListRequest();
                            dTK_Ranking_ListRequest.rankType = 1;
                            apiData = dTK_ApiManage.GetRankingList(dTK_Ranking_ListRequest);
                            #endregion
                            break;
                        case 4:
                            #region 高效转链
                            DTK_Privilege_LinkRequest dTK_Privilege_LinkRequest = new DTK_Privilege_LinkRequest();
                            dTK_Privilege_LinkRequest.goodsId = "557600945136";
                            dTK_Privilege_LinkRequest.pid = "mm_127267155_967450311_109582900164";
                            dTK_Privilege_LinkRequest.channelId = "2256931115";
                            dTK_Privilege_LinkRequest.couponId = "";
                            apiData = dTK_ApiManage.GetPrivilegeLink(dTK_Privilege_LinkRequest);
                            #endregion
                            break;
                        case 5:
                            #region 获取超级搜索商品
                            DTK_Super_GoodRequest dTK_Super_GoodRequest = new DTK_Super_GoodRequest();
                            dTK_Super_GoodRequest.keyWords = "女装";
                            //dTK_Super_GoodRequest.keyWords = "$jjof1ixIRtw$";
                            apiData = dTK_ApiManage.GetSuperGood(dTK_Super_GoodRequest);
                            #endregion
                            break;
                        case 6:
                            #region 9.9包邮精选
                            DTK_OP_ListRequest dTK_OP_ListRequest = new DTK_OP_ListRequest();
                            dTK_OP_ListRequest.nineCid = "1";
                            dTK_OP_ListRequest.pageId = "1";
                            dTK_OP_ListRequest.pageSize = 20;
                            apiData = dTK_ApiManage.GetOPGood(dTK_OP_ListRequest);
                            #endregion
                            break;
                        case 7:
                            #region 获取联想词列表
                            DTK_Search_SuggestionRequest dTK_Search_SuggestionRequest = new DTK_Search_SuggestionRequest();
                            dTK_Search_SuggestionRequest.type = 3;
                            dTK_Search_SuggestionRequest.keyWords = "女装";
                            apiData = dTK_ApiManage.GetSearchSuggestion(dTK_Search_SuggestionRequest);
                            #endregion
                            break;
                        case 8:
                            #region 热门活动
                            DTK_Activity_CatalogueRequest dTK_Activity_CatalogueRequest = new DTK_Activity_CatalogueRequest();
                            apiData = dTK_ApiManage.GetActivityCatalogueList(dTK_Activity_CatalogueRequest);
                            #endregion
                            break;
                        case 9:
                            #region 活动商品
                            DTK_Activity_GoodListRequest dTK_Activity_GoodListRequest = new DTK_Activity_GoodListRequest();
                            dTK_Activity_GoodListRequest.pageId = "1";
                            dTK_Activity_GoodListRequest.pageSize = 20;
                            //dTK_Activity_GoodListRequest.cid = 1;
                            dTK_Activity_GoodListRequest.activityId = 57;
                            apiData = dTK_ApiManage.GetActivityGoodList(dTK_Activity_GoodListRequest);
                            #endregion
                            break;
                        case 10:
                            #region 精选专辑
                            DTK_Topic_CatalogueRequest dTK_Topic_CatalogueRequest = new DTK_Topic_CatalogueRequest();
                            apiData = dTK_ApiManage.GetTopicCatalogue(dTK_Topic_CatalogueRequest);
                            #endregion
                            break;
                        case 11:
                            #region 精选专辑商品
                            DTK_Topic_GoodListRequest dTK_Topic_GoodListRequest = new DTK_Topic_GoodListRequest();
                            dTK_Topic_GoodListRequest.pageId = "1";
                            dTK_Topic_GoodListRequest.pageSize = 20;
                            dTK_Topic_GoodListRequest.topicId = 1647;
                            apiData = dTK_ApiManage.GetTopicGoodList(dTK_Topic_GoodListRequest);
                            #endregion
                            break;
                        case 12:
                            #region 官方推广活动
                            DTK_TB_Topic_ListRequest dTK_TB_Topic_ListRequest = new DTK_TB_Topic_ListRequest();
                            dTK_TB_Topic_ListRequest.type = 0;
                            dTK_TB_Topic_ListRequest.pageId = "1";
                            dTK_TB_Topic_ListRequest.pageSize = 20;
                            dTK_TB_Topic_ListRequest.channelID = 2102783788;
                            apiData = dTK_ApiManage.GettTBTopicList(dTK_TB_Topic_ListRequest);
                            #endregion
                            break;
                        case 13:
                            #region 获取商品详情
                            DTK_Get_Good_DetailsRequest dTK_Get_Good_DetailsRequest = new DTK_Get_Good_DetailsRequest();
                            dTK_Get_Good_DetailsRequest.id = "";
                            dTK_Get_Good_DetailsRequest.goodsId = "585956006662";
                            apiData = dTK_ApiManage.GetGoodDetail(dTK_Get_Good_DetailsRequest);
                            #endregion
                            break;
                        case 14:
                            DTK_TB_Service_GoodRequest dTK_TB_Service_GoodRequest = new DTK_TB_Service_GoodRequest();
                            dTK_TB_Service_GoodRequest.pageNo = 1;
                            dTK_TB_Service_GoodRequest.pageSize = 20;
                            dTK_TB_Service_GoodRequest.keyWords = "女";
                            //dTK_TB_Service_GoodRequest.keyWords = "仿真小老虎公仔毛绒玩具可爱白虎玩偶布娃娃动物摆件车载儿童礼物";
                            dTK_TB_Service_GoodRequest.startPrice = 5;
                            dTK_TB_Service_GoodRequest.endPrice = 10;
                            //dTK_TB_Service_GoodRequest.startTkRate = 1000;
                            //dTK_TB_Service_GoodRequest.endTkRate = 0;
                            apiData = dTK_ApiManage.GetDTK_TBServiceGood(dTK_TB_Service_GoodRequest);
                            break;
                        case 15:
                            DTK_Get_dtk_Search_GoodRequest dtk_Get_dtk_Search_GoodRequest = new DTK_Get_dtk_Search_GoodRequest();
                            dtk_Get_dtk_Search_GoodRequest.pageId = "1";
                            dtk_Get_dtk_Search_GoodRequest.pageSize = 20;
                            dtk_Get_dtk_Search_GoodRequest.keyWords = "女装";
                            dtk_Get_dtk_Search_GoodRequest.sort = "0";
                            dtk_Get_dtk_Search_GoodRequest.cids = "1";
                            apiData = dTK_ApiManage.GetDtkSearchGood(dtk_Get_dtk_Search_GoodRequest);
                            break;
                        case 16:
                            DTK_Parse_ContentRequest dTK_Parse_ContentRequest = new DTK_Parse_ContentRequest();
                            dTK_Parse_ContentRequest.content = @"巨可爱的毛绒抱枕💥
6.9元起
送孩子，送女朋友，送闺蜜
💕快给你的小宝贝带一个吧~
———怎么买———
(fl9Zc4ybx2d)
復製这条信息打开手机氵匋寳即可！";
                            apiData = dTK_ApiManage.GetParseContent(dTK_Parse_ContentRequest);
                            break;
                        case 17:
                            DTK_Order_DataRequest dTK_Order_DataRequest = new DTK_Order_DataRequest();
                            apiData = dTK_ApiManage.GetOrderData(dTK_Order_DataRequest);
                            break;
                        case 18:
                            DTK_Get_CollectRequest dTK_Get_CollectRequest = new DTK_Get_CollectRequest();
                            apiData = dTK_ApiManage.GetDTK_CollectGood(dTK_Get_CollectRequest);
                            break;
                        case 19:
                            DTK_LiveMaterialGoodRequest dTK_LiveMaterialGoodRequest = new DTK_LiveMaterialGoodRequest();
                            apiData = dTK_ApiManage.GetDTK_LiveMaterialGood(dTK_LiveMaterialGoodRequest);
                            break;
                    }

                    Console.WriteLine(apiData.ToJsonStr());
                }
                else if (plaformType == 2)
                {
                    JD_ApiManage jD_ApiManage = new JD_ApiManage();

                    UnionOpenOrderRowQueryRequest unionOpenOrderRowQueryRequest = new UnionOpenOrderRowQueryRequest();
                    UnionOpenOrderRowQueryDetailRequest unionOpenOrderRowQueryDetailRequest = new UnionOpenOrderRowQueryDetailRequest();
                    unionOpenOrderRowQueryDetailRequest.fields = "goodsInfo";
                    unionOpenOrderRowQueryDetailRequest.startTime = "2020-10-11 13:30:00";
                    unionOpenOrderRowQueryDetailRequest.endTime = "2020-10-11 14:30:00";
                    unionOpenOrderRowQueryRequest.orderReq = unionOpenOrderRowQueryDetailRequest;

                    Console.WriteLine("共获取到" + jD_ApiManage.UnionOpenOrderRowQuery(unionOpenOrderRowQueryRequest).Count + "条数据!");
                    return;


                    UnionOpenPromotionCommonRequest unionOpenPromotionCommonRequest = new UnionOpenPromotionCommonRequest();
                    PromotionCodeReq promotionCodeReq = new PromotionCodeReq();
                    promotionCodeReq.materialId = "https://item.jd.com/67991567458.html";
                    promotionCodeReq.siteId = "1165439379";
                    promotionCodeReq.positionId = "1962857865";
                    promotionCodeReq.couponUrl = "https://coupon.m.jd.com/coupons/show.action?linkKey=AAROH_xIpeffAs_-naABEFoev-omQ90qgcOsIHlIUcaU0s8QDzcjTaml0M1BB6EQGLHCWXWCqjWgoS7wHI6T8xvDkNaYwg".ToUrlEncode();
                    unionOpenPromotionCommonRequest.promotionCodeReq = promotionCodeReq;
                    Console.WriteLine("转链结果：" + jD_ApiManage.GetConvertLink(unionOpenPromotionCommonRequest));
                    return;

                    GoodQueryRequest goodQueryRequest = new GoodQueryRequest();
                    GoodQueryDetailReq goodQueryDetailReq = new GoodQueryDetailReq();
                    goodQueryDetailReq.eliteId = 1;
                    goodQueryRequest.goodsReq = goodQueryDetailReq;
                    Console.WriteLine("共获取到" + jD_ApiManage.GetGoodQueryResult(goodQueryRequest).Count + "条数据!");
                    return;
                }
                else if (plaformType == 3) {
                    PDD_ApiManage pDD_ApiManage = new PDD_ApiManage();
                    //Goods_Zs_UnitGenerateRequest goods_Zs_UnitGenerateRequest = new Goods_Zs_UnitGenerateRequest();
                    //goods_Zs_UnitGenerateRequest.custom_parameters = "666";
                    //goods_Zs_UnitGenerateRequest.pid = "1912666_125576394";
                    //goods_Zs_UnitGenerateRequest.source_url = "https://p.pinduoduo.com/doXbmz4V";
                    //Goods_Zs_UnitGenerateResponse goods_Zs_UnitGenerateResponse = pDD_ApiManage.Good_Convert_Link(goods_Zs_UnitGenerateRequest);

                    //Goods_Promotion_Url_GenerateRequest goods_Promotion_Url_GenerateRequest = new Goods_Promotion_Url_GenerateRequest();
                    //goods_Promotion_Url_GenerateRequest.custom_parameters = "888";
                    //goods_Promotion_Url_GenerateRequest.goods_id_list = new string[] { "177521731055" };
                    //goods_Promotion_Url_GenerateRequest.p_id = "1912666_125576394";
                    //Goods_Promotion_Url_GenerateResponse goods_Promotion_Url_GenerateResponse = pDD_ApiManage.Good_Promotion_Url(goods_Promotion_Url_GenerateRequest);

                    //IncrementOrderListRequest incrementOrderListRequest = new IncrementOrderListRequest();
                    //incrementOrderListRequest.start_update_time = long.Parse(DateTimeHelper.ConvertDateTimeToInt(DateTime.Parse("2020-09-13 07:56:09")));
                    //incrementOrderListRequest.end_update_time = long.Parse(DateTimeHelper.ConvertDateTimeToInt(DateTime.Parse("2020-09-14 07:56:09")));
                    //IncrementOrder_List_GetResponse incrementOrder_List_GetResponse= pDD_ApiManage.GetIncrementOrderList(incrementOrderListRequest);

                    //Order_Detail_GetRequest order_Detail_GetRequest = new Order_Detail_GetRequest();
                    //order_Detail_GetRequest.order_sn = "200913-277652767482724";
                    //Order_Detail_GetResponse order_Detail_GetResponse = pDD_ApiManage.GetOrderDetailInfo(order_Detail_GetRequest);

                    //Order_List_Range_GetRequest order_List_Range_GetRequest = new Order_List_Range_GetRequest();
                    //order_List_Range_GetRequest.end_time = "2020-09-14 07:56:09";
                    //order_List_Range_GetRequest.start_time = "2020-09-13 07:56:09";
                    //Order_List_Range_List_GetResponse order_List_Range_List_GetResponse = pDD_ApiManage.GetRangeOrderList(order_List_Range_GetRequest);

                    //Member_Authority_QueryRequest member_Authority_QueryRequest = new Member_Authority_QueryRequest();
                    //member_Authority_QueryRequest.custom_parameters = "{\"uid\":\"123\",\"sid\":\"666\"}";
                    //member_Authority_QueryRequest.pid = "1912666_125576394";
                    //Member_Authority_QueryResponse member_Authority_QueryResponse = pDD_ApiManage.GetMemberAuthorityQuery(member_Authority_QueryRequest);

                    //Rp_Prom_Url_GenerateRequest rp_Prom_Url_GenerateRequest = new Rp_Prom_Url_GenerateRequest();
                    //rp_Prom_Url_GenerateRequest.channel_type = 10;
                    //rp_Prom_Url_GenerateRequest.custom_parameters = "{\"uid\":\"123\",\"sid\":\"666\"}";
                    //rp_Prom_Url_GenerateRequest.p_id_list = new string[] { "1912666_125576394" };
                    //rp_Prom_Url_GenerateRequest.generate_short_url = true;
                    //Rp_Prom_Url_GenerateResponse rp_Prom_Url_GenerateResponse = pDD_ApiManage.Get_Rp_Prom_Url_Generate(rp_Prom_Url_GenerateRequest);

                    Good_SearchRequest good_SearchRequest = new Good_SearchRequest();
                    //good_SearchRequest.goods_id_list = new string[] { "177521731055" };
                    good_SearchRequest.keyword = "https://p.pinduoduo.com/doXbmz4V";
                    good_SearchRequest.pid = "1912666_125576394";
                    //good_SearchRequest.custom_parameters= "{\"uid\":\"123\",\"sid\":\"666\"}";
                    Good_Search_ListResponse good_Search_ListResponse = pDD_ApiManage.Good_Search_List(good_SearchRequest);
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
