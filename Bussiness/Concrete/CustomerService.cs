using Bussiness.Abstract;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CustomerService : ICustomerService
    {
        public IResult Add(Customer user)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteByUserId(string username)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Customer> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Customer> GetByUserId(string username)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Customer user)
        {
            throw new NotImplementedException();
        }
    }
}
