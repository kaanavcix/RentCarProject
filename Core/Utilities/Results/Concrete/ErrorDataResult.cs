using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class ErrorDataResult<TData> : DataResult<TData>
    {
        public ErrorDataResult(TData data) : base(data, false)
        {
        }


        public ErrorDataResult(TData data, string message) : base(data, false, message)
        {
        }

        public ErrorDataResult(string message) : base(default, false)
        {

        }


    }
}
