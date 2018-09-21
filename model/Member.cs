using System;
using System.Collections.Generic;

namespace MemberRegistry.model
{
    class Member
    {
        public Member(Guid id, string name, string personalNumber)
        {
            Id = id;
            Name = name;
            PersonalNumber = personalNumber;
            Boats = new List<Boat>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PersonalNumber { get; set; }
        public List<Boat> Boats { get; set; }
    }
}