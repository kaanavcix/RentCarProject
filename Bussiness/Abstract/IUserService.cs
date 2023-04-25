using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IUserService
    {

        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
        IDataResult<User> GetByUsername(string username);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IResult DeleteByUsername(string username);

    }
}
