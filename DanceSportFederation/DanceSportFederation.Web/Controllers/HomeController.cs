using DanceSportFederation.Models.EntityModels;
using DanceSportFederation.Models.ViewModels.Competitions;
using DanceSportFederation.Services;
using DanceSportFederation.Web.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DanceSportFederation.Services.Interfaces;

namespace DanceSportFederation.Web.Controllers
{
    //[MyAuthorize(Roles ="Trainer")]
    public class HomeController : Controller
    {
        private IHomeService service;

        public HomeController(IHomeService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Visualize()
        {
            IEnumerable<CompetitionVm> vms = this.service.GetAllCompetitions();
            return this.PartialView("_VisualizePartial", vms);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}