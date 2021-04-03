using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Badge_Repository;

namespace Badge_App
{
    public class ProgramUI
    {
        BadgeRepository br = new BadgeRepository();

        public void StartMenu()
        {
            Seed();
            string userInput = "";
            while (userInput != "5")
            {
                Console.WriteLine("Hello Security Admin, What would you like to do?\n" +
                    "1. Add a Badge\n" +
                    "2. Edit a Badge\n" +
                    "3. List all Badges\n" +
                    "4. Delete all door for a badge\n" +
                    "5. Exit");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Add();
                }
                else if (userInput == "2")
                {
                    Edit();
                }
                else if (userInput == "3")
                {
                    View();
                }
                else if (userInput == "4")
                {
                    Delete();
                }
                else if (userInput == "5")
                {
                    Console.WriteLine("Goodbye!");
                    //call exit program method
                }
                else
                {
                    Console.WriteLine("Invalid input please try again");
                }
            }
        }

        private void Seed()
        {
            Badge b1 = new Badge(123, "Cool Guy Badge.");
            b1.doorNames.Add("A1");
            Badge b2 = new Badge(1234, "Just a Guy Badge");
            b2.doorNames.AddRange(new List<string>() { "A1", "B2", "C4" });
            Badge b3 = new Badge(12345, "Probably still a cool guy but haven't gotten to know him yet badge.");
            br.Add(b1);
            br.Add(b2);
            br.Add(b3);
        }
        public void Add()
        {
            Console.WriteLine("What is the number on the badge?");
            string badgeName = Console.ReadLine();
            int badgeID = Convert.ToInt32(badgeName);
            Badge badge = new Badge(badgeID, badgeName);
            string otherDoor;
            do
            {
                Console.WriteLine("List a door it needs access to");
                string doorName = Console.ReadLine();
                badge.doorNames.Add(doorName);
                Console.WriteLine("Any other doors(y/n)?");
                otherDoor = Console.ReadLine().ToLower();
            }
            while (otherDoor == "y");
            br.Add(badgeID, badge);
        }

        public void View()
        {
            Console.WriteLine("Badge #\tDoor Access");
            foreach (int badgeID in br._badges.Keys)
            {
                Badge badge = br._badges[badgeID];
                Console.Write(badge.badgeID + "\t");
                foreach (string doorName in badge.doorNames)
                {
                    Console.Write(doorName + " ");
                }
                Console.WriteLine();
            }
        }
        public void Edit()
        {
            Console.WriteLine("What is the badge number to update?");
            int badgeID = Convert.ToInt32(Console.ReadLine());

            if (br.IsVaildBadgeID(badgeID))
            {
                Badge badge = br.GetBadgeByID(badgeID);
                Console.Write(badge.badgeID + " has access to ");
                foreach (string doorName in badge.doorNames)
                {
                    Console.Write(doorName + " ");
                }
                Console.WriteLine("What would you like to do?\n" +
                    "1. Remove a door\n" +
                    "2. Add a door");
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Console.WriteLine("Which door do you want to remove?");
                    string doorToRemove = Console.ReadLine();
                    br.Edit(badgeID, doorToRemove, "remove");
                    Console.WriteLine("Door successfully removed");
                    Console.Write(badge.badgeID + " has access to ");
                    foreach (string doorName in badge.doorNames)
                    {
                        Console.Write(doorName + " ");
                    }
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Whats the door name you want to add?");
                    string doorNameToAdd = Console.ReadLine();
                    br.Edit(badgeID, doorNameToAdd, "add");
                    Console.WriteLine("Door successfully added!");
                    Console.Write(badge.badgeID + " has access to ");
                    foreach (string doorName in badge.doorNames)
                    {
                        Console.Write(doorName + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Badge ID not found.");
            }

        }
        public void Delete()
        {
            Console.WriteLine("What is the number on the badge?");
            string badgeName = Console.ReadLine();
            int badgeID = Convert.ToInt32(badgeName);

            if (br._badges.ContainsKey(badgeID))
            {
                br.DeleteAllDoors(badgeID);
                Console.WriteLine("All doors have been removed from badge.");
            }
            else
            {
                Console.WriteLine("Badge ID not found.");
            }
        }
    }
}


