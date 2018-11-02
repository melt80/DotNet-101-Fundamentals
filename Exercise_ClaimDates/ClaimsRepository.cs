using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_ClaimDates
{
    public class ClaimsRepository
    {
        private List<Claim> _claimList = new List<Claim>();

        public void AddWeatherToList(Claim claim)
        {
            _claimList.Add(claim);
        }

        public List<Claim> GetList()
        {
            return _claimList;
        }

        public bool IsValid(Claim claim)
        {
            return (claim.IncidentDate.AddDays(30) >= DateTime.Now);
        }

        public string GetMessage(Claim claim)
        {
            if (claim.Amount < 10000)
                return "Your claim is being processed.";
            else
                return "An agent will contact you.";

        }


    }
}
