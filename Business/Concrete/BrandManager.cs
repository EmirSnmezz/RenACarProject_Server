using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public bool Add(Brand brand)
        {
            _brandDal.Add(brand);
            return true;
        }

        public bool Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return true;
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            return _brandDal.Get(filter);
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return _brandDal.GetAll(filter);
        }

        public bool Update(Brand brand)
        {
             _brandDal.Update(brand);
            return true;
        }
    }
}
