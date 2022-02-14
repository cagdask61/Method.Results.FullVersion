using Results.Net.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Core.Status
{
    public class ErrorSingleDataResult<TEntity> : SingleDataResult<TEntity>
    {
        public ErrorSingleDataResult() : base(false, singleData: default)
        {
        }
        public ErrorSingleDataResult(TEntity singleData) : base(false, singleData: singleData)
        {
        }
        public ErrorSingleDataResult(string message) : base(false, singleData: default, message: message)
        {
        }
        public ErrorSingleDataResult(TEntity singleData, string message) : base(false, singleData: singleData, message: message)
        {
        }
    }
}
