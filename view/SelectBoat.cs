using System;
using System.Collections.Generic;

namespace MemberRegistry.view
{
    class SelectBoat
    {
        private model.Registry registry;
        private List<model.Boat> boats;

        public SelectBoat(model.Registry registry)
        {
            this.registry = registry;
        }
        public void Display()
        {
            Console.Clear();

            boats = registry.ViewMember().Boats;

            Console.WriteLine("Select a boat");
            Console.WriteLine("");

            for (int i = 0; i < boats.Count; i++)
            {
                Console.WriteLine(i + ") " + boats[i].Type + "    " + boats[i].Length + "    " + boats[i].Id);
            }
        }

        public void SaveSelectedBoatId()
        {
            Console.WriteLine();
            Console.Write("Boat to select: ");

            int boatListIndex = Convert.ToInt32(Console.ReadLine());

            registry.SelectedBoatId = boats[boatListIndex].Id;
        }
    }
}