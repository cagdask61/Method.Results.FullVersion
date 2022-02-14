using Results.Net.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Core.Concrete
{
    public class Result : IResult
    {
        public Result(bool status)
        {
            Status = status;
        }

        public Result(bool status,string message):this(status)
        {
            Message = message;
        }


        public bool Status { get; }

        public string Message { get; }
    }
}
