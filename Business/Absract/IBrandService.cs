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
        List<Brand> GetAll();

        public Brand GetByBrandId(int brandId);

        public void Add(Brand brand);
        public void Update(Brand brand);
        public void Delete(Brand brand);

    }
}
