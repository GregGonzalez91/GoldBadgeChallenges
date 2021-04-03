using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1Cafe
{
    class Test
    {
        public static void RunTest()
        {
            MenuRepository test = new MenuRepository();
            Menu mi1 = new Menu(1, "pizza", "yes please", null, 10);
            Menu mi2 = new Menu(2, "Cheeseburger", "Why not", null, 7);
            test.Add(mi1);
            test.Add(mi2);
            Console.WriteLine("After adding 2 Menu Items");
            Console.WriteLine(test.View());
            Console.WriteLine("After Deleting");
            test.deleteMenuItem(mi1);
            Console.WriteLine(test.View());
            Console.ReadLine();
        }
    }
}
