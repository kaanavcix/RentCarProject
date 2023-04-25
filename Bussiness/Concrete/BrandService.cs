using Bussiness.Abstract;
using Bussiness.Constant;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class BrandService : IBrandService
    {


        private IBrandDal _brandDal ;


        public BrandService(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand!=null)
            {
                _brandDal.Add(brand);
                return new SuccessResult(SuccessMessageConstant.ColorSuccessMessage);

            }
            return new ErrorResult(ErrorMessageConstant.BrandFailMessage);
        }

        public IResult Delete(Brand brand)
        {
            if (brand != null)
            {
                _brandDal.Delete(brand);
                return new SuccessResult(SuccessMessageConstant.BrandDeleteMessage);

            }
            return new ErrorResult(ErrorMessageConstant.BrandFailMessage);
        }

        public IDataResult<List<Brand>> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(filter),SuccessMessageConstant.BrandGetDataMessage);
        }

        public IDataResult<Brand> GetById(int BrandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b=>b.Id==BrandId), SuccessMessageConstant.BrandGetDataMessage);
        }

        public IResult Update(Brand brand)
        {
            if (brand != null)
            {
                _brandDal.Update(brand);
                return new SuccessResult(SuccessMessageConstant.BrandUpdateMessage);

            }
            return new ErrorResult(ErrorMessageConstant.BrandFailMessage);
        }
    }
}
