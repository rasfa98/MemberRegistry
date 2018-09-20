using System;

namespace MemberRegistry.view
{
    class CreateMember
    {
        private model.Registry registry;

        public CreateMember()
        {
            registry = new model.Registry();
        }

        public void Display()
        {
            Console.Clear();

            Console.WriteLine("Create member");
            Console.WriteLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Personal number: ");
            string personalNumber = Console.ReadLine();

            registry.AddMember(name, personalNumber);
        }
    }
}