using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Core.Abstract
{
    public interface IDataResult<TEntity> : IResult
    {
        TEntity Data { get; }
    }
}
