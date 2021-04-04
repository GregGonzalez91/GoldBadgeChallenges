using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafe_Repository;

namespace Cafe_ConsoleApp
{
    public class ProgramUI
    {
        MenuRepository mr = new MenuRepository();
        public void StartOptions()
        {
            Seed();
            string userInput = "";
            while (userInput != "4")
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add New Menu Item");
                Console.WriteLine("2. Delete a Menu Item");
                Console.WriteLine("3. View the Menu");
                Console.WriteLine("4. Exit");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Console.Clear();
                    addMenuItem();
                }
                else if (userInput == "2")
                {
                    Console.Clear();
                    deleteMenuItem();
                }
                else if (userInput == "3")
                {
                    Console.Clear();
                    Console.WriteLine(mr.View());
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                else if (userInput == "4")
                {
                    Console.Clear();
                    Console.WriteLine("GoodBye!\n");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Input. Please try again");
                }
            }
        }
        public void addMenuItem()
        {
            Console.Write("Enter Meal name: ");
            string mealName = Console.ReadLine();
            Console.Write("Enter a Meal number: ");
            int mealNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Meal description: ");
            string mealDescription = Console.ReadLine();
            Console.Write("Enter Ingredients and type done when you are done entering the ingredients: ");
            string ingredient = "";
            List<string> ingredientList = new List<string>();
            while (ingredient.ToLower() != "done")
            {
                ingredient = Console.ReadLine();
                if (ingredient.ToLower() != "done")
                {
                    ingredientList.Add(ingredient);
                }
            }
            Console.Write("Price of the meal: ");
            double mealprice = Convert.ToDouble(Console.ReadLine());
            Menu item = new Menu(mealNumber, mealName, mealDescription, ingredientList, mealprice);
            mr.Add(item);
        }
        public void Seed()
        {
            List<string> ingredients1 = new List<string>(){ "cheese", "pepperoni"};
            Menu mi1 = new Menu(1, "pizza", "yes please", ingredients1, 10);
            List<string> ingredients2 = new List<string>(){ "cheese", "beef patty", "buns"};
            Menu mi2 = new Menu(2, "Cheeseburger", "Why not", ingredients2, 7);
            mr.Add(mi1);
            mr.Add(mi2);
        }
        public void deleteMenuItem()
        {
            Console.WriteLine("Please enter the Meal Number you would like to delete.");
            Console.WriteLine(mr.View());
            int mealNumber = Convert.ToInt32(Console.ReadLine());
            foreach (Menu item in mr.MenuList)
            {
                if (item.mealNumber == mealNumber)
                {
                    mr.deleteMenuItem(item);
                    Console.WriteLine("Item was successfully removed.");
                    break;
                }
            }
        }
    }
}
