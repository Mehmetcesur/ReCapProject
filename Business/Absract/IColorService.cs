using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absract
{
    public interface IColorService
    {
        List<Color> GetAll();
            
        public Color GetByColorId(int colorId);

        public void Add(Color color);
        public void Update(Color color);
        public void Delete(Color color);
    }
}
