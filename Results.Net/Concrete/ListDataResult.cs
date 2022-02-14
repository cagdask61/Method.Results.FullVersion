using Results.Net.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Concrete
{
    public class ListDataResult<TEntity> : Result,IListDataResult<TEntity>
    {
        public ListDataResult(bool status,List<TEntity> listData):base(status)
        {
            ListData = listData;
        }

        public ListDataResult(bool status, List<TEntity> listData,string message) : base(status,message)
        {
            ListData = listData;
        }

        public List<TEntity> ListData { get; }

        public int Count { get => ListData.Count; }
    }
}
