using Hyg.Common;
using Hyg.Common.DTKTools;
using Hyg.Common.DTKTools.DTKRequest;
using Hyg.Common.DTKTools.DTKResponse;
using Hyg.Common.DuoMaiTools;
using Hyg.Common.DuoMaiTools.DuoMaiModel;
using Hyg.Common.DuoMaiTools.DuoMaiRequest;
using Hyg.Common.HaoDanKu;
using Hyg.Common.HaoDanKu.HaoDanKuRequest;
using Hyg.Common.JDTools;
using Hyg.Common.JDTools.JDRequest;
using Hyg.Common.JTT_Tools;
using Hyg.Common.JTT_Tools.JTTRequest;
using Hyg.Common.OtherTools;
using Hyg.Common.OtherTools.OtherModel;
using Hyg.Common.PDDTools;
using Hyg.Common.PDDTools.PDDRequest;
using Hyg.Common.PDDTools.PDDResponse;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TestTool
{
    class Program
    {
        const int plaformType = 7;//1=淘宝  2=京东  3=拼多多 4=好单库 5=京推推 6=淘宝官方 7=多麦商城
        static void Main(string[] args)
        {
            try
            {
                //获取当前进程对象
                /*Process cur = Process.GetCurrentProcess();

                PerformanceCounter curpcp = new PerformanceCounter("Process", "Working Set - Private", cur.ProcessName);
                PerformanceCounter curpc = new PerformanceCounter("Process", "Working Set", cur.ProcessName);
                PerformanceCounter curtime = new PerformanceCounter("Process", "% Processor Time", cur.ProcessName);

                //上次记录CPU的时间
                TimeSpan prevCpuTime = TimeSpan.Zero;
                //Sleep的时间间隔
                int interval = 2000;

                PerformanceCounter totalcpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");

                 SystemInfoHelper sys = new SystemInfoHelper();

                const int KB_DIV = 1024;
                const int MB_DIV = 1024 * 1024;
                const int GB_DIV = 1024 * 1024 * 1024;
                while (true)
                {
                    //第一种方法计算CPU使用率
                    //当前时间
                    TimeSpan curCpuTime = cur.TotalProcessorTime;
                    //计算
                    double value = (curCpuTime - prevCpuTime).TotalMilliseconds / interval / Environment.ProcessorCount * 100;
                    prevCpuTime = curCpuTime;

                    Console.WriteLine("{0}:{1}  {2:N}KB CPU使用率：{3}", cur.ProcessName, "工作集(进程类)", cur.WorkingSet64 / 1024, value);//这个工作集只是在一开始初始化，后期不变
                    Console.WriteLine("{0}:{1}  {2:N}KB CPU使用率：{3}", cur.ProcessName, "工作集        ", curpc.NextValue() / 1024, value);//这个工作集是动态更新的
                                                                                                                                      //第二种计算CPU使用率的方法
                    Console.WriteLine("{0}:{1}  {2:N}KB CPU使用率：{3}%", cur.ProcessName, "私有工作集    ", curpcp.NextValue() / 1024, curtime.NextValue() / Environment.ProcessorCount);
                    //Thread.Sleep(interval);

                    //第一种方法获取系统CPU使用情况
                    Console.WriteLine("\r系统CPU使用率：{0}%", totalcpu.NextValue());
                    //Thread.Sleep(interval);

                    //第二章方法获取系统CPU和内存使用情况
                    Console.WriteLine("\r系统CPU使用率：{0}%，系统内存使用大小：{1}MB({2}GB) cpu个数{3}", sys.CpuLoad.ToString("0.00"), (sys.PhysicalMemory - sys.MemoryAvailable) / MB_DIV, ((sys.PhysicalMemory - sys.MemoryAvailable) / (double)GB_DIV).ToString("0.00"), sys.ProcessorCount);
                    Console.WriteLine("内存使用率:{0}-{1}-{2}", sys.PhysicalMemory, sys.MemoryAvailable,(((double)(sys.PhysicalMemory - sys.MemoryAvailable) / sys.PhysicalMemory)*100).ToString("0.00"));
                    System.Threading.Thread.Sleep(interval);
                }

                Console.ReadLine();return;*/
                //string str = "<msg fromusername=\"wxid_54foqo0ljj8o22\" encryptusername=\"v3_020b3826fd030100000000000820218c94415f000000501ea9a3dba12f95f6b60a0536a1adb638b49bee2336de06a68d500849630220d5d551dcf955e29006ee779c5c42d39231eae976a7661b1df69e336e26e7606ce25ebbc530a51c9c6955388459@stranger\" fromnickname=\"pretty girl\" content=\"陈涛\" fullpy=\"prettygirl\" shortpy=\"PRETTYGIRL\" imagestatus=\"3\" scene=\"17\" country=\"AE\" province=\"Al Fujayrah\" city=\"\" sign=\"涛少\" percard=\"1\" sex=\"1\" alias=\"aawjwj\" weibo=\"\" albumflag=\"0\" albumstyle=\"0\" albumbgimgid=\"\" snsflag=\"257\" snsbgimgid=\"http://szmmsns.qpic.cn/mmsns/PDHwiaPWZh0fPh5YzXyH5IS9uvUC4O4omVa3h9SCGGhadEKlJgv9BPsibtCKcJx7cP9iaA0Z2tzUlI/0\" snsbgobjectid=\"13391932798898090074\" mhash=\"b607b1a83276a3be0e0aa7974445022a\" mfullhash=\"b607b1a83276a3be0e0aa7974445022a\" bigheadimgurl=\"http://wx.qlogo.cn/mmhead/ver_1/xQUKJxs4mQrJNzhYsOMqn1LjBr3uhNbBoIfYbQbHJ26dmTMv09gb5qcYZnc5QEib0TaX6QzVmibjNpzgibicJWB8vtEBD7mFfhCOMn5jKdy2JLk/0\" smallheadimgurl=\"http://wx.qlogo.cn/mmhead/ver_1/xQUKJxs4mQrJNzhYsOMqn1LjBr3uhNbBoIfYbQbHJ26dmTMv09gb5qcYZnc5QEib0TaX6QzVmibjNpzgibicJWB8vtEBD7mFfhCOMn5jKdy2JLk/96\" ticket=\"v4_000b708f0b040000010000000000ffe375e707cbd824f3d77246745f1000000050ded0b020927e3c97896a09d47e6e9e288fd4394783ba8b82f3b8c372064c0a5d30fae7976a7d4fa49fba9b7e83ef0fb48d3c5ec017fa72b6ee868cff77fadc2b9133c2d75f792b1530aa960709438df7d0d7a8b7058d5324b543e81acc349da850e9b4bd2d773f5a8d29f40db6e437a885ae8dd57038434b23bc0baf605942b847b844a495c6286f2d148a314e51515744c5dffe6d735799ab4e722cc718dcc77671380fc435cf3dd95f721cf9aec35d33d40d7fdf349c3e173a77b0210f35047f156f46f3edbffd17c6c0e366e3a237255d66611b701691ce9590aaacfea9ae67d5e8d156674788c2e51133bfa89d9f8aa63360130d2ddc7960a4a602e4f02905ccc88026accb72c0ca7d280a79528a5914d710fc12eb7bfc223ef5dd5498fd7a969078bdfb7cf8@stranger\" opcode=\"2\" googlecontact=\"\" qrticket=\"\" chatroomusername=\"\" sourceusername=\"wxid_z7rjwki6i9yk22\" sourcenickname=\"心凉&她\" sharecardusername=\"wxid_z7rjwki6i9yk22\" sharecardnickname=\"心凉&amp;她\" cardversion=\"0\"><brandlist count=\"0\" ver=\"657547423\"></brandlist></msg>";

                //System.Xml.XmlNode xmlList = XMLHelper.ResolveXML(str, "msg", true);

                CommonCacheConfig.dtk_appkey = "5d2fd0a674e69"; CommonCacheConfig.dtk_appsecret = "7ac9d649468d3603ef506224c9298497";
                CommonCacheConfig.pdd_appkey = "ac48d84bf6064db4be917cd26d71f9bb"; CommonCacheConfig.pdd_appsecret = "ec47368867643a48b5beab50dd97ebaf7fe96f55";
                //CommonCacheConfig.jd_appkey = "a666eb66d3c749e4857354b69476efab"; CommonCacheConfig.jd_appsecret = "2c6e68722c4047de9a95f0ef9519ea14"; CommonCacheConfig.jd_accesstoken = "e4209eac5db9f8e2762718c5ab2212e8fc9d5c76edce579ab144095bbb95ce392c3b86569f18f09a";
                CommonCacheConfig.jd_appkey = "3251e372f6fc4d29bdadaf6c711bd4ea"; CommonCacheConfig.jd_appsecret = "48931357c8ed4c7fbd05698f3db9aae9"; CommonCacheConfig.jd_accesstoken = "e4209eac5db9f8e2762718c5ab2212e8fc9d5c76edce579ab144095bbb95ce392c3b86569f18f09a";
                CommonCacheConfig.jd_appkey = "d6c73647bca31ee72a71c43ba62e3e8e"; CommonCacheConfig.jd_appsecret = "e1744cac6dca4e39b251900ec207d25c"; CommonCacheConfig.jd_accesstoken = "e4209eac5db9f8e26105759966271e486daa066e20b05e7469fd24a2f405573bd9b9ed950fc96e0e";
                CommonCacheConfig.haodanku_apikey = "guzilideaoqi";

                if (plaformType == 1)
                {
                    DTK_ApiManage dTK_ApiManage = new DTK_ApiManage(CommonCacheConfig.dtk_appkey, CommonCacheConfig.dtk_appsecret);
                    int apiType = 21;
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
                            dTK_Get_Good_DetailsRequest.goodsId = "584654276169";
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
                        case 20:
                            DTK_Explosive_Goods_ListRequest dTK_Explosive_Goods_ListRequest = new DTK_Explosive_Goods_ListRequest();
                            dTK_Explosive_Goods_ListRequest.cids = "4";
                            dTK_Explosive_Goods_ListRequest.IsReturnCommonInfo = true;
                            //dTK_Explosive_Goods_ListRequest.pageId = "1";
                            dTK_Explosive_Goods_ListRequest.PriceCid = 1;
                            //dTK_Explosive_Goods_ListRequest.pageSize = 20;
                            apiData = dTK_ApiManage.GetDTK_ExplosiveGoods(dTK_Explosive_Goods_ListRequest);
                            break;
                        case 21:
                            DTK_History_Low_Price_ListRequest dTK_History_Low_Price_ListRequest = new DTK_History_Low_Price_ListRequest();
                            dTK_History_Low_Price_ListRequest.pageId = "1";
                            dTK_History_Low_Price_ListRequest.pageSize = 20;
                            dTK_History_Low_Price_ListRequest.IsReturnCommonInfo = true;
                            apiData = dTK_ApiManage.GetHistoryLowPriceListResponse(dTK_History_Low_Price_ListRequest);
                            break;

                    }

                    Console.WriteLine(apiData.ToJsonStr());
                }
                else if (plaformType == 2)
                {
                    JD_ApiManage jD_ApiManage = new JD_ApiManage(CommonCacheConfig.jd_appkey, CommonCacheConfig.jd_appsecret, CommonCacheConfig.jd_accesstoken);

                    /*超级接口查询京东商品*/
                    Super_GoodQueryRequest super_GoodQueryRequest = new Super_GoodQueryRequest();
                    Super_GoodQueryDetailReq super_GoodQueryDetailReq = new Super_GoodQueryDetailReq();
                    super_GoodQueryRequest.goodsReqDTO = super_GoodQueryDetailReq;
                    jD_ApiManage.Super_GetGoodQueryResultByKeyWord(super_GoodQueryRequest); return;

                    UnionOpenOrderRowQueryRequest unionOpenOrderRowQueryRequest = new UnionOpenOrderRowQueryRequest();
                    UnionOpenOrderRowQueryDetailRequest unionOpenOrderRowQueryDetailRequest = new UnionOpenOrderRowQueryDetailRequest();
                    unionOpenOrderRowQueryDetailRequest.fields = "goodsInfo";
                    unionOpenOrderRowQueryDetailRequest.startTime = "2020-10-11 13:30:00";
                    unionOpenOrderRowQueryDetailRequest.endTime = "2020-10-11 14:30:00";
                    unionOpenOrderRowQueryRequest.orderReq = unionOpenOrderRowQueryDetailRequest;

                    Console.WriteLine("共获取到" + jD_ApiManage.UnionOpenOrderRowQuery(unionOpenOrderRowQueryRequest).data.Count + "条数据!");
                    return;

                    Super_CreatePositionRequest super_CreatePositionRequest = new Super_CreatePositionRequest();
                    super_CreatePositionRequest.positionReq = new Super_CreatePosition_Param
                    {
                        key = CommonCacheConfig.jd_accesstoken,
                        type = 4,
                        spaceNameList = new string[] { "张晓晓" },
                        unionId = 1000534528,
                        unionType = 4
                    };
                    jD_ApiManage.CreatePositionInfo(super_CreatePositionRequest); return;

                    Super_QueryPositionRequest super_QueryPositionRequest = new Super_QueryPositionRequest();
                    super_QueryPositionRequest.positionReq = new Super_QueryPosition_Param
                    {
                        key = CommonCacheConfig.jd_accesstoken,
                        unionId = 1000534528,
                        unionType = 4
                    };
                    jD_ApiManage.Get_PositionList(super_QueryPositionRequest); return;

                    Super_PromotionByToolRequest super_PromotionByToolRequest = new Super_PromotionByToolRequest();
                    super_PromotionByToolRequest.promotionCodeReq = new Super_PromotionByTool
                    {
                        chainType = 3,
                        couponUrl = "http://coupon.m.jd.com/coupons/show.action?key=8dc19f8890cd435cb27527c3bf0e4594&roleId=39852538&to=item.jd.com/71694691599.html#crumb-wrap".ToUrlEncode(),
                        materialId = "http://item.jd.com/71694691599.html",
                        positionId = "1962857866",
                        unionId = "1000534528"
                    };
                    jD_ApiManage.GetConvertLinkByTool(super_PromotionByToolRequest); return;

                    Super_PromotionBySubUnionidRequest super_PromotionBySubUnionidRequest = new Super_PromotionBySubUnionidRequest();
                    super_PromotionBySubUnionidRequest.promotionCodeReq = new Super_PromotionBySubUnionid
                    {
                        chainType = 3,
                        couponUrl = "http://coupon.m.jd.com/coupons/show.action?key=8dc19f8890cd435cb27527c3bf0e4594&roleId=39852538&to=item.jd.com/71694691599.html#crumb-wrap".ToUrlEncode(),
                        materialId = "http://item.jd.com/71694691599.html",
                        positionId = "1962857866"
                    };
                    jD_ApiManage.GetConvertLinkBySubUnionID(super_PromotionBySubUnionidRequest); return;

                    UnionOpenPromotionCommonRequest unionOpenPromotionCommonRequest = new UnionOpenPromotionCommonRequest();
                    PromotionCodeReq promotionCodeReq = new PromotionCodeReq();
                    promotionCodeReq.materialId = "https://item.jd.com/67991567458.html";
                    promotionCodeReq.siteId = "1165439379";
                    promotionCodeReq.positionId = "1962857865";
                    promotionCodeReq.couponUrl = "https://coupon.m.jd.com/coupons/show.action?linkKey=AAROH_xIpeffAs_-naABEFoev-omQ90qgcOsIHlIUcaU0s8QDzcjTaml0M1BB6EQGLHCWXWCqjWgoS7wHI6T8xvDkNaYwg".ToUrlEncode();
                    unionOpenPromotionCommonRequest.promotionCodeReq = promotionCodeReq;
                    Console.WriteLine("转链结果：" + jD_ApiManage.GetConvertLink(unionOpenPromotionCommonRequest));
                    return;

                    Super_QueryCouponRequest super_QueryCouponRequest = new Super_QueryCouponRequest();
                    super_QueryCouponRequest.couponUrls = new string[] { "http://coupon.m.jd.com/coupons/show.action?key=8dc19f8890cd435cb27527c3bf0e4594&roleId=39852538&to=item.jd.com/71694691599.html#crumb-wrap".ToUrlEncode() };
                    jD_ApiManage.Super_QueryCouponInfo(super_QueryCouponRequest); return;




                    Super_QueryPIDRequest super_QueryPIDRequest = new Super_QueryPIDRequest();
                    super_QueryPIDRequest.pidReq = new Super_QueryPID_Param
                    {
                        childUnionId = 0,
                        unionId = 1000534528,
                        positionName = "美嘛_1668656".ToUrlEncode(),
                        promotionType = 2
                    };
                    jD_ApiManage.QueryPIDList(super_QueryPIDRequest); return;


                    GoodQueryRequest goodQueryRequest = new GoodQueryRequest();
                    GoodQueryDetailReq goodQueryDetailReq = new GoodQueryDetailReq();
                    goodQueryDetailReq.eliteId = 1;
                    goodQueryRequest.goodsReq = goodQueryDetailReq;
                    Console.WriteLine("共获取到" + jD_ApiManage.GetGoodQueryResultByKeyWord(goodQueryRequest).jFGoodsRespRows.Count + "条数据!");
                    return;
                }
                else if (plaformType == 3)
                {
                    PDD_ApiManage pDD_ApiManage = new PDD_ApiManage(CommonCacheConfig.pdd_appkey, CommonCacheConfig.pdd_appsecret, "5512f86f18904fa3b879f9b622c9c03467a2e340");
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
                    //good_SearchRequest.keyword = "https://p.pinduoduo.com/doXbmz4V";
                    good_SearchRequest.pid = "1912666_125576394";
                    good_SearchRequest.IsReturnCommonInfo = true;
                    good_SearchRequest.custom_parameters = "{\"uid\":\"123\",\"sid\":\"666\"}";
                    Good_Search_ListResponse good_Search_ListResponse = pDD_ApiManage.Good_Search_List(good_SearchRequest);
                    return;

                    Super_WeApp_Qrcode_UrlRequest super_WeApp_Qrcode_UrlRequest = new Super_WeApp_Qrcode_UrlRequest();
                    super_WeApp_Qrcode_UrlRequest.custom_parameters = "guzilideaoqi";
                    super_WeApp_Qrcode_UrlRequest.p_id = "1912666_177495987";
                    super_WeApp_Qrcode_UrlRequest.zs_duo_id = 1912666;
                    super_WeApp_Qrcode_UrlRequest.goods_id_list = new List<long> { 187281997372 };
                    super_WeApp_Qrcode_UrlRequest.generate_mall_collect_coupon = true;
                    string resultCOntent = super_WeApp_Qrcode_UrlRequest.ToJsonStr();
                    pDD_ApiManage.Super_WeApp_Qrcode_Url(super_WeApp_Qrcode_UrlRequest); return;

                    Super_General_Theme_Prom_UrlRequest super_General_Theme_Prom_UrlRequest = new Super_General_Theme_Prom_UrlRequest();
                    super_General_Theme_Prom_UrlRequest.generate_short_url = true;
                    super_General_Theme_Prom_UrlRequest.custom_parameters = "guzilideaoqi";
                    super_General_Theme_Prom_UrlRequest.pid = "1912666_177495987";
                    super_General_Theme_Prom_UrlRequest.theme_id_list = new long[] { 5 };
                    pDD_ApiManage.Super_General_Theme_Prom_Url(super_General_Theme_Prom_UrlRequest); return;

                    Super_General_RP_Prom_UrlRequest super_General_RP_Prom_UrlRequest = new Super_General_RP_Prom_UrlRequest();
                    super_General_RP_Prom_UrlRequest.channel_type = 10;
                    super_General_RP_Prom_UrlRequest.p_id_list = new string[] { "1912666_177495987" };
                    super_General_RP_Prom_UrlRequest.generate_short_url = true;
                    pDD_ApiManage.Super_General_RP_Prom_Url(super_General_RP_Prom_UrlRequest); return;

                    Super_General_Resource_UrlRequest super_General_Resource_UrlRequest = new Super_General_Resource_UrlRequest();
                    super_General_Resource_UrlRequest.pid = "1912666_177495987";
                    super_General_Resource_UrlRequest.custom_parameters = "guzilideaoqi";
                    super_General_Resource_UrlRequest.resource_type = 39996;
                    pDD_ApiManage.Super_General_Resource_Url(super_General_Resource_UrlRequest); return;

                    Super_Query_Member_AuthorityRequest super_Query_Member_AuthorityRequest = new Super_Query_Member_AuthorityRequest();
                    super_Query_Member_AuthorityRequest.pid = "1912666_177495987";
                    super_Query_Member_AuthorityRequest.custom_parameters = "guzilideaoqi";
                    pDD_ApiManage.Super_Query_Member_Authority(super_Query_Member_AuthorityRequest); return;

                    Super_General_Lottery_UrlRequest super_General_Lottery_UrlRequest = new Super_General_Lottery_UrlRequest();
                    super_General_Lottery_UrlRequest.custom_parameters = "guzilideaoqi";
                    super_General_Lottery_UrlRequest.pid_list = new string[] { "1912666_177495987" };
                    super_General_Lottery_UrlRequest.generate_short_url = true;
                    super_General_Lottery_UrlRequest.multi_group = true;
                    super_General_Lottery_UrlRequest.generate_weapp_webview = true;
                    pDD_ApiManage.Super_General_Lottery_Url(super_General_Lottery_UrlRequest); return;

                    Super_General_ZS_Unit_UrlRequest super_General_ZS_Unit_UrlRequest = new Super_General_ZS_Unit_UrlRequest();
                    super_General_ZS_Unit_UrlRequest.custom_parameters = "guzilideaoqi";
                    super_General_ZS_Unit_UrlRequest.pid = "1912666_177495987";
                    super_General_ZS_Unit_UrlRequest.source_url = "https://p.pinduoduo.com/WCHbe8ZL";
                    pDD_ApiManage.Super_General_ZS_Unit_Url(super_General_ZS_Unit_UrlRequest); return;

                    Super_QueryRecommendGoodRequest super_QueryRecommendGoodRequest = new Super_QueryRecommendGoodRequest();
                    pDD_ApiManage.Super_GetRecommendGoodList(super_QueryRecommendGoodRequest); return;

                    Super_GeneralGoodPromUrlRequest super_GeneralGoodPromUrlRequest = new Super_GeneralGoodPromUrlRequest();
                    super_GeneralGoodPromUrlRequest.goods_id_list = new string[] { "187281997372" };
                    super_GeneralGoodPromUrlRequest.zs_duo_id = "1912666";
                    super_GeneralGoodPromUrlRequest.p_id = "1912666_177495987";
                    super_GeneralGoodPromUrlRequest.custom_parameters = "guzilideaoqi";
                    pDD_ApiManage.Super_GeneralGoodPromUrl(super_GeneralGoodPromUrlRequest); return;

                    Super_QueryGoodPIDRequest super_QueryGoodPIDRequest = new Super_QueryGoodPIDRequest();
                    super_QueryGoodPIDRequest.page = 1;
                    super_QueryGoodPIDRequest.page_size = 50;
                    super_QueryGoodPIDRequest.pid_list = new string[] { "1912666_177599033" };
                    pDD_ApiManage.Super_QueryGoodPID(super_QueryGoodPIDRequest); return;

                    Super_GeneralGoodPIDRequest super_GeneralGoodPIDRequest = new Super_GeneralGoodPIDRequest();
                    super_GeneralGoodPIDRequest.number = 1;
                    super_GeneralGoodPIDRequest.p_id_name_list = new string[] { "张晓晓" };
                    pDD_ApiManage.Super_GeneralGoodPID(super_GeneralGoodPIDRequest); return;

                    Super_General_CMS_Prom_UrlRequest super_General_CMS_Prom_UrlRequest = new Super_General_CMS_Prom_UrlRequest();
                    super_General_CMS_Prom_UrlRequest.channel_type = 4;
                    super_General_CMS_Prom_UrlRequest.p_id_list = new string[] { "1912666_177495987" };
                    super_General_CMS_Prom_UrlRequest.generate_we_app = true;
                    super_General_CMS_Prom_UrlRequest.generate_short_url = true;
                    super_General_CMS_Prom_UrlRequest.generate_mobile = true;
                    super_General_CMS_Prom_UrlRequest.generate_schema_url = true;
                    pDD_ApiManage.Super_General_CMS_Prom_Url(super_General_CMS_Prom_UrlRequest); return;

                    Goods_Zs_UnitGenerateRequest goods_Zs_UnitGenerateRequest = new Goods_Zs_UnitGenerateRequest();
                    goods_Zs_UnitGenerateRequest.custom_parameters = "guzilideaoqi";
                    goods_Zs_UnitGenerateRequest.pid = "1912666_177495987";
                    goods_Zs_UnitGenerateRequest.source_url = "https://p.pinduoduo.com/WCHbe8ZL";
                    pDD_ApiManage.Super_Good_Convert_Link(goods_Zs_UnitGenerateRequest); return;

                    Super_GetAllIncrementOrderRequest super_GetAllIncrementOrderRequest = new Super_GetAllIncrementOrderRequest();
                    super_GetAllIncrementOrderRequest.start_update_time = DateTimeHelper.ConvertDateTimeToInt(DateTime.Now.AddDays(-1));
                    super_GetAllIncrementOrderRequest.end_update_time = DateTimeHelper.ConvertDateTimeToInt(DateTime.Now);
                    pDD_ApiManage.Super_GetAllIncrementOrder(super_GetAllIncrementOrderRequest); return;
                }
                else if (plaformType == 4)
                {
                    HaoDanKu_GetOrienteeringItemsRequest haoDanKu_GetOrienteeringItemsRequest = new HaoDanKu_GetOrienteeringItemsRequest();
                    haoDanKu_GetOrienteeringItemsRequest.apikey = CommonCacheConfig.haodanku_apikey;
                    haoDanKu_GetOrienteeringItemsRequest.back = 20;
                    haoDanKu_GetOrienteeringItemsRequest.min_id = 1;
                    HaoDanKu_ApiManage haoDanKu_ApiManage = new HaoDanKu_ApiManage();
                    haoDanKu_ApiManage.GetOrienteeringItems(haoDanKu_GetOrienteeringItemsRequest);
                }
                else if (plaformType == 5)
                {
                    JTT_ApiManage jTT_ApiManage = new JTT_ApiManage("2004222117227673", "4ded804729f2b7eb389895e51ffafc5a");

                    int apiType = 2;
                    switch (apiType)
                    {
                        case 0:
                            JTT_SuperCategoryRequest jTT_SuperCategoryRequest = new JTT_SuperCategoryRequest();

                            jTT_ApiManage.GetSuperCategory(jTT_SuperCategoryRequest);
                            break;
                        case 1:
                            JTT_CollectionGoodsRequest jTT_CollectionGoodsRequest = new JTT_CollectionGoodsRequest();
                            jTT_ApiManage.GetCollection_Goods(jTT_CollectionGoodsRequest);
                            break;
                        case 2:
                            JTT_BugGoodsRequest jTT_BugGoodsRequest = new JTT_BugGoodsRequest();
                            jTT_ApiManage.GetBug_GoodsList(jTT_BugGoodsRequest);
                            break;
                    }

                }
                else if (plaformType == 7) {
                    DuoMai_ApiManage duoMai_ApiManage = new DuoMai_ApiManage("437579", "227f424324003391b6880f04b5d66d9d");

                    ///订单结算变动查询
                    Get_Open_Order_SettlementRequest get_Open_Order_SettlementRequest = new Get_Open_Order_SettlementRequest();
                    get_Open_Order_SettlementRequest.stime = "1613446000";
                    get_Open_Order_SettlementRequest.etime = "1613448000";
                    duoMai_ApiManage.Get_Open_Order_SettlementList(get_Open_Order_SettlementRequest);

                    ///订单详情明细查询
                    Query_Open_Order_DetailRequest query_Open_Order_DetailRequest = new Query_Open_Order_DetailRequest();
                    query_Open_Order_DetailRequest.order_sn = "111";
                    query_Open_Order_DetailRequest.ads_id = "168";
                    duoMai_ApiManage.Get_Open_Order_Detail(query_Open_Order_DetailRequest); 

                    Query_Open_Order_ListRequest query_Open_Order_ListRequest = new Query_Open_Order_ListRequest();
                    query_Open_Order_ListRequest.stime = "1613446000";
                    query_Open_Order_ListRequest.etime = "1613448000";
                    duoMai_ApiManage.Query_Open_Order_List(query_Open_Order_ListRequest); return;

                    ///商城列表
                    Query_CPS_Open_StoreRequest query_CPS_Open_StoreRequest = new Query_CPS_Open_StoreRequest();
                    duoMai_ApiManage.Get_CPS_Stores_List(query_CPS_Open_StoreRequest);return;



                    ///推广计划详情
                    Query_Cps_Stores_PlansDetailRequest query_Cps_Stores_PlansDetailRequest = new Query_Cps_Stores_PlansDetailRequest();
                    query_Cps_Stores_PlansDetailRequest.ads_id = "168";
                    duoMai_ApiManage.Get_CPS_Stores_Plans_Detail(query_Cps_Stores_PlansDetailRequest); return;

                    CPS_Convert_LinkRequest cPS_Convert_LinkRequest = new CPS_Convert_LinkRequest();
                    cPS_Convert_LinkRequest.ads_id = "168";
                    cPS_Convert_LinkRequest.ext = new CPS_Convert_Link_ext
                    {
                        euid = "guzilideaoqi"
                    };
                    cPS_Convert_LinkRequest.site_id = "437582";
                    duoMai_ApiManage.Get_CPS_Convert_Link(cPS_Convert_LinkRequest);return;





                    //查询推广计划
                    Query_CPS_Stores_PlansRequest query_CPS_Stores_PlansRequest = new Query_CPS_Stores_PlansRequest();
                    duoMai_ApiManage.Query_CPS_Stores_Plans(query_CPS_Stores_PlansRequest);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
