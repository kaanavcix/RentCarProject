using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Entity.Concrete;
using Entity.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IRentalService
    {

        IResult Add(Rental rental);
        IDataResult<List<RentCarDto>> GetAll();
        IDataResult<RentCarDto> GetById(int id);
    }
}
