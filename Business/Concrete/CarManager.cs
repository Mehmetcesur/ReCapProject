using Business.Abstract;
using DataAccess.Abstacts;
using Entities.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Dtos;
using Core.Utilities.Results;
using Business.Constant;
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules.FluentValidation;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 3)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Car>>(_cardal.GetAll(),Messages.CarsListed);
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)     
        {
                

            _cardal.Add(car);

            return new Result(true, Messages.CarAdded);
        }
        public IResult Update(Car car)
        {
            _cardal.Update(car);

            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            _cardal.Delete(car);                        

            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(c => c.BrandId == id))                           ;
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(c => c.ColorId == id));

        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_cardal.GetCarDetails());
        }

      
    }
}
