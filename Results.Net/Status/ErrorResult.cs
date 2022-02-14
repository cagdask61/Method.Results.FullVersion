using Results.Net.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Status
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
