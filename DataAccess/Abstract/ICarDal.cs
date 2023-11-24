﻿using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstacts
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto>GetCarDetails();

    }
}
