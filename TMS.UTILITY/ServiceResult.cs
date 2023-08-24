using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.UTILITY
{
    public class ServiceResult<T>
    {
        int StatusCode;
        string Message;
        string Error;
        T Data;
        public ServiceResult()
        {
            StatusCode = 404;
            Message = "Page Not Found";
            Error = string.Empty;
        }
        public void SetSucces()
        {
            StatusCode = 200;
            Message = "Success";
            Error = "Error";
        }
        public void SetSucces(T data)
        {
            StatusCode = 200;
            Message = "Success";
            Error = string.Empty;
            Data = data;

        }
        public void SetFailuer(string error)
        {
            StatusCode = 417;
            Message = "Failed";
            Error = error;
        }

        public void BadRequest(string error)
        {
            StatusCode = 400;
            Message = "Bad Request ";
            Error = error;  
        }
    }
}
