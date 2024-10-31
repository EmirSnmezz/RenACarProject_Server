using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities.Concrete
{
    public class Color : IEntity
    {
        public string Guid { get; set; }
        public string Name { get; set; }
    }
}
