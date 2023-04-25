using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.DTO_s;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Color = Entity.Concrete.Color;

namespace DataAccess.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DatabaseContext>, ICarDal
    {
        public void Add(CarDetailDto model)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
               
                var model2 = new Brand() {
                    Name = model.BrandName
                };
                var model3 = new Color()
                {
                    Name = model.ColorName

                };


                
                var model1 = new Car()
                {
              //      BrandId   = model2.Id,ColorId = mode

                };
                var addedEntry = context.Entry(model1);
                var addedEntry2 = context.Entry(model2);
                var addedEntry3 = context.Entry(model3);



            }
          
        }

        public void Delete(CarDetailDto model)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetAllCar(Expression<Func<CarDetailDto, bool>> filter=null)
        {
            
                return filter == null ?FundamentalMethod().ToList() : FundamentalMethod().Where(filter).ToList();
            
        }

        public CarDetailDto GetById(Expression<Func<CarDetailDto, bool>> filter) => FundamentalMethod().SingleOrDefault(filter);

        private  IQueryable<CarDetailDto> FundamentalMethod()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join co in context.Colors on c.ColorId equals co.Id
                             select new CarDetailDto()
                             {
                                 ColorName = co.Name,
                                 BrandName = b.Name,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear
                             };
                return result;

            }
        }

        public void Update(CarDetailDto model)
        {
           
        }

        
    }
}
