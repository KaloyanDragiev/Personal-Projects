using System.Collections.Generic;
using DanceSportFederation.Models.BindingModels.Moderator;
using DanceSportFederation.Models.ViewModels.Competitions;

namespace DanceSportFederation.Services.Interfaces
{
    public interface IHomeService
    {
        IEnumerable<CompetitionVm> GetAllCompetitions();
        void AddNewCompetition(AddCompetititonBm bind, string userName);
    }
}