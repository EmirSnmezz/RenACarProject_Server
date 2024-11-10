using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        public bool Add(Brand brand);
        public bool Delete(Brand brand);
        public bool Update(Brand brand);
        public Brand Get(Expression<Func<Brand, bool>> filter);
        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null);
    }
}
