using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1Cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuRepository mr = new MenuRepository();
            Menu mi1 = new Menu(1, "pizza", "yes please", null, 10);
            Menu mi2 = new Menu(2, "Cheeseburger", "Why not", null, 7);
            mr.Add(mi1);
            mr.Add(mi2);
            string userInput = "";
            while (userInput != "4")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add New Menu Item");
                Console.WriteLine("2. Delete a Menu Item");
                Console.WriteLine("3. View the Menu");
                Console.WriteLine("4. Exit");
                Console.WriteLine("5. Run Test");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    mr.addMenuItem();
                }
                else if (userInput == "2")
                {
                    mr.deleteMenuItem();
                }
                else if (userInput == "3")
                {
                    Console.WriteLine(mr.View());
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
