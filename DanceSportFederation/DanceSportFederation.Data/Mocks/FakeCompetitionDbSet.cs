using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanceSportFederation.Models.EntityModels;

namespace DanceSportFederation.Data.Mocks
{
    public class FakeCompetitionDbSet : FakeDbSet<Competition>
    {
        public override Competition Find(params object[] keyValues)
        {
            int wantedId = (int) keyValues[0];
            return this.set.FirstOrDefault(competition => competition.Id == wantedId);
            
        }
    }
}
