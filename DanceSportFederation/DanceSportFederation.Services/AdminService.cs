using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanceSportFederation.Models.ViewModels.Admin;
using DanceSportFederation.Models.EntityModels;
using AutoMapper;
using System.Web;
using DanceSportFederation.Services.Interfaces;

namespace DanceSportFederation.Services
{
    public class AdminService : Service, IAdminService
    {
        public AdminPageVm GetAdminPage()
        {
            AdminPageVm page = new AdminPageVm();
            IEnumerable<Trainer> trainers = this.Context.Trainers;
            IEnumerable<AdminPanelUserVm> userVms = Mapper.Map<IEnumerable<Trainer>, IEnumerable<AdminPanelUserVm>>(trainers);

            page.Users = userVms;
            return page;
        }

        public Trainer GetCurrentTrainer(string userName)
        {
            var user = Context.Users.FirstOrDefault(ap => ap.UserName == userName);
            Trainer currentTrainer = Context.Trainers.FirstOrDefault(cp => cp.User.Id == user.Id);
            return currentTrainer;
        }

        //public void EditRole(int id)
        //{
        //    DanceSportFederation .
        //    ApplicationUser currentUser = this.Context.Users.FirstOrDefault(user => user.Id == id.ToString());
        //    //Competition model = Mapper.Map<AddCompetititonBm, Competition>(bind);
        //    this.Context.Trainers.Add(model);
        //    this.Context.SaveChanges();
        //}
    }
}
