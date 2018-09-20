using System;

namespace MemberRegistry.view
{
    class CreateMember
    {
        public void Display()
        {
            Console.Clear();

            Console.WriteLine("Create member");
            Console.WriteLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Personal number: ");
            string personalNumber = Console.ReadLine();

            // TODO: Save member to JSON file
        }
    }
}