﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class DataResult<TData> : Result, IDataResult<TData>

    {
        public TData Data { get; }

        public DataResult(TData data, bool success) : base(success)
        {
            Data = data;
        }

        public DataResult(TData data, bool success, string message) : base(success, message)
        {
            Data = data;
        }




    }
}
