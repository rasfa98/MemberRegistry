using System;

namespace MemberRegistry.view
{
    class CreateMember : BaseView
    {
        private string name;
        private string personalNumber;

        public void Display()
        {
            Console.Clear();

            Console.WriteLine("Create member");
            Console.WriteLine();

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Personal number: ");
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