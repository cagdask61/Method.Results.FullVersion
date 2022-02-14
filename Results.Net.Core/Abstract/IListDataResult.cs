using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Core.Abstract
{
    public interface IListDataResult<TEntity> : IResult
    {
        List<TEntity> ListData { get; }
        int Count { get; }
    }
}
