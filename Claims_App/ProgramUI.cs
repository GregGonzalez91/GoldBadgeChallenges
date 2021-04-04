using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Claims_Repository;

namespace Claims_App
{
    class ProgramUI
    {
        ClaimsRepository mr = new ClaimsRepository();
        public void StartOptions()
        {
            Seed();
            string userInput = "";
            while (userInput != "4")
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. See all claims");
                Console.WriteLine("2. Take care of a claim");
                Console.WriteLine("3. Enter a new claim");
                Console.WriteLine("4. Exit");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {Console.Clear();
                    Console.WriteLine(mr.View());
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                else if (userInput == "2")
                {
                    Console.Clear();
                    processClaim();
                }
                else if (userInput == "3")
                {
                    Console.Clear();
                    addClaim();
                }
                else if (userInput == "4")
                {Console.Clear();
                    Console.WriteLine("GoodBye!\n");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please try again");
                }
            }
        }
        public void Seed()
        {
            Claim mi1 = new Claim(1, "Car", "Car accident on 465", 400, new DateTime(2021, 1, 3), new DateTime(2021, 1, 5), true);
            Claim mi2 = new Claim(2, "Home", "House fire in kitchen", 4000, new DateTime(2021, 1, 3), new DateTime(2021, 2, 5), true);
            Claim mi3 = new Claim(3, "Theft", "Stolen pancakes", 4, new DateTime(2021, 1, 3), new DateTime(2021, 3, 5), true);
            mr.Add(mi1);
            mr.Add(mi2);
            mr.Add(mi3);
        }
        public void addClaim()
        {
            Console.Write("Enter Claim ID#: ");
            int claimID = Convert.ToInt32(Console.ReadLine());
            string claimType = "";
            do
            {
                Console.Write("Enter a Claim Type Car, Home or Theft: ");
                claimType = Console.ReadLine().ToLower();
                if (claimType != "car" && claimType != "home" && claimType != "theft")
                {
                    Console.WriteLine("Invaild Type, please try again");
                }
            }
            while (claimType != "car" && claimType != "home" && claimType != "theft");


            Console.Write("Enter the Claim description: ");
            string claimDescription = Console.ReadLine();
            Console.Write("Enter the Claim Amount: ");
            double claimAmount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Date of Accident(MM/DD/YY): ");
            DateTime dateOfAccident = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter Date of Claim(MM/DD/YY): ");
            DateTime dateOfClaim = Convert.ToDateTime(Console.ReadLine());
            DateTime deadLine = dateOfAccident.AddDays(30);
            if (dateOfClaim > deadLine)
            {
                Claim item = new Claim(claimID, claimType, claimDescription, claimAmount, dateOfAccident, dateOfClaim, false);
                mr.Add(item);

            }
            else
            {
                Claim item = new Claim(claimID, claimType, claimDescription, claimAmount, dateOfAccident, dateOfClaim, true);
                mr.Add(item);
            }
        }
        public void processClaim()
        {
            if (mr.ClaimList.Count > 0)
            {
                Claim currentClaim = mr.ClaimList[0];
                Console.WriteLine("Claim ID: " + currentClaim.claimID);
                Console.WriteLine("Claim Type: " + currentClaim.claimType);
                Console.WriteLine("Claim Description: " + currentClaim.claimDescription);
                Console.WriteLine("Claim Amount: " + currentClaim.claimAmount);
                Console.WriteLine("Claim Date Of Accident(MM/DD/YY): " + string.Format("{0:MM/dd/yy}", currentClaim.dateOfAccident));
                Console.WriteLine("Claim Date Of Claim(MM/DD/YY): " + string.Format("{0:MM/dd/yy}", currentClaim.dateOfClaim));
                Console.WriteLine("Do you want to deal with this claim now(y/n)");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "y")
                {
                    mr.deleteClaim(currentClaim);
                }
            }
        }
    }
}
