using DanceSportFederation.Models.ViewModels.Competitions;

namespace DanceSportFederation.Services.Interfaces
{
    public interface ICompetitionService
    {
        DetailsCompetitionVm GetDetails(int id);
    }
}