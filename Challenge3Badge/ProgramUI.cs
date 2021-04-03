using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3Badge
{
    class ProgramUI
    {
        static void Main(string[] args)
        {
            BadgeRepository ui = new BadgeRepository();
            ui.StartMenu();
        }
    }
}
