using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceSportFederation.Models.EntityModels
{
    public class Trainer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Couple { get; set; }

        public string Club { get; set; }

        public virtual ApplicationUser User { get; set; }
        
        public virtual ICollection<Competition> Competitions { get; set; }
    }
}
