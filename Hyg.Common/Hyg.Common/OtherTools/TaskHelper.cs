/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : TaskHelper.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 16:42:49 
备注说明 : 任务帮助类

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Hyg.Common.OtherTools
{
    public class TaskHelper
    {
        public static Thread ExcuteNewTask(Action action, int sleep)
        {
            Thread thread = new Thread(() =>
             {
                 Thread.Sleep(sleep);
                 action();
             });
            thread.IsBackground = true;
            thread.Start();

            return thread;
        }

        public static void Sleep(int time) {
            Thread.Sleep(time);
        }
    }
}
