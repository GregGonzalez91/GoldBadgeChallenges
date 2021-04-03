using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Repository
{
    public class Menu
    {
       public int mealNumber { get; set; }
       public string mealName;
       public string mealDescription;
       public List<string> ingredients;
       public double price;
       public double Price { get 
            {
                return price;
            }
            set 
            {
                if (value < 0)
                {
                    price = 0;
                }
                else
                {
                    price = value;
                }
            }
        }
        public Menu(int mealNumber, string mealName, string mealDescription, List<string> ingredients, double price)
        {
            this.mealNumber = mealNumber;
            this.mealName = mealName;
            this.mealDescription = mealDescription;
            this.ingredients = ingredients;
            this.price = price;
        }


    }
}
