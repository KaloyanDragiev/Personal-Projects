using DanceSportFederation.Models.BindingModels.Moderator;
using DanceSportFederation.Models.ViewModels.Competitions;
using DanceSportFederation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DanceSportFederation.Services.Interfaces;

namespace DanceSportFederation.Web.Areas.Home.Controllers
{
    [Authorize(Roles = "Moderator")]
    [RouteArea("Moderator")]
    public class ModeratorController : Controller
    {
        private IHomeService service;

        public ModeratorController(IHomeService service)
        {
            this.service = service;
        }
        
        [Route("Index")]
        public ActionResult Index()
        {
            IEnumerable<CompetitionVm> vms = this.service.GetAllCompetitions();
            return View(vms);
        }
        
        [HttpGet]
        [Authorize(Roles = "Moderator")]
        [Route("competition/add")]
        public ActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize(Roles = "Moderator")]
        [Route("competition/add")]
        public ActionResult Add(AddCompetititonBm bind)
        {
            if (ModelState.IsValid)
            {
                string userName = User.Identity.Name;
                this.service.AddNewCompetition(bind, userName);
                return this.RedirectToAction("Index");
            }

            return this.View();
        }


    }
}