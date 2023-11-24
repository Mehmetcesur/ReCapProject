using Core.DataAccess.EntityFramework;
using DataAccess.Abstacts;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                             var result = from ca in context.Cars
                             join b in context.Brands on ca.BrandId equals b.BrandId
                             join co in context.Colors on ca.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarId = ca.Id,
                                 CarName = ca.Name,
                                 BrandName = b.Name,
                                 ColorName = co.Name,
                                 DailyPrice = ca.DailyPrice
                             };
                return result.ToList();


            }
        }
    }
}
