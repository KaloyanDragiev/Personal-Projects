using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanceSportFederation.Models.EntityModels;
using DanceSportFederation.Models.ViewModels.User;
using AutoMapper;
using DanceSportFederation.Models.BindingModels.Users;
using DanceSportFederation.Services.Interfaces;

namespace DanceSportFederation.Services
{
    public class UsersService : Service, IUsersService
    {
        public Trainer GetCurrentTrainer(string userName)
        {
            var user = Context.Users.FirstOrDefault(ap => ap.UserName == userName);
            Trainer currentTrainer = Context.Trainers.FirstOrDefault(cp => cp.User.Id == user.Id);
            return currentTrainer;
        }

        public void EnrollCoupleInCompetition(int competitionId, Trainer trainer)
        {
            Competition wantedCompetition = this.Context.Competitions.Find(competitionId);
            trainer.Competitions.Add(wantedCompetition);
            this.Context.SaveChanges();
        }

        public ProfileVm GetProfileVm(string userName)
        {
            ApplicationUser currentUser = this.Context.Users.FirstOrDefault(user => user.UserName == userName);
            ProfileVm vm = Mapper.Map<ApplicationUser, ProfileVm>(currentUser);
            Trainer trainer = this.Context.Trainers.FirstOrDefault(tr => tr.User.Id == currentUser.Id);
            vm.EnrolledCompetitions = Mapper.Map<IEnumerable<Competition>, IEnumerable<UserCompetitionVm>>(trainer.Competitions);
            return vm;
        }

        public EditUserVm GetEditVm(string userName)
        {
            ApplicationUser user = this.Context.Users.FirstOrDefault(ap => ap.UserName == userName);
            EditUserVm vm = Mapper.Map<ApplicationUser, EditUserVm>(user);

            return vm;
        }

        public void EditUser(EditUserBm bind, string currentName)
        {
            ApplicationUser user = this.Context.Users.FirstOrDefault(ap => ap.UserName == currentName);
            user.Name = bind.Name;
            user.Couple = bind.Couple;
            user.Club = bind.Club;
            this.Context.SaveChanges();
        }
    }
}
