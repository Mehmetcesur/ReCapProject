using Business.Absract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colordal;
        public ColorManager(IColorDal colorDal)
        {
                _colordal = colorDal;
        }

        public void Add(Color color)
        {
            _colordal.Add(color);
        }

        public void Delete(Color color)
        {
            _colordal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colordal.GetAll();
        }

        public Color GetByColorId(int colorId)
        {
            return _colordal.Get(c=>c.ColorId == colorId);
        }

        public void Update(Color color)
        {
             _colordal.Update(color);
        }
    }
}
