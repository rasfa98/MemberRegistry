using System;

namespace MemberRegistry.view
{
    class EnterMemberDetails
    {
        private string _name;
        private string _personalNumber;

        public void Display()
        {
            Console.Clear();

            Console.Write("Name: ");
            _name = Console.ReadLine();

            Console.Write("Personal number: ");
            _personalNumber = Console.ReadLine();
        }

        public string GetName()
        {
            return _name;
        }

        public string GetPersonalNumber()
        {
            return _personalNumber;
        }
    }
}