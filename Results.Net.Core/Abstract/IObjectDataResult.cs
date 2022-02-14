using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Core.Abstract
{
    public interface IObjectDataResult : IResult
    {
        object Data { get; }
        TEntity Get<TEntity>();
    }
}
