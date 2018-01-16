using ManageMuseum.Models;

namespace ManageMuseum.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ManageMuseum.Models.OurContectDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ManageMuseum.Models.OurContectDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //context.UserAccounts.AddOrUpdate(x => x.FirstName,
            //    new UserAccount() { FirstName = "Jessica", LastName = "Franco", Username = "jsfranco", Password = "igualparatodos", Role = "spacemanager" },
            //    new UserAccount() { FirstName = "Tiago", LastName = "Gouveia", Username = "jtmg", Password = "igualparatodos", Role = "artpiecemanager" },
            //    new UserAccount() { FirstName = "Andre", LastName = "Figueira", Username = "ffigueira", Password = "igualparatodos", Role = "artpiecemanager" }
            //);
            //context.SaveChanges();

            
        }
    }
}
