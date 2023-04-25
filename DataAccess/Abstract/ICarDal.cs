using Core.DataAccess;
using Entity.Concrete;
using Entity.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {


        List<CarDetailDto> GetAllCar(Expression<Func<CarDetailDto, bool>> filter =null);
        CarDetailDto GetById(Expression<Func<CarDetailDto, bool>> filter);

        void Add(CarDetailDto model);
        void Update(CarDetailDto model); 
        void Delete(CarDetailDto model);
    }
}
