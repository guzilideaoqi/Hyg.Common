﻿/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : DateTimeHelper.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-21 16:02:34 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.OtherTools.OtherModel
{
    /// <summary>
    /// DateTimeHelper
    /// </summary>
    public class DateTimeHelper
    {
        /// <summary>
        /// 时间戳生成
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string ConvertDateTimeToInt(DateTime time)
        {
            DateTime dateTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0));
            return ((time.Ticks - dateTime.Ticks) / 10000000L).ToString();
        }
    }
}