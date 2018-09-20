using System;
using System.Collections.Generic;

namespace MemberRegistry.model
{
    class Member
    {
        private Guid id;
        private string name;
        private string personalNumber;
        private List<Boat> boats;

        public Member(string name, string personalNumber)
        {
            this.id = Guid.NewGuid();
            this.name = name;
            this.personalNumber = personalNumber;
            this.boats = new List<Boat>();
        }

        public Guid Id { get { return id; } }
        public string Name { get { return name; } }
        public string PersonalNumber { get { return personalNumber; } }
        public List<Boat> Boats { get { return boats; } }
    }
}