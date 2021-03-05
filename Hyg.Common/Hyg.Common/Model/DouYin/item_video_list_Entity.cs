/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : item_video_list_Entity.cs
创建人员 : Mr.Hu
创建时间 : 2021-02-22 17:07:18 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.Model.DouYin
{
    /// <summary>
    /// item_video_list_Entity
    /// </summary>
  #region 抖音视频详情解析
    public class play_addr_Entity
    {
        public string uri { get; set; }
        public List<string> url_list { get; set; }
    }

    public class douyin_video_Entity
    {
        public play_addr_Entity play_addr { get; set; }
    }

    public class item_video_Entity
    {
        public douyin_video_Entity video { get; set; }
    }

    public class item_video_list_Entity
    {
        public List<item_video_Entity> item_list { get; set; }
    }
    #endregion
}
