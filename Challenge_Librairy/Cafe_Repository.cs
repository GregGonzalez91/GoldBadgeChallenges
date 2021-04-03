using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Repository
{
    public class MenuRepository
    {
        public List<Menu> MenuList;
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
        public void deleteMenuItem(Menu item)
        {
             MenuList.Remove(item);
        }
    }
}
