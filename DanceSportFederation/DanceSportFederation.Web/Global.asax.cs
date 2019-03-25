using AutoMapper;
using DanceSportFederation.Models.BindingModels.Moderator;
using DanceSportFederation.Models.EntityModels;
using DanceSportFederation.Models.ViewModels.Admin;
using DanceSportFederation.Models.ViewModels.Competitions;
using DanceSportFederation.Models.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DanceSportFederation.Models.BindingModels.Admin;

namespace DanceSportFederation.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ConfigureMappings();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void ConfigureMappings()
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<Competition, DetailsCompetitionVm>();
                expression.CreateMap<Competition, CompetitionVm>();
                expression.CreateMap<ApplicationUser, ProfileVm>();
                expression.CreateMap<Competition, UserCompetitionVm>();
                expression.CreateMap<ApplicationUser, EditUserVm>();
                expression.CreateMap<AddCompetititonBm, Competition>();
                expression.CreateMap<Trainer, AdminPanelUserVm>().ForMember(vm => vm.Name, 
                    confex => confex.MapFrom(trainer => trainer.User.Name));
            });
        }
    }
}
