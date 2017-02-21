using DomainClasses.Entities;

namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<DataLayer.dbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DataLayer.dbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //context.Organizations.AddOrUpdate(
            //  p => p.Id,
            //  new Organization { Name = "TaxiDriving",Desc = "This Units Organize Taxis"},
            //  new Organization { Name = "CityMaking", Desc = "This Units Organize City Buildings" }

            //);

        }
    }
}
