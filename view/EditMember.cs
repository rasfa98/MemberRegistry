using System;

namespace MemberRegistry.view
{
    class EditMember
    {
        private string name;
        private string personalNumber;

        public void Display()
        {
            Console.Clear();

            Console.WriteLine("Edit member");
            Console.WriteLine();

            Console.Write("New name: ");
            name = Console.ReadLine();

            Console.Write("New personal number: ");
            personalNumber = Console.ReadLine();
        }

        public string GetName()
        {
            return name;
        }

        public string GetPersonalNumber()
        {
            return personalNumber;
        }
    }
}