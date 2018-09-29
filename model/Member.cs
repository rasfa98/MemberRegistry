using System;
using System.Collections.Generic;

namespace MemberRegistry.model
{
    class Member
    {
        private string _name;
        private string _personalNumber;

        public Member(Guid id, string name, string personalNumber)
        {
            Id = id;
            Name = name;
            PersonalNumber = personalNumber;
            Boats = new List<Boat>();
        }

        public Guid Id { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Please enter a name for the member.");
                }

                _name = value;
            }
        }

        public string PersonalNumber
        {
            get
            {
                return _personalNumber;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Please enter a personal number for the member.");
                }

                _personalNumber = value;
            }
        }
        public List<Boat> Boats { get; set; }
    }
}