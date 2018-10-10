using System;

namespace MemberRegistry.model
{
    class Boat
    {
        private BoatType _type;
        private double _length;

        public Boat(BoatType type, double length)
        {
            Type = type;
            Length = length;
        }

        public BoatType Type { get; set; }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Please enter a length for the boat.");
                }

                _length = value;
            }
        }
    }
}