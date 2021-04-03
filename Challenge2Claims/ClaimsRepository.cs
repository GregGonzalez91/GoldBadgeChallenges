using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Claims
{
    class ClaimsRepository
    {
        List<Claim> ClaimList;
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
        public void addClaim()
        {
            Console.Write("Enter Claim ID#");
            int claimID = Convert.ToInt32(Console.ReadLine());
            string claimType = "";
            do
            {
                Console.Write("Enter a Claim Type. Car, Home or Theft");
                claimType = Console.ReadLine().ToLower();
                if (claimType != "car" && claimType != "home" && claimType != "theft")
                {
                    Console.WriteLine("Invaild Type, please try again");
                }
            }
            while (claimType != "car" && claimType != "home" && claimType != "theft");

          
            Console.Write("Enter the Claim description");
            string claimDescription = Console.ReadLine();
            Console.Write("Enter the Claim Amount");
            double claimAmount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Date of Accident");
            DateTime dateOfAccident = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter Date of Claim");
            DateTime dateOfClaim = Convert.ToDateTime(Console.ReadLine());
            DateTime deadLine = dateOfAccident.AddDays(30);
            if (dateOfClaim > deadLine)
            {
                Claim item = new Claim(claimID, claimType, claimDescription, claimAmount, dateOfAccident, dateOfClaim, false); 
                ClaimList.Add(item);

            }
            else
            {
                Claim item = new Claim(claimID, claimType, claimDescription, claimAmount, dateOfAccident, dateOfClaim, true); 
                ClaimList.Add(item);
            }
        }
      
        public void deleteClaim(Claim item)
        {
            ClaimList.Remove(item);
        }
        public void processClaim()
        {
            if (ClaimList.Count > 0)
            {
                Claim currentClaim = ClaimList[0];
                Console.WriteLine("Claim ID: " + currentClaim.claimID);
                Console.WriteLine("Claim Type: " + currentClaim.claimType);
                Console.WriteLine("Claim Description: " + currentClaim.claimDescription);
                Console.WriteLine("Claim Amount: " + currentClaim.claimAmount);
                Console.WriteLine("Claim Date Of Accident: " + string.Format("{0:MM/dd/yy}", currentClaim.dateOfAccident));
                Console.WriteLine("Claim Date Of Claim: " + string.Format("{0:MM/dd/yy}", currentClaim.dateOfClaim));
                Console.WriteLine("Do you want to deal with this claim now(y/n)");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "y")
                {
                    deleteClaim(currentClaim);
                }
            }
        }
    }
}
