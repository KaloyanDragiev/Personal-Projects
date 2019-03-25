using DanceSportFederation.Models.EntityModels;

namespace DanceSportFederation.Services.Interfaces
{
    public interface IAccountService
    {
        void CreateTrainer(ApplicationUser user);
    }
}