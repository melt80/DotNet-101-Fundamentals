using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Badging_System
{
    class BadgeRepository
    {
        private Dictionary<int, List<string>> _dictionary = new Dictionary<int, List<string>>();

        public void AddBadgeToDictionary(Badge badge)
        {
            _dictionary.Add(badge.BadgeID, badge.Doors);
        }

        public Dictionary<int, List<string>> GetDictionary()
        {
            return _dictionary;
        }

        public bool IsValid(Claim claim)
        {
            return true;
            //return (claim.IncidentDate.AddDays(30) >= DateTime.Now);
        }
    }
}
