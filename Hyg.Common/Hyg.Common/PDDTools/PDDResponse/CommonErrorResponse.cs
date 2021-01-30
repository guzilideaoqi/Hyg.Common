/*===================================Copyright© 2021 xxx Ltd. All rights reserved.==============================

文件类名 : CommonErrorResponse.cs
创建人员 : Mr.Hu
创建时间 : 2021-01-27 14:29:33 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyg.Common.PDDTools.PDDResponse
{
    ///
    /// {"error_response":{"error_msg":"业务服务错误","sub_msg":"未传入已经授权备案过的相关参数(pid/custom_parameters), 授权备案说明链接：https://jinbao.pinduoduo.com/qa-system?questionId=204","sub_code":"60001","error_code":50001,"request_id":"16117287939674146"}}
    /// <summary>
    /// CommonErrorResponse
    /// </summary>
    public class CommonResponse
    {
        private ErrorResponse _error_response;
        public ErrorResponse error_response { get { if (_error_response != null) IsError = true; return _error_response; } set { _error_response = value; } }

        public bool IsError { get; set; }
    }

    public class ErrorResponse {
        public string error_msg { get; set; }
        public string sub_msg { get; set; }
        public string sub_code { get; set; }
        public string error_code { get; set; }

        public string request_id { get; set; }
    }
}
