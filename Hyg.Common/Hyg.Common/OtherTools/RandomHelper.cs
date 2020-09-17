/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : RandomHelper.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 18:08:39 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.OtherTools
{
    /// <summary>
    /// RandomHelper
    /// </summary>
    public class RandomHelper
    {
        public static int GetRandomTimeByConfig()
        {
            return GetRandom(CommonCacheConfig.randomTimeEntity.MinValue * 1000, CommonCacheConfig.randomTimeEntity.MaxValue * 1000);
        }
        /// <summary>
        /// 常规随机
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static int GetRandom(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);
        }

        /// <summary>
        /// 按秒数随机
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        public static int GetRandomSecond(int minValue, int maxValue)
        {
            return GetRandom(minValue * 1000, maxValue * 1000);
        }

        /// <summary>
        /// 按分钟随机
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static int GetRandomMinute(int minValue, int maxValue)
        {
            return GetRandom(minValue * 60 * 1000, maxValue * 60 * 1000);
        }
    }
}
