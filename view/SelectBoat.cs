using System;
using System.Collections.Generic;

namespace MemberRegistry.view
{
    class SelectBoat
    {
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
        }

        public string GetlSelectedBoatListIndex()
        {
            Console.WriteLine();
            Console.Write("Boat to select: ");

            return Console.ReadLine();
        }
    }
}