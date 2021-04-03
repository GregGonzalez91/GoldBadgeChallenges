using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims_Repository
{
    public class ClaimsRepository
    {
        public List<Claim> ClaimList;
        public ClaimsRepository()
        {
            ClaimList = new List<Claim>();
        }
        public void Add(Claim mi)
        {
            ClaimList.Add(mi);
        }
        public string View()
        {
            string s = "";
            for (int i = 0; i < ClaimList.Count; i++)
            {
                Claim claimItem = ClaimList[i];
                s += claimItem.claimID;
                s += " ";
                s += claimItem.claimType;
                s += " ";
                s += claimItem.claimDescription;
                s += "\n";
            }
            return s;
        }
        public void deleteClaim(Claim item)
        {
            ClaimList.Remove(item);
        }
    }
}
