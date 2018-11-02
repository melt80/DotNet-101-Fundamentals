using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Badging_System_00
{
    class BadgeRepository
    {
        private Dictionary<int, List<string>> _dictionary = new Dictionary<int, List<string>>();
        private List<string> _doorList = new List<string>();

        public void AddBadgeToDictionary(Badge badge)
        {
            _dictionary.Add(badge.BadgeID, badge.Doors);
        }

        public Dictionary<int, List<string>> GetDictionary()
        {
            return _dictionary;
        }

        public void AddDoorToBadge(int badgeID, string newDoor)
        {
            bool success = _dictionary.TryGetValue(badgeID, out List<string> doors);
            if (success)
            {
                doors.Add(newDoor);
                _dictionary[badgeID] = doors;
            }
        }

        public void RemoveDoorFromBadge(int badgeID, string doorToRemove)
        {
            bool success = _dictionary.TryGetValue(badgeID, out List<string> doors);
            if (success)
            {
                doors.Remove(doorToRemove);
                _dictionary[badgeID] = doors;
            }
        }
    }
}
