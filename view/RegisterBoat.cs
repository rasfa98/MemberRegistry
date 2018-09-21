using System;

namespace MemberRegistry.view
{
    class RegisterBoat
    {
        private model.Registry registry;

        public RegisterBoat(model.Registry registry)
        {
            this.registry = registry;
        }

        public void Display()
        {
            Console.Clear();

            Console.WriteLine("Register boat");
            Console.WriteLine();

            Console.Write("Type: ");
            string type = Console.ReadLine();

            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            registry.AddBoat(Guid.NewGuid(), type, length);
        }
    }
}