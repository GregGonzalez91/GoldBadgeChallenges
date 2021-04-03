using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Claims
{
    class Test
    {
        public static void RunTest()
        {
            ClaimsRepository test = new ClaimsRepository();
            Claim mi1 = new Claim(1, "Car", "Car accident on 465", 400, new DateTime(2021, 1, 3), new DateTime(2021, 1, 5), true);
            Claim mi2 = new Claim(2, "Home", "House fire in kitchen", 4000, new DateTime(2021, 1, 3), new DateTime(2021, 2, 5), true);
            Claim mi3 = new Claim(3, "Theft", "Stolen pancakes", 4, new DateTime(2021, 1, 3), new DateTime(2021, 3, 5), true);
            test.Add(mi1);
            test.Add(mi2);
            test.Add(mi3);
            Console.WriteLine("After adding 2 Menu Items");
            Console.WriteLine(test.View());
            Console.WriteLine("After Deleting");
            test.deleteClaim(mi1);
            Console.WriteLine(test.View());
            Console.ReadLine();
        }
    }
}
