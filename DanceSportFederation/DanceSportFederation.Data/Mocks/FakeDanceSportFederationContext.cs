using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanceSportFederation.Data.Interfaces;
using DanceSportFederation.Models.EntityModels;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DanceSportFederation.Data.Mocks
{
    public class FakeDanceSportFederationContext : IDanceSportFederationContext
    {
        public FakeDanceSportFederationContext()
        {
                this.Competitions = new FakeCompetitionDbSet();
        }

        public DbSet<Competition> Competitions { get; set; }

        public int SaveChanges()
        {
            return 0;
        }
    }
}
