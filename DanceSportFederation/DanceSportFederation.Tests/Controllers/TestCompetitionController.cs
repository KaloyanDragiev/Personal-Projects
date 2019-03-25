using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using DanceSportFederation.Data;
using DanceSportFederation.Data.Interfaces;
using DanceSportFederation.Data.Mocks;
using DanceSportFederation.Models.EntityModels;
using DanceSportFederation.Models.ViewModels.Competitions;
using DanceSportFederation.Services;
using DanceSportFederation.Services.Interfaces;
using DanceSportFederation.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;

namespace DanceSportFederation.Tests.Controllers
{
    [TestClass]
    public class TestCompetitionController
    {
        private CompetitionsController controller;
        
        private void ConfigureMapper()
        {
            Mapper.Initialize(expression => 
            {
                expression.CreateMap<Competition, DetailsCompetitionVm>();
            });
        }

        [TestInitialize]
        public void Init()
        {
            Competition competition = new Competition()
            {
                Id = 1,
                Description = "Description",
                EndDate = new DateTime(2017, 7, 18),
                StartDate = new DateTime(2017, 1, 18),
                Name = "Competition",
                Organizer = "Reader"
            };

            FakeDanceSportFederationContext context = new FakeDanceSportFederationContext();
            context.Competitions.Add(competition);
            ICompetitionService service = new CompetitionService();
            this.controller = new CompetitionsController(service);
        }

        [TestMethod]
        public void ShouldReturnDetailsNameForCompetition()
        {
            DetailsCompetitionVm vm = new DetailsCompetitionVm()
            {
                Description = "Description2",
                EndDate = new DateTime(2017, 7, 18),
                StartDate = new DateTime(2017, 1, 18),
                Name = "Competition2",
                Organizer = "Reader2"
            };
            var result = this.controller.Details(1) as ViewResult;
            var model = result.Model as Competition;
            Assert.AreEqual(model.Name, vm.Name);
        }
    }
}
