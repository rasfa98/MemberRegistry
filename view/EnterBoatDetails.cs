using System;

namespace MemberRegistry.view
{
    class EnterBoatDetails
    {
        private string type;
        private double length;

        public void Display()
        {
            Console.Clear();

            Console.WriteLine("Enter boat details");
            Console.WriteLine();

            Console.Write("Type: ");
            type = Console.ReadLine();

            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
        }

        public string GetBoatType()
        {
            return type;
        }

        public double GetBoatLength()
        {
            return length;
        }
    }
}