using Results.Net.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Core.Status
{
    public class SuccessListDataResult<TEntity> : ListDataResult<TEntity>
    {
        public SuccessListDataResult(List<TEntity> listData):base(true,listData)
        {
        }

        public SuccessListDataResult(List<TEntity> listData,string message) : base(true,listData:listData,message:message)
        {
        }
    }
}
