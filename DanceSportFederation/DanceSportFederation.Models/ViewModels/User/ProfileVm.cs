using DanceSportFederation.Models.ViewModels.Competitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceSportFederation.Models.ViewModels.User
{
    public class ProfileVm
    {
        public string  Name { get; set; }

        public string Email { get; set; }

        public string Couple { get; set; }

        public string Club { get; set; }

        public IEnumerable<UserCompetitionVm> EnrolledCompetitions { get; set; }
    }
}
