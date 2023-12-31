﻿using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absract
{
    public interface IBrandService 
    {
        IDataResult<List<Brand>> GetAll();

        IDataResult<Brand> GetByBrandId(int brandId);

        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);

    }
}
