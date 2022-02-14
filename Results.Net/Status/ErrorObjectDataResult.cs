using Results.Net.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Status
{
    public class ErrorObjectDataResult : ObjectDataResult
    {
        public ErrorObjectDataResult() : base(false, data: default)
        {
        }
        public ErrorObjectDataResult(object data) : base(false, data: data)
        {
        }
        public ErrorObjectDataResult(string message) : base(false, data: default, message: message)
        {
        }
        public ErrorObjectDataResult(object data, string message) : base(false, data: data, message: message)
        {
        }
    }
}
