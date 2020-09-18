/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DTK_TB_Service_GoodItem.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-18 10:03:22 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.DTKTools.DTKModel
{
    /// <summary>
    /// DTK_TB_Service_GoodItem
    /// </summary>
    public class DTK_TB_Service_GoodItem
    {
        public string title { get; set; }
        public int volume { get; set; }
        public string nick { get; set; }
        public string coupon_start_time { get; set; }
        public string coupon_end_time { get; set; }
        public string tk_total_sales { get; set; }
        public string coupon_id { get; set; }
        public string pict_url { get; set; }
        public images small_images { get; set; }
        public string reserve_price { get; set; }
        public string zk_final_price { get; set; }
        public int user_type { get; set; }
        public string commission_rate { get; set; }
        public string seller_id { get; set; }
        public string coupon_total_count { get; set; }
        public string coupon_remain_count { get; set; }
        public string coupon_info { get; set; }
        public string shop_title { get; set; }
        public string shop_dsr { get; set; }
        public string level_one_category_name { get; set; }
        public int level_one_category_id { get; set; }
        public string category_name { get; set; }
        public string category_id { get; set; }
        public string short_title { get; set; }
        public string white_image { get; set; }
        public string coupon_start_fee { get; set; }
        public string coupon_amount { get; set; }
        public string item_description { get; set; }
        public string item_id { get; set; }
        public string ysyl_tlj_face { get; set; }
        public string presale_deposit { get; set; }
        public string presale_discount_fee_text { get; set; }
    }

    public class images
    {
        public List<string> images_detail { get; set; }
    }
}
