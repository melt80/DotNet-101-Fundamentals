using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Badging_System_00
{
    class Program
    {
        BadgeRepository badgeRepo = new BadgeRepository();
        static void Main(string[] args)
        {
            //InitialPrompt();
        }

        public void InitialPrompt()
        {
            Console.WriteLine("What would you like to do:\n1. Add a badge\n2. Edit a badge\n3. List all badges\n4. Exit");
            string respStr = Console.ReadLine();
            bool respBool = int.TryParse(respStr, out int input);

            switch (input)
            {
                case 1:
                    UIAddItem();
                    break;
                case 2:
                    UIUpdateItem();
                    break;
                case 3:
                    UIListItems();
                    break;
                case 4:
                    break;
            }
        }

        private void UIListItems()
        {
            throw new NotImplementedException();
        }

        public void UIAddItem()
        {
            List<string> doorList = new List<string>();

            Console.Clear();

            Console.Write("What is the number on the badge: ");
            bool badgeSuccess = int.TryParse(Console.ReadLine(), out int badgeID );

            Console.Write("List a door it needs access to: ");
            string door = Console.ReadLine();
            doorList.Add(door);

            Console.Write("Any other doors (y/n)? ");
            while (Console.ReadLine() == "y")
            {
                Console.Write("List a door it needs access to: ");
                door = Console.ReadLine();
                doorList.Add(door);
            }

            Badge newBadge = new Badge();
            newBadge.BadgeID = badgeID;
            newBadge.Doors = doorList;

            InitialPrompt();
        }

        public void UIUpdateItem()
        {
            Console.Clear();
            Console.WriteLine("What is the badge number to update?");
            string inputStr = Console.ReadLine();
            bool verifyInput = int.TryParse(inputStr, out int input);
            Console.WriteLine("What would you like to do:\n1. Add a door\n2. Remove a door\n");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("What door would you like to add?");
                badgeRepo.AddDoorToBadge(input, Console.ReadLine());
            }

            InitialPrompt();
        }

        public void ListItems()
        {
            var dictionary = badgeRepo.GetDictionary();
            foreach (KeyValuePair<int, List<string>> entry in dictionary)
            {

            }
            Console.WriteLine("What is the badge number to update?");
            string inputStr = Console.ReadLine();
            bool verifyInput = int.TryParse(inputStr, out int input);
            Console.WriteLine("What would you like to do:\n1. Add a door\n2. Remove a door\n");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("What door would you like to add?");
                badgeRepo.AddDoorToBadge(input, Console.ReadLine());
            }

            InitialPrompt();
        }

    }
}
