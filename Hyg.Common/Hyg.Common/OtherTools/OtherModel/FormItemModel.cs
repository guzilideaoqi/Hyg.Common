/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : FormItemModel.cs
创建人员 : Mr.Hu
创建时间 : 2021-03-16 17:51:14 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Hyg.Common.OtherTools.OtherModel
{
    /// <summary>
    /// FormItemModel
    /// </summary>
    public class FormItemModel
    {
        /// <summary>
        /// 表单键，request["key"]
        /// </summary>
        public string Key { set; get; }
        /// <summary>
        /// 表单值,上传文件时忽略，request["key"].value
        /// </summary>
        public string Value { set; get; }
        /// <summary>
        /// 是否是文件
        /// </summary>
        public bool IsFile
        {
            get
            {
                if (FileContent == null || FileContent.Length == 0)
                    return false;

                if (FileContent != null && FileContent.Length > 0 && string.IsNullOrWhiteSpace(FileName))
                    throw new Exception("上传文件时 FileName 属性值不能为空");
                return true;
            }
        }
        /// <summary>
        /// 上传的文件名
        /// </summary>
        public string FileName { set; get; }
        /// <summary>
        /// 上传的文件内容
        /// </summary>
        public Stream FileContent { set; get; }
    }
}
