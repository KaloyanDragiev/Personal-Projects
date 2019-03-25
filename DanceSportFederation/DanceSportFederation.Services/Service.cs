using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DanceSportFederation.Data;

namespace DanceSportFederation.Services
{
    public abstract class Service
    {
        public Service()
        {
            this.Context = new DanceSportFederationContext();
        }

        protected DanceSportFederationContext Context { get; }


        //public Service(IdentityDbContext<ApplicationUser> context)
        //{
        //    this.Context = context;
        //}
        //
        //protected IdentityDbContext<ApplicationUser> Context { get; }
    }
}
