using Results.Net.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Core.Status
{
    public class ErrorDataResult<TEntity> : DataResult<TEntity>
    {
        public ErrorDataResult() : base(false, default)
        {
        }
        public ErrorDataResult(TEntity data):base(false,data)
        {
        }
        public ErrorDataResult(string message) : base(false, default,message:message)
        {
        }
        public ErrorDataResult(TEntity data,string message) : base(false,data:data,message:message)
        {
        }

    }
}
