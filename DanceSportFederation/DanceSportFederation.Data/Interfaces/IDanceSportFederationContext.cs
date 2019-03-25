using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanceSportFederation.Models.EntityModels;

namespace DanceSportFederation.Data.Interfaces
{
    public class IDanceSportFederationContext
    {
        DbSet<Competition> Competitions { get; set; }
        
    }
}
