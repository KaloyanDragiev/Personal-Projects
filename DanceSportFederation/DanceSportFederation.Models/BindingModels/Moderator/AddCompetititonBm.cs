using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceSportFederation.Models.BindingModels.Moderator
{
    public class AddCompetititonBm
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }

        [Required]
        [MinLength(4)]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        [MinLength(4)]
        public string Organizer { get; set; }
    }
}
