using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3Badge
{
    class Badge
    {
        public int badgeID { get; set; }
        public List<string> doorNames;
        public string badgeName;

        public Badge(int badgeID, string badgeName)
        {
            this.badgeID = badgeID;
            this.doorNames = new List<string>();
            this.badgeName = badgeName;
        }
    }
}
