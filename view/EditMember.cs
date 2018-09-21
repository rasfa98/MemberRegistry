using System;

namespace MemberRegistry.view
{
    class EditMember
    {
        public void Display()
        {
            Console.Clear();

            Console.WriteLine("Edit member");
            Console.WriteLine();

            Console.Write("New name: ");
            string name = Console.ReadLine();

            Console.Write("New personal number: ");
            string personalNumber = Console.ReadLine();
        }
    }
}