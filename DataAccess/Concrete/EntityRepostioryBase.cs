using DataAccess.Abstract;
using Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EntityRepostioryBase<T> : IEntityRepository<T> where T : class, IEntity, new()
    {
        public void Add(T entity)
        {
            using (RentACartDbContext context = new RentACartDbContext())
            {
                EntityEntry addedEntity = context.Set<T>().Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(T entity)
        {
            using(RentACartDbContext context = new RentACartDbContext())
            {
                EntityEntry deletedEntity = context.Set<T>().Entry(entity);
                entity.IsDeleted = true;
                deletedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using(RentACartDbContext context = new RentACartDbContext())
            {
                T data =  context.Set<T>().FirstOrDefault(filter);
                return data;
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using(RentACartDbContext context = new RentACartDbContext())
            {
                return filter == null ?  context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T entity)
        {
           using(RentACartDbContext context = new RentACartDbContext())
            {
                EntityEntry updatedEntity = context.Set<T>().Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
