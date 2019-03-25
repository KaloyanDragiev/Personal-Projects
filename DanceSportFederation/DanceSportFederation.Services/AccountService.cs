using DanceSportFederation.Models.EntityModels;
using DanceSportFederation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceSportFederation.Services
{
    public class AccountService : Service, IAccountService
    {
        public void CreateTrainer(ApplicationUser user)
        {
            Trainer trainer = new Trainer();
            ApplicationUser currentTrainer = this.Context.Users.Find(user.Id);
            trainer.User = currentTrainer;
            this.Context.Trainers.Add(trainer);
            this.Context.SaveChanges();
        }
    }
}
