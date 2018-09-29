using System;

namespace MemberRegistry.view
{
    class EnterBoatDetails
    {
        private string _type;
        private double _length;

        public void Display()
        {
            Console.Clear();

            Console.Write("Type: ");
            _type = Console.ReadLine();

            Console.Write("Length: ");
            _length = double.Parse(Console.ReadLine());
        }

        public string GetBoatType()
        {
            return _type;
        }

        public double GetBoatLength()
        {
            return _length;
        }
    }
}