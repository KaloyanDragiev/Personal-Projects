using DanceSportFederation.Models.BindingModels.Users;
using DanceSportFederation.Models.EntityModels;
using DanceSportFederation.Models.ViewModels.User;

namespace DanceSportFederation.Services.Interfaces
{
    public interface IUsersService
    {
        Trainer GetCurrentTrainer(string userName);
        void EnrollCoupleInCompetition(int competitionId, Trainer trainer);
        ProfileVm GetProfileVm(string userName);
        EditUserVm GetEditVm(string userName);
        void EditUser(EditUserBm bind, string currentName);
    }
}