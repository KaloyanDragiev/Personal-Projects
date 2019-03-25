using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceSportFederation.Models.BindingModels.Users
{
    public class EditUserBm
    {
        [Required]
        [MinLength(3)]
        [MaxLength(9)]
        public string Name { get; set; }

        [Required]
        [MinLength(5)]
        public string Couple { get; set; }

        [Required]
        [MinLength(5)]
        public string Club { get; set; }
    }
}
