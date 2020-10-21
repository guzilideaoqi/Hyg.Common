/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : Pdd_TonkenInfoEntity.cs
创建人员 : Mr.Hu
创建时间 : 2020-10-21 14:37:28 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDModel
{
    /// <summary>
    /// Pdd_TonkenInfoEntity
    /// </summary>
    public class Pdd_TokenInfoEntity
    {
        /// <summary>
        /// 刷新token的过期时间
        /// </summary>
        public long refresh_token_expires_in { get; set; }

        /// <summary>
        /// w1级别API或字段的访问过期时间；	10（表示10秒后过期）
        /// </summary>
        public long w1_expires_in { get; set; }

        /// <summary>
        /// 商家账号名称
        /// </summary>
        public string owner_name { get; set; }

        /// <summary>
        /// 商家店铺id
        /// </summary>
        public string owner_id { get; set; }

        /// <summary>
        /// w2级别API或字段的访问过期时间点
        /// </summary>
        public long w2_expires_at { get; set; }

        /// <summary>
        /// r2级别API或字段的访问过期时间点
        /// </summary>
        public long r2_expires_at { get; set; }

        /// <summary>
        /// access_token
        /// </summary>
        public string access_token { get; set; }

        /// <summary>
        /// refresh token，可用来刷新access_token
        /// </summary>
        public string refresh_token { get; set; }

        /// <summary>
        /// w2级别API或字段的访问过期时间；10（表示10秒后过期）
        /// </summary>
        public long w2_expires_in { get; set; }

        /// <summary>
        /// Refresh token过期时间点
        /// </summary>
        public long refresh_token_expires_at { get; set; }

        /// <summary>
        /// access_token过期时间点
        /// </summary>
        public long expires_at { get; set; }

        /// <summary>
        /// r1级别API或字段的访问过期时间；	10（表示10秒后过期）
        /// </summary>
        public long r1_expires_in { get; set; }

        /// <summary>
        /// 接口列表
        /// </summary>
        public List<string> scope { get; set; }

        /// <summary>
        /// w1级别API或字段的访问过期时间点
        /// </summary>
        public long w1_expires_at { get; set; }

        /// <summary>
        /// r2级别API或字段的访问过期时间；10（表示10秒后过期）
        /// </summary>
        public long r2_expires_in { get; set; }

        /// <summary>
        /// r1级别API或字段的访问过期时间点
        /// </summary>
        public long r1_expires_at { get; set; }

        /// <summary>
        /// access_token过期时间段，10（表示10秒后过期）
        /// </summary>
        public long expires_in { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string request_id { get; set; }
    }
}
