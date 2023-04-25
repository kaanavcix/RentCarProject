using Bussiness.Abstract;
using Bussiness.Constant;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class RentalService : IRentalService
    {

        private IRentalDal _rentalDal;
        private IUserDal _userDal;
        private ICustomerDal _customerDal;
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate == null)
            {
                _rentalDal.Add(rental);

                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IDataResult<List<RentCarDto>> GetAll()
        {

            return new SuccessDataResult < List<RentCarDto>>(_rentalDal.GetAllRentCar(),SuccessMessageConstant.RentalGetMessage);


        }
        public IDataResult<RentCarDto> GetById(int id)
        {
            return new SuccessDataResult<RentCarDto>(_rentalDal.GetRentCar(r=>r.Id==id), SuccessMessageConstant.RentalGetMessage);

        }
    }
}
