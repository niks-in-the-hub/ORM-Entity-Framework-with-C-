namespace SalesApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SalesApp.Data.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;  //if true, when we create migration, entity framework will check the database when the application runs and it will update database.
        }

        protected override void Seed(SalesApp.Data.SalesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            context.Regions.AddOrUpdate(
                p => p.Id,
                new SalesRegion
                {
                    Active = true,
                    Code = "NTH",
                    CreatedBy = "Admin",
                    CreateDate = DateTime.Now,
                    Id = 1,
                    Name = "North Region",
                    SalesTarget = 10000.00M,
                    UpdatedBy = "Admin",
                    UpdatedDate = DateTime.Now
                },

                 new SalesRegion
                 {
                     Active = true,
                     Code = "STH",
                     CreatedBy = "Admin",
                     CreateDate = DateTime.Now,
                     Id = 2,
                     Name = "South Region",
                     SalesTarget = 10000.00M,
                     UpdatedBy = "Admin",
                     UpdatedDate = DateTime.Now
                 }

                );



            context.People.AddOrUpdate(
               p => p.Id,
               new SalesPerson
               {
                   Active = true,
                   CreatedBy = "Admin",
                   CreateDate = DateTime.Now,
                   FirstName = "Nikkitha",
                   LastName = "Ramesh",
                   Id = 1,
                   RegionId = 1,
                   SalesTarget = 2000.00M,
                   UpdatedBy = "Admin",
                   UpdatedDate = DateTime.Now
               }
               );


            context.Sales.AddOrUpdate(
              p => p.Id,
              new Sale
              {
                  Amount = 321.45M,
                  CreatedBy = "Admin",
                  CreateDate = DateTime.Now,
                  Date = new DateTime(2019, 6, 23),
                  Id = 1,
                  PersonId = 1,
                  RegionId = 1,
                  UpdatedBy = "Admin",
                  UpdatedDate = DateTime.Now
              }
              ); ;
        }
    }
}
