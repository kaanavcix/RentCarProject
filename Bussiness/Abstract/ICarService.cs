using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Entity.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ICarService
    {

        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetAll(Expression<Func<CarDetailDto, bool>> filter =null);
        IDataResult<CarDetailDto> GetById(int id);
        IResult Add(CarDetailDto model);
        IResult Update(CarDetailDto model);
        IResult Delete(CarDetailDto model);   
            }
}
