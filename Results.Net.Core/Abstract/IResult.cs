using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Core.Abstract
{
    public interface IResult : IBaseResult
    {
        bool Status { get; }
        string  Message { get; }
    }
}
