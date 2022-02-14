﻿using Results.Net.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Net.Status
{
    public class SuccessDataResult<TEntity> : DataResult<TEntity>
    {

        public SuccessDataResult(TEntity data) : base(true, data)
        {
        }

        public SuccessDataResult(TEntity data, string message) : base(true, data, message)
        {
        }

    }
}
