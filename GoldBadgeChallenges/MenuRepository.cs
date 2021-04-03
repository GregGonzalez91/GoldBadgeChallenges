using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1Cafe
{
    class MenuRepository
    {
        List<Menu> MenuList;
        public MenuRepository()
        {
            MenuList = new List<Menu>();
        }
        public void Add(Menu mi)
        {
            MenuList.Add(mi);
        }
        public string View()
        {
            string s = "";
            for (int i = 0; i < MenuList.Count; i++)
            {
                Menu menuItem = MenuList[i];
                s += menuItem.mealNumber;
                s += " ";
                s += menuItem.mealName;
                s += " $";
                s += menuItem.price;
                s += "\n";
            }
            return s;
        }
        public void addMenuItem()
        {
            Console.Write("Enter Meal name.");
            string mealName = Console.ReadLine();
            Console.Write("Enter a Meal number");
            int mealNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Meal description");
            string mealDescription = Console.ReadLine();
            Console.Write("Enter Ingredients and type done when you are done entering the ingredients.");
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
            Console.Write("Price of the meal?");
            double mealprice = Convert.ToDouble(Console.ReadLine());
            Menu item = new Menu(mealNumber, mealName, mealDescription, ingredientList, mealprice);
            MenuList.Add(item);
        }
        public void deleteMenuItem()
        {
            Console.WriteLine("Please enter the Meal Number you would like to delete.");
            Console.WriteLine(View());
            int mealNumber = Convert.ToInt32(Console.ReadLine());
            foreach (Menu item in MenuList)
            {
                if (item.mealNumber == mealNumber)
                {
                    deleteMenuItem(item);
                    Console.WriteLine("Item was successfully removed.");
                    break;
                }
            }
        }
        public void deleteMenuItem(Menu item)
        {
             MenuList.Remove(item);
        }
    }
}
