/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : JTT_CollectionGoodsResponse.cs
创建人员 : Mr.Hu
创建时间 : 2020-12-24 15:58:50 
备注说明 : 

 =====================================End=======================================================*/
using Hyg.Common.JTT_Tools.JTTModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.JTT_Tools.JTTResponse
{
    /// <summary>
    /// 京推推我的收藏返回参数
    /// </summary>
    public class JTT_CollectionGoodsResponse : JTT_CommonResponse
    {
        public List<JTT_CollectionGoodsEntity> result { get; set; }
    }
}
