using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Abstract
{
    public interface ISingleDataResult<TEntity> : IResult
    {
        TEntity SingleData { get; }
    }
}
