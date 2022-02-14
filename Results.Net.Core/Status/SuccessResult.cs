using Results.Net.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Core.Status
{
    public class SuccessResult : Result
    {
        public SuccessResult():base(true)
        {
        }
        public SuccessResult(string message) : base(true,message)
        {
        }
    }
}
