using System;

namespace MemberRegistry.view
{
    class CreateMember
    {
        private model.Registry registry;

        public CreateMember(model.Registry registry)
        {
            this.registry = registry;
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

            registry.AddMember(Guid.NewGuid(), name, personalNumber);
        }
    }
}