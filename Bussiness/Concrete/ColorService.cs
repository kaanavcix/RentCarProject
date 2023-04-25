using Bussiness.Abstract;
using Bussiness.Constant;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Results;
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
    public class ColorService :IColorService
    {
        private IColorDal _colorDal;


        public ColorService(IColorDal colorDal)
        {
            _colorDal = colorDal;  
        }

        public IResult Add(Color color)
        {
            if (color != null)
            {
                _colorDal.Add(color);
                return new SuccessResult(SuccessMessageConstant.ColorSuccessMessage);

            }
            return new ErrorResult(ErrorMessageConstant.ColorFailMessage);
        }

        public IResult Delete(Color color)
        {
            if (color != null)
            {
                _colorDal.Delete(color);
                return new SuccessResult(SuccessMessageConstant.ColorDeleteMessage);

            }
            return new ErrorResult(ErrorMessageConstant.ColorFailMessage);
        }

        public IDataResult<List<Color>> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(filter), SuccessMessageConstant.ColorGetDataMessage);
        }

        public IDataResult<Color> GetById(int ColorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == ColorId), SuccessMessageConstant.ColorGetDataMessage);
        }

        public IResult Update(Color color)
        {
            if (color != null)
            {
                _colorDal.Update(color);
                return new SuccessResult(SuccessMessageConstant.ColorUpdateMessage);

            }
            return new ErrorResult(ErrorMessageConstant.ColorFailMessage);
        }
    
}
}
