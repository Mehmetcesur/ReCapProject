using DataAccess.Abstacts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1,BrandId=1,ColorId=5,DailyPrice=10000,Description="Spor",ModelYear=2020 }, 
                new Car {Id=2,BrandId=1,ColorId=6,DailyPrice=20000,Description="Spor",ModelYear=2021 }, 
                new Car {Id=3,BrandId=2,ColorId=7,DailyPrice=30000,Description="Klasik",ModelYear=2021 }, 
                new Car {Id=4,BrandId=3,ColorId=8,DailyPrice=40000,Description="Coupe",ModelYear=2022 }, 
                new Car {Id=5,BrandId=3,ColorId=3,DailyPrice=50000,Description="Klasik",ModelYear=2023 }, 
                
            
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {

            var carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(b => b.Id == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id= car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
