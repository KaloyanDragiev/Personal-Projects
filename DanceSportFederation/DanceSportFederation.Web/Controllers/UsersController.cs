using DanceSportFederation.Models.BindingModels.Users;
using DanceSportFederation.Models.EntityModels;
using DanceSportFederation.Models.ViewModels.User;
using DanceSportFederation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DanceSportFederation.Services.Interfaces;

namespace DanceSportFederation.Web.Controllers
{
    [Authorize(Roles = "Trainer, Admin, Moderator")]
    [RoutePrefix("users")]

    public class UsersController : Controller
    {
        private IUsersService service;

        public UsersController(IUsersService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("enroll")]
        public ActionResult Enroll(int competitionId)
        {
            string userName = User.Identity.Name;
            Trainer trainer = this.service.GetCurrentTrainer(userName);
            this.service.EnrollCoupleInCompetition(competitionId, trainer);
            return this.RedirectToAction("Profile");
        }

        [Route("profile")]
        public ActionResult Profile()
        {
            string userName = User.Identity.Name;
            ProfileVm vm = this.service.GetProfileVm(userName);

            return View(vm);
        }

        [HttpGet]
        [Route("edit")]
        public ActionResult Edit()
        {
            string userName = User.Identity.Name;
            EditUserVm vm = this.service.GetEditVm(userName);

            return View(vm);
        }

        [HttpPost]
        [Route("edit")]
        public ActionResult Edit(EditUserBm bind)
        {
            if (ModelState.IsValid)
            {
                string currentName = User.Identity.Name;
                this.service.EditUser(bind, currentName);
                return this.RedirectToAction("Profile");
            }

            string userName = User.Identity.Name;
            EditUserVm vm = this.service.GetEditVm(userName);

            return View(vm);
        }

    }
}