using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Abstract
{
    public interface IDataResult<TEntity> : IResult
    {
        TEntity Data { get; }
    }
}
