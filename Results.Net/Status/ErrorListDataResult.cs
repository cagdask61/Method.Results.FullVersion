using Results.Net.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Status
{
    public class ErrorListDataResult<TEntity> : ListDataResult<TEntity>
    {
        public ErrorListDataResult():base(false,default)
        {
        }

        public ErrorListDataResult(string message) : base(false, default,message:message)
        {
        }

        public ErrorListDataResult(List<TEntity> listData) : base(false, listData)
        {
        }

        public ErrorListDataResult(List<TEntity> listData,string message) : base(false,listData:listData,message:message)
        {
        }

    }
}
