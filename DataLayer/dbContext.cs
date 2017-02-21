using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Entities;
using EFSecondLevelCache;
using System.Data.Entity.Core.Objects;

namespace DataLayer
{
  public  class dbContext:DbContext
    {

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationStatistics> OrganizationStatisticses { get; set; }

        //:base("")
        public dbContext()
        {
            
        }
        public override int SaveChanges()
        {
            return SaveAllChanges(invalidateCacheDependencies: true);
        }
        public int SaveAllChanges(bool invalidateCacheDependencies = true)
        {
            var changedEntityNames = getChangedEntityNames();
            var result = base.SaveChanges();
            if (invalidateCacheDependencies)
            {
                new EFCacheServiceProvider().InvalidateCacheDependencies(changedEntityNames);
            }
            return result;
        }
        private string[] getChangedEntityNames()
        {
            return this.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Added ||
                            x.State == EntityState.Modified ||
                            x.State == EntityState.Deleted)
                .Select(x => ObjectContext.GetObjectType(x.Entity.GetType()).FullName)
                .Distinct()
                .ToArray();
        }



    }
}
