using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Add(
              new Rental
              {
                  UserId = 1,
                  CustomerId = 1,
                  CarId = 1,
                  RentDate = new DateTime(2022, 10, 11),
                  ReturnDate = new DateTime(2022, 10, 15)
              });
            Console.WriteLine(result.Message);

            //var result = rentalManager.Delete(
            //  new Rental
            //  {
            //      Id = 1,
            //  });

            //Console.WriteLine(result.Message);


            //CarManager carManager = new CarManager(new EfCarDal());
            //Car car = new Car() { Name = "Skoda", BrandId = 1,ColorId = 1, ModelYear = 2023, DailyPrice = 1500, Description = "1.6" };
            //carManager.Add(car);

            //Car car = new Car() { Id=1002};
            //carManager.Delete(car);






            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Name);
            //}
            //Console.WriteLine("***************");
            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(car.Name);
            //}
            //Console.WriteLine("***************");

            //foreach (var car in carManager.GetCarsByColorId(1))
            //{
            //    Console.WriteLine(car.Name);
            //}
            //Console.WriteLine("***************");
            //var result =carManager.GetCarDetails();

            //if (result.Success==true)
            //{
            //    foreach (var car in carManager.GetCarDetails().Data)
            //    {
            //        Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            //    }
            //}

            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


        }

    }
}