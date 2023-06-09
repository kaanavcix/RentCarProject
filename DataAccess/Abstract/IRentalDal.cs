﻿using Core.DataAccess;
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
    public interface IRentalDal:IEntityRepository<Rental>
    {

        List<RentCarDto> GetAllRentCar(Expression<Func<RentCarDto,bool>> expression =null);
        RentCarDto GetRentCar(Expression<Func<RentCarDto, bool>> expression);
        void Add(RentCarDto rentCarDto);
        void Update(RentCarDto rentCarDto);
        void Delete(RentCarDto rentCarDto);
    }
}
