using DanceSportFederation.Models.ViewModels.Competitions;
using DanceSportFederation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DanceSportFederation.Services.Interfaces;

namespace DanceSportFederation.Web.Controllers
{
    [RoutePrefix("competitions")]
    public class CompetitionsController : Controller
    {
        private ICompetitionService service;

        public CompetitionsController(ICompetitionService service)
        {
            this.service = service;
        }

        // GET: Details
        [HttpGet, Route("details/{id}")]
        [HandleError(ExceptionType = typeof(ArgumentOutOfRangeException), View = "OutOfRangeError")]
        public ActionResult Details(int id)
        {
            DetailsCompetitionVm vm = this.service.GetDetails(id);
            if (vm == null)
            {
                throw new ArgumentOutOfRangeException("id", id, $"There is no such element with provided id ");
            }
            return View(vm);
        }
        
    }
}