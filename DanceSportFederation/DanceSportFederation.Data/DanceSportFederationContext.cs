using DanceSportFederation.Data.Interfaces;
using DanceSportFederation.Data.Migrations;

namespace DanceSportFederation.Data
{
    using DanceSportFederation.Models.EntityModels;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    public class DanceSportFederationContext : IdentityDbContext<ApplicationUser> 
    {
        public DanceSportFederationContext()
            : base("Data Source=tcp:danceserver.database.windows.net,1433;Initial Catalog=DanceSport;User ID=spinar;Password=#Minspi31;integrated security=False;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {
            //Data Source=tcp:danceserver.database.windows.net,1433;Initial Catalog=DanceSport;User ID=spinar;Password=#Minspi31
            //data source=DESKTOP-BLM9A1N;initial catalog=DanceSportFederation;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DanceSportFederationContext, Configuration>());
        }

        public DbSet<Trainer> Trainers { get; set; }

        public DbSet<Competition> Competitions { get; set; }

        public static DanceSportFederationContext Create()
        {
            return new DanceSportFederationContext();
        }

    }
}