/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : DouYinHelper.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-22 17:04:42 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.Model.DouYin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.OtherTools
{
    /// <summary>
    /// 抖音助手
    /// </summary>
    public class DouYinHelper
    {
        #region 抖音视频去水印
        public static string ClearDouYinWater(string douyin_video_url)
        {
            string playAddr = "";

            try
            {
                /*第一步：解析抖音视频短链接获取视频id
                 *第二步：根据视频id获取原始视频地址
                 *第三步: 替换原始地址中的信息得到无水印视频
                 */

                douyin_video_url = RegularHelper.getValue(@"(https|http)(://v.douyin.com/[a-zA-Z0-9]{7,})", douyin_video_url);

                string resultContent = AjaxRequest.GetRedirectUrl(douyin_video_url);//获取视频重定向地址

                string item_id = RegularHelper.getValue("(?<=(video/)).*?(?=(/))", resultContent);
                if (item_id.IsEmpty())
                    throw new Exception("未解析到视频ID!");

                var webHtml = AjaxRequest.HttpGet("https://www.iesdouyin.com/web/api/v2/aweme/iteminfo/?item_ids=" + item_id, "");
                item_video_list_Entity item_Video_List_Entity = Newtonsoft.Json.JsonConvert.DeserializeObject<item_video_list_Entity>(webHtml);
                if (!item_Video_List_Entity.IsEmpty() && item_Video_List_Entity.item_list.Count > 0)
                {
                    List<string> url_List = item_Video_List_Entity.item_list[0].video.play_addr.url_list;
                    if (url_List.Count > 0)
                    {
                        playAddr = url_List[0].Replace("playwm", "play");
                    }
                    else
                    {
                        throw new Exception("未解析到视频信息!");
                    }
                }
                else {
                    throw new Exception("未解析到视频信息!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return playAddr;
        }
        #endregion
    }
}
