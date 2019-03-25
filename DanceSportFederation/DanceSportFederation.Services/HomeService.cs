using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanceSportFederation.Models.EntityModels;
using DanceSportFederation.Models.ViewModels.Competitions;
using DanceSportFederation.Models.EntityModels;
using AutoMapper;
using DanceSportFederation.Models.BindingModels.Moderator;
using DanceSportFederation.Services.Interfaces;

namespace DanceSportFederation.Services
{
    public class HomeService : Service, IHomeService
    {
        public IEnumerable<CompetitionVm> GetAllCompetitions()
        {
            IEnumerable<Competition> competitions = this.Context.Competitions;
            IEnumerable<CompetitionVm> vms = Mapper.Map<IEnumerable<Competition>, IEnumerable<CompetitionVm>>(competitions);
            return vms;
        }

        public void AddNewCompetition(AddCompetititonBm bind, string userName)
        {
            ApplicationUser currentUser = this.Context.Users.FirstOrDefault(user => user.Name == userName);
            Competition model = Mapper.Map<AddCompetititonBm, Competition>(bind);
            this.Context.Competitions.Add(model);
            this.Context.SaveChanges();
        }
    }
}
