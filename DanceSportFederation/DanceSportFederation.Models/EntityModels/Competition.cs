using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceSportFederation.Models.EntityModels
{
    public class Competition
    {
        public Competition()
        {
            this.Trainers = new HashSet<Trainer>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Organizer { get; set; }
        
        public virtual ICollection<Trainer> Trainers { get; set; }
    }
}
