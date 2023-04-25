using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, DatabaseContext>, IRentalDal
    {
        public void Add(RentCarDto rentCarDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(RentCarDto rentCarDto)
        {
            throw new NotImplementedException();
        }

        public List<RentCarDto> GetAllRentCar(Expression<Func<RentCarDto, bool>> expression = null)
        {
            return FundamentalMethod().Where(expression).ToList();
        }

        private IQueryable<RentCarDto> FundamentalMethod()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers on r.CustomerId equals
                               c.Id
                             join car in context.Cars on r.CarId equals car.Id
                             join u in
                               context.Users on c.UserId equals u.Id
                             join b in context.Brands on car.BrandId equals b.Id
                             join col in context.Colors on car.ColorId equals col.Id
                             orderby r.Id ascending
                             select new RentCarDto()
                             {
                                 Id = r.Id,
                                 BrandName = b.Name,
                                 ColorName = col.Name,
                                 CompanyName = c.CompanyName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };

                return result;
            }
        }

        public RentCarDto GetRentCar(Expression<Func<RentCarDto, bool>> expression)
        {
            return FundamentalMethod().SingleOrDefault(expression);
        }

        public void Update(RentCarDto rentCarDto)
        {
            throw new NotImplementedException();
        }
    }
}
