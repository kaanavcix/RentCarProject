using Core.Utilities.Results.Abstract;
using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetById(int id);
        IDataResult<Customer> GetByUserId(string username);
        IResult Add(Customer user);
        IResult Update(Customer user);
        IResult DeleteById(int id);
        IResult DeleteByUserId(string username);
    }
}
