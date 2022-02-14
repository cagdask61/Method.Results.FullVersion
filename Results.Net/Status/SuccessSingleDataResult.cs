using Results.Net.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Status
{
    public class SuccessSingleDataResult<TEntity> : SingleDataResult<TEntity>
    {
        public SuccessSingleDataResult(TEntity singleData):base(true,singleData:singleData)
        {
        }
        public SuccessSingleDataResult(TEntity singleData,string message) : base(true, singleData: singleData,message:message)
        {
        }
    }
}
