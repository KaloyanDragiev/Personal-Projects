using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceSportFederation.Models.ViewModels.User
{
    public class EditUserVm
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Couple { get; set; }

        [Required]
        public string Club { get; set; }
    }
}
