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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CarService : ICarService
    {



        private ICarDal _carDal;
        private IColorDal _colorDal;
        private IBrandDal _brandDal;
       
        public CarService(IColorDal colorDal,IBrandDal brandDal, ICarDal carDal) {
            _brandDal = brandDal;
            _carDal = carDal;
            _colorDal = colorDal;
        }
        private void GetSupportId(CarDetailDto model, out int BrandId, out int ColorId)
        {
            _brandDal.Add(new Brand() { Name = model.BrandName });
            _colorDal.Add(new Color() { Name = model.ColorName });
            BrandId = _brandDal.Get(b => b.Name == model.BrandName).Id;
            ColorId = _colorDal.Get(c => c.Name == model.ColorName).Id;
            if (model == null && BrandId == null && ColorId == null) _ = new ErrorResult(ErrorMessageConstant.CarFailMessage);
        }
        private void GetSupportUpdate(CarDetailDto model, out int BrandId, out int ColorId)
        {
            BrandId = _brandDal.Get(b => b.Name == model.BrandName).Id;
            ColorId = _colorDal.Get(c => c.Name == model.ColorName).Id;
            _brandDal.Update(new Brand() { Name = model.BrandName, Id = BrandId });
            _colorDal.Update(new Color() { Name = model.ColorName, Id = ColorId });

            if (model == null) _ = new ErrorResult(ErrorMessageConstant.CarFailMessage);
        }
        public IResult Add(CarDetailDto model)
        {
            int BrandId, ColorId;
            GetSupportId(model, out BrandId, out ColorId);

            _carDal.Add(new Car() {
               BrandId = BrandId,
                ColorId = ColorId,
                DailyPrice = model!.DailyPrice,
                Description = model.Description,
                ModelYear = model.ModelYear});

            return new SuccessResult(SuccessMessageConstant.CarSuccessMessage);
        }

 
        public IResult Delete(CarDetailDto model)
        {
            int BrandId, ColorId;
            GetSupportUpdate(model, out BrandId, out ColorId);

            _carDal.Delete(
                new Car()
                {
                    
                    BrandId = BrandId,
                    ColorId = ColorId,
                    DailyPrice = model!.DailyPrice,
                    Description = model.Description,
                    ModelYear = model.ModelYear
                });

            return new SuccessResult(SuccessMessageConstant.CarSuccessMessage);
        }
        public IResult Update(CarDetailDto model)
        {
            int BrandId, ColorId;
            GetSupportId(model, out BrandId, out ColorId);

            _carDal.Update(new Car()
            {
                BrandId = BrandId,
                ColorId = ColorId,
                DailyPrice = model!.DailyPrice,
                Description = model.Description,
                ModelYear = model.ModelYear
            });

            return new SuccessResult(SuccessMessageConstant.CarSuccessMessage);
        }


        public IDataResult<List<CarDetailDto>> GetAll(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetAllCar(filter).ToList(), SuccessMessageConstant.CarGetMessage);

        }

        public IDataResult<CarDetailDto> GetById(int id)
        {
            return new SuccessDataResult<CarDetailDto>(_carDal.GetById(c=> c.Id == id), SuccessMessageConstant.CarGetMessage);
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandId(int brandId)
        {
           var carId = _carDal.Get(b => b.BrandId == brandId);

            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetAllCar(c => c.Id == carId.Id).ToList(),SuccessMessageConstant.CarGetMessage);
        }

        public IDataResult<List<CarDetailDto>> GetCarsByColorId(int colorId)
        {
            var carId = _carDal.Get(b => b.ColorId == colorId);

            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetAllCar(c => c.Id == carId.Id).ToList(), SuccessMessageConstant.CarGetMessage);
        }

        
    }

   
    
}
