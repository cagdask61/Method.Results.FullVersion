using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Abstract
{
    public interface IObjectDataResult : IResult
    {
        object Data { get; }
        TEntity Get<TEntity>();
    }
}
