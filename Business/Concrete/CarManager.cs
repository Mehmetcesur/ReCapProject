﻿using Business.Abstract;
using DataAccess.Abstacts;
using Entities.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }

        public void Add(Car car)
        {

            _cardal.Add(car);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _cardal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _cardal.GetAll(c => c.ColorId == id);

        }
    }
}
