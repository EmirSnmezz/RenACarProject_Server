using DataAccess.Abstract;
using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CarDal : EntityRepostioryBase<Car>, ICarDal
    {
    }
}
