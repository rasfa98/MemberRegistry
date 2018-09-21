using System;

namespace MemberRegistry.model
{
    class Boat
    {
        public Boat(Guid id, string type, double length)
        {
            Id = id;
            Type = type;
            Length = length;
        }

        public Guid Id { get; set; }
        public string Type { get; set; }
        public double Length { get; set; }
    }
}