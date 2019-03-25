using AutoMapper;
using DanceSportFederation.Models.EntityModels;
using DanceSportFederation.Models.ViewModels.Competitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanceSportFederation.Services.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DanceSportFederation.Services
{
    public class CompetitionService : Service, ICompetitionService
    {

        public DetailsCompetitionVm GetDetails(int id)
        {
            Competition competition = Context.Competitions.Find(id);
            if (competition == null)
            {
                return null;
            }

            DetailsCompetitionVm vm = Mapper.Map<Competition, DetailsCompetitionVm>(competition);

            return vm;
        }
    }
}
