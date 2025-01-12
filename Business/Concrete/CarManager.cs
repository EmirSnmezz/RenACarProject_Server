using Business.Abstract;
using Business.ValidatonRules.FluentValidation;
using Core.Aspects.ValidationAspect;
using DataAccess.Abstract;
using Entity.Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _CarDal;

        public CarManager(ICarDal CarDal)
        {
            _CarDal = CarDal;
        }

        [ValidationAspect(typeof(CarValidations))]
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

        public List<Car> GetAll(Expression<Func<Car, bool>>? filter = null)
        {
            return _CarDal.GetAll(x => x.IsDeleted == false);
        }

        public bool Update(Car Car)
        {
            _CarDal.Update(Car);
            return true;
        }
    }
}
