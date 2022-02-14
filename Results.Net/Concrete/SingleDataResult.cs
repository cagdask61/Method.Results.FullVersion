using Results.Net.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Concrete
{
    public class SingleDataResult<TEntity> : Result, ISingleDataResult<TEntity>
    {
        public SingleDataResult(bool status,TEntity singleData):base(status)
        {
            SingleData = singleData;
        }

        public SingleDataResult(bool status, TEntity singleData,string message) : base(status,message)
        {
            SingleData = singleData;
        }

        public TEntity SingleData { get; }
    }
}
