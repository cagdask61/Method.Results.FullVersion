using Results.Net.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Core.Status
{
    public class ErrorResult : Result
    {
        public ErrorResult():base(false)
        {
        }
        public ErrorResult(string message) : base(false,message)
        {
        }
    }
}
