using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Claims
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaimsRepository mr = new ClaimsRepository();
            Claim mi1 = new Claim(1, "Car", "Car accident on 465", 400, new DateTime(2021, 1, 3), new DateTime(2021, 1, 5), true); 
            Claim mi2 = new Claim(2, "Home", "House fire in kitchen", 4000, new DateTime(2021, 1, 3), new DateTime(2021, 2, 5), true);
            Claim mi3 = new Claim(3, "Theft", "Stolen pancakes", 4, new DateTime(2021, 1, 3), new DateTime(2021, 3, 5), true);
            mr.Add(mi1);
            mr.Add(mi2);
            mr.Add(mi3);
            string userInput = "";
            while (userInput != "4")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. See all claims");
                Console.WriteLine("2. Take care of a claim");
                Console.WriteLine("3. Enter a new claim");
                Console.WriteLine("4. Exit");
                Console.WriteLine("5. Run Test");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Console.WriteLine(mr.View());
                }
                else if (userInput == "2")
                {
                    mr.processClaim();
                }
                else if (userInput == "3")
                {
                    mr.addClaim();
                }
                else if (userInput == "4")
                {
                    Console.WriteLine("GoodBye!");
                }
                else if (userInput == "5")
                {
                    Test.RunTest();
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please try again");
                }
            }
            Console.ReadLine();
        }
    }
}
