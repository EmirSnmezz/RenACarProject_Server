using Entity.Entities.Abstract;
using Entity.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class RentACartDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=EMIRSNMEZ;database=RentACarDb;Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries<IEntity>().ToList();
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property(p => p.CreatedDate).CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    if (entry.Property(p => p.IsDeleted).CurrentValue == true)
                    {
                        entry.Property(p => p.DeletedDate).CurrentValue = DateTime.Now;
                    }
                    else
                    {
                        entry.Property(p => p.UpdatedDate).CurrentValue = DateTime.Now;
                    }
                }

            }
            return base.SaveChanges();
        }
    }
}
