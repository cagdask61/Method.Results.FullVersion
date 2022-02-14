using Results.Net.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Core.Concrete
{
    public class ObjectDataResult : Result, IObjectDataResult
    {
        public ObjectDataResult(bool status,object data):base(status)
        {
            Data = data;
        }

        public ObjectDataResult(bool status, object data,string message) : base(status,message)
        {
            Data = data;
        }

        public object Data { get; }

        public TEntity Get<TEntity>()
        {
            TEntity entity = (TEntity)Data;
            return entity;
        }
    }
}
