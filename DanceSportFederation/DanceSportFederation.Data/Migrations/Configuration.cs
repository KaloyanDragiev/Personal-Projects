namespace DanceSportFederation.Data.Migrations
{
    using DanceSportFederation.Models.EntityModels;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DanceSportFederation.Data.DanceSportFederationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(DanceSportFederation.Data.DanceSportFederationContext context)
        {
            if (!context.Roles.Any(role => role.Name == "Trainer"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Trainer");
                manager.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "Moderator"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Moderator");
                manager.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Admin");
                manager.Create(role);
            }


            context.Competitions.AddOrUpdate(competition => competition.Name, new Competition[]
                {
                    new Competition()
                    {
                        Name = "Something",
                        Description ="National",
                        StartDate = new DateTime(2017, 12, 21),
                        EndDate = new DateTime(2017, 03, 23),
                    },
                    new Competition()
                    {
                        Name = "Something2",
                        Description ="National2",
                        StartDate = new DateTime(2017, 10, 21),
                        EndDate = new DateTime(2017, 03, 23),
                    },
                    new Competition()
                    {
                        Name = "Something3",
                        Description ="National3",
                        StartDate = new DateTime(2017, 06, 21),
                        EndDate = new DateTime(2017, 03, 23),
                    },
                    new Competition()
                    {
                        Name = "Something4",
                        Description ="National4",
                        StartDate = new DateTime(2017, 09, 21),
                        EndDate = new DateTime(2017, 03, 23),
                    }

                });
        }
    }
}
