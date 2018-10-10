using System;

namespace MemberRegistry.view
{
    class EnterBoatDetails
    {
        private model.BoatType _type;
        private double _length;

        public void Display()
        {
            Console.Clear();

            Console.WriteLine("write the number of the boat type you would like to select");
            Console.WriteLine();

            for (int i = 0; i < Enum.GetNames(typeof(model.BoatType)).Length; i++)
            {
                Console.WriteLine(i + ") " + (model.BoatType)i);
            }

            Console.WriteLine();
            Console.Write("Boat type to select: ");
            _type = (model.BoatType)int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Length: ");
            _length = double.Parse(Console.ReadLine());
        }

        public model.BoatType GetBoatType()
        {
            return _type;
        }

        public double GetBoatLength()
        {
            return _length;
        }
    }
}