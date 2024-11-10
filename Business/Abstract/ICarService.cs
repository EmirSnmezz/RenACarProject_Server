using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        public bool Add(Car car);
        public bool Delete(Car car);
        public bool Update(Car car);
        public Car Get(Expression<Func<Car, bool>> filter);
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null);
    }
}
