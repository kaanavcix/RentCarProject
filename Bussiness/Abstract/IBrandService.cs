using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IBrandService
    {

        IDataResult<List<Brand>> GetAll(Expression<Func<Brand,bool>> filter =null);
        IDataResult<Brand> GetById(int BrandId);
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);


    }
}
