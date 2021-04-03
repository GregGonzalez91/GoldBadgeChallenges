using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Repository
{
    public class BadgeRepository
    {
        public Dictionary<int, Badge> _badges;
        public BadgeRepository()
        {
            this._badges = new Dictionary<int, Badge>();
        }
        public void Add(int badgeID, Badge badge)
        {
            _badges.Add(badgeID, badge);
        }
        
        public void Edit(int badgeID, string doorName, string action)
        {
            if (action == "add")
            {
                Badge badge = GetBadgeByID(badgeID);
                badge.doorNames.Add(doorName);

            }
            else if (action == "remove")
            {
                Badge badge = GetBadgeByID(badgeID);
                badge.doorNames.Remove(doorName);
            }
        }
        public void Add(Badge badge)
        {
            _badges.Add(badge.badgeID, badge);
        }
        public bool IsVaildBadgeID(int badgeID)
        {
            if (_badges.ContainsKey(badgeID))
            {
                return true;
            }
            return false;
        }
        public Badge GetBadgeByID(int badgeID)
        {
            return _badges[badgeID];
        }

        public void DeleteAllDoors(int badgeID)
        {
            Badge badge = _badges[badgeID];
            badge.doorNames = new List<string>();
        }
    }
    //Add newItem to dictionary
}
