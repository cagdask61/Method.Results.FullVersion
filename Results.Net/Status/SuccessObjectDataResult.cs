using Results.Net.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Status
{
    public class SuccessObjectDataResult : ObjectDataResult
    {
        public SuccessObjectDataResult(object data):base(true,data:data)
        {
        }

        public SuccessObjectDataResult(object data,string message) : base(true, data: data,message:message)
        {
        }

    }
}
