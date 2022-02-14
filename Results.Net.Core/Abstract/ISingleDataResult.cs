using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Core.Abstract
{
    public interface ISingleDataResult<TEntity> : IResult
    {
        TEntity SingleData { get; }
    }
}
