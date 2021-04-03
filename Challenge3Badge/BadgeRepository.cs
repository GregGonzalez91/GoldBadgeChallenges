using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3Badge
{
    class BadgeRepository
    {
        Dictionary<int, Badge> _badges;
        public BadgeRepository()
        {
            this._badges = new Dictionary<int, Badge>();
        }
        public void StartMenu()
        {
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
                otherDoor = Console.ReadLine();
            }
            while (otherDoor == "y");
            _badges.Add(badgeID, badge);
        }
        public void Edit()
        {
            Console.WriteLine("What is the badge number to update?");
            int badgeID = Convert.ToInt32(Console.ReadLine());
            
            if (_badges.ContainsKey(badgeID))
            {
                Badge badge = _badges[badgeID];
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
                    badge.doorNames.Remove(doorToRemove);
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
                    badge.doorNames.Add(doorNameToAdd);
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
            
            if (_badges.ContainsKey(badgeID))
            {
                Badge badge = _badges[badgeID];
                badge.doorNames = new List<string>();
                Console.WriteLine("All doors have been removed from badge.");
            }
            else
            {
                Console.WriteLine("Badge ID not found.");
            }
        }
        public void View()
        {
            Console.WriteLine("Badge #\tDoor Access");
            foreach (int badgeID in _badges.Keys)
            {
                Badge badge = _badges[badgeID];
                Console.Write(badge.badgeID + "\t");
                foreach (string doorName in badge.doorNames)
                {
                    Console.Write(doorName + " ");
                }
                Console.WriteLine();
            }
        }
        public void Add(Badge badge)
        {
            _badges.Add(badge.badgeID, badge);
        }
    }
    //Add newItem to dictionary
}
