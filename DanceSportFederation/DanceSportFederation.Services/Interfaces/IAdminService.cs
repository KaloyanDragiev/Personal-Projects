using DanceSportFederation.Models.EntityModels;
using DanceSportFederation.Models.ViewModels.Admin;

namespace DanceSportFederation.Services.Interfaces
{
    public interface IAdminService
    {
        AdminPageVm GetAdminPage();
        Trainer GetCurrentTrainer(string name);
    }
}