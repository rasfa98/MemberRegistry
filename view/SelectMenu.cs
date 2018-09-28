using System;
using System.Collections.Generic;

namespace MemberRegistry.view
{
    class SelectMenu
    {
        public void Display(List<model.Member> membersToList)
        {
            Console.Clear();

            Console.WriteLine("Select a member");
            Console.WriteLine();
            Console.WriteLine("(write the number of the member you would like to select)");
            Console.WriteLine();

            for (int i = 0; i < membersToList.Count; i++)
            {
                Console.WriteLine(i + ") " + membersToList[i].Name + "    " + membersToList[i].PersonalNumber + "    " + membersToList[i].Id);
            }

            Console.WriteLine();
            Console.Write("Member to select: ");
        }

        public void Display(List<model.Boat> boatsToList)
        {
            Console.Clear();

            Console.WriteLine("Select a boat");
            Console.WriteLine();
            Console.WriteLine("(write the number of the boat you would like to select)");
            Console.WriteLine();

            for (int i = 0; i < boatsToList.Count; i++)
            {
                Console.WriteLine(i + ") " + boatsToList[i].Type + "    " + boatsToList[i].Length + "    " + boatsToList[i].Id);
            }

            Console.WriteLine();
            Console.Write("Boat to select: ");
        }

        public string GetSelectedItemListIndex()
        {
            return Console.ReadLine();
        }
    }
}