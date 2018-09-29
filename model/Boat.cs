using System;

namespace MemberRegistry.model
{
    class Boat
    {
        private string _type;
        private double _length;

        public Boat(Guid id, string type, double length)
        {
            Id = id;
            Type = type;
            Length = length;
        }

        public Guid Id { get; set; }

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Please enter a type for the boat.");
                }

                _type = value;
            }
        }

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