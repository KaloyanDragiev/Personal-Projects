using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceSportFederation.Models.ViewModels.Admin
{
    public class AdminPageVm
    {
        public IEnumerable<AdminPanelUserVm> Users { get; set; }
    }
}
