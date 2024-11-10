using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _CarDal;

        public CarManager(ICarDal CarDal)
        {
            _CarDal = CarDal;
        }
        public bool Add(Car Car)
        {
            _CarDal.Add(Car);
            return true;
        }

        public bool Delete(Car Car)
        {
            _CarDal.Delete(Car);
            return true;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return _CarDal.Get(x => x.IsDeleted == false && x.DailyPrice > 0 && x.Description.Length >= 2);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _CarDal.GetAll(x => x.IsDeleted == false && x.DailyPrice > 0 && x.Description.Length >= 2);
        }

        public bool Update(Car Car)
        {
            _CarDal.Update(Car);
            return true;
        }
    }
}
