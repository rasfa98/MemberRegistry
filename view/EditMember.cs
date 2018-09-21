using System;

namespace MemberRegistry.view
{
    class EditMember
    {
        private model.Registry registry;

        public EditMember(model.Registry registry)
        {
            this.registry = registry;
        }

        public void Display()
        {
            Console.Clear();

            Console.WriteLine("Edit member");
            Console.WriteLine();

            Console.Write("New name: ");
            string name = Console.ReadLine();

            Console.Write("New personal number: ");
            string personalNumber = Console.ReadLine();

            registry.EditMember(name, personalNumber);
        }
    }
}