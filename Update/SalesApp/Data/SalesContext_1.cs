using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Data
{
    class SalesContext : DbContext
    {
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalesPerson> People { get; set; }
        public DbSet<SalesRegion> Regions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)  //override what entity framework has defined for OnModelCretating.
        {
            base.OnModelCreating(modelBuilder);

            //changing how it works
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

           // modelBuilder.Entity<Sale>().HasRequired(e => e.Person);  //this is what [Required] does.
        }


        public override int SaveChanges()  //override the SaveChanges().
        {
            ChangeTracker.DetectChanges();  //Makes sure entity has all changes sorted out before we make changes with custom function.

            //Soft Delete - When someone deltetes an entity and clicks "SaveChanges", checks if deleted, it wont physically delete from database, but just sets Active flag to FALSE.
            var stateManager = ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager;  //stateManager detects the state of any entities. (when created, deleted, updated, etc..)


            //give it particular state we are looking for.
            var deletedEntities = stateManager
                .GetObjectStateEntries(EntityState.Deleted)  //grab only deleted entities.
                .Select(e => e.Entity)  //we only want the entity itself.
                .OfType<IActive>()  //Only entities with IActive, implement this functionality. others, can be deleted from the database.
                .ToArray();  //To hold the list of entities.

            foreach (var deletedEntity in deletedEntities)
            {
                if (deletedEntity == null) continue;  //Null check..
                stateManager.ChangeObjectState(deletedEntity, EntityState.Modified);  //Saying DONOT DELETE IT. Using the Modified so that information is saved in the database. but not going to attempt to delete it.
                deletedEntity.Active = false;

            }




            var createdEntities = stateManager
               .GetObjectStateEntries(EntityState.Added)  //grab only created entities.
               .Select(e => e.Entity)  //we only want the entity itself.
               .OfType<BaseModel>()  //Only entities with BaseModel, implement this functionality.
               .ToArray();  //To hold the list of entities.
            
            foreach (var createdEntity in createdEntities)
            {
                createdEntity.CreateDate = DateTime.Now;
                createdEntity.CreatedBy = Environment.UserName;  //Use current windows user's name and put in the database.
                createdEntity.UpdatedDate = DateTime.Now;
                createdEntity.UpdatedBy = Environment.UserName;

            }




            var updatedEntities = stateManager
             .GetObjectStateEntries(EntityState.Modified)  //grab only updated entities.
             .Select(e => e.Entity)  //we only want the entity itself.
             .OfType<BaseModel>()  //Only entities with BaseModel, implement this functionality.
             .ToArray();  //To hold the list of entities.

            foreach (var updatedEntity in updatedEntities)
            {
                updatedEntity.UpdatedDate = DateTime.Now;
                updatedEntity.UpdatedBy = Environment.UserName;

            }
            return base.SaveChanges();  //return integer: number of models that have been changed.
        }
    }
}
