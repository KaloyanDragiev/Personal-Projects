using DanceSportFederation.Models.ViewModels.Admin;
using DanceSportFederation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DanceSportFederation.Models.BindingModels.Admin;
using DanceSportFederation.Models.EntityModels;
using DanceSportFederation.Services.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace DanceSportFederation.Web.Areas.Admin.Controllers
{
    //[Authorize(Roles ="Admin")]
    [RouteArea("admin")]
    public class AdminController : Controller
    {
        private IAdminService service;
        private ApplicationUserManager _userManager;

        public AdminController(IAdminService service)
        {
            this.service = service;
        }

        public AdminController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("index")]
        public ActionResult Index()
        {
            AdminPageVm vm = this.service.GetAdminPage();
            return View(vm);
        }

        // GET: Admin/Admin
        [HttpGet]
        [Route("users/edit")]
        public ActionResult EditUser()
        {
            string userName = User.Identity.Name;
            Trainer trainer = this.service.GetCurrentTrainer(userName);

            this.UserManager.RemoveFromRoleAsync(trainer.Id.ToString(), "Trainer");
            this.UserManager.AddToRoleAsync(trainer.Id.ToString(), "Admin");
            return this.RedirectToAction("Index");
            //return View();
        }

        [HttpPost]
        [Route("users/{id}/edit/")]
        public ActionResult EditUser(int id)
        {
            //if (ModelState.IsValid)
            //{
                this.UserManager.RemoveFromRoleAsync(id.ToString(), "Trainer");
                this.UserManager.AddToRole(id.ToString(), "Admin");
                return this.RedirectToAction("Index");
            //}

           //return View();
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
          {
              _userManager = value;
          }
        }
    }
}