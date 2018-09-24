using System;

namespace MemberRegistry.view
{
    class EditBoat
    {
        private string type;
        private double length;

        public void Display()
        {
            Console.Clear();

            Console.WriteLine("Edit boat");
            Console.WriteLine();

            Console.Write("New type: ");
            type = Console.ReadLine();

            Console.Write("New length: ");
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