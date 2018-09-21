using System;

namespace MemberRegistry.view
{
    class EditBoat
    {
        private model.Registry registry;

        public EditBoat(model.Registry registry)
        {
            this.registry = registry;
        }

        public void Display()
        {
            Console.Clear();

            Console.WriteLine("Edit boat");
            Console.WriteLine();

            Console.Write("New type: ");
            string type = Console.ReadLine();

            Console.Write("New length: ");
            double length = double.Parse(Console.ReadLine());

            registry.EditBoat(type, length);
        }
    }
}