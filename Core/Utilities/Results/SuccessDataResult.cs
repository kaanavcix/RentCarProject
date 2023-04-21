﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<TData> : DataResult<TData>, IDataResult<TData>
    {
        public SuccessDataResult(TData data) : base(data, true)
        {
        }

        public SuccessDataResult(TData data,string message) : base(data,true, message)
        {
        }
        public SuccessDataResult(string message):base(default, true,message) {

        }
    }
}
