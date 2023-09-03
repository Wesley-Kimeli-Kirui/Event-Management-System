using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApplication.Response
{
    public class UserSuccess
    {
        public string Message { get; set; } = string.Empty;
        public int Code { get; set; }

        public UserSuccess(string message, int code)
        {
            this.Message = message;
            this.Code = code;
        }

    }
}