using System;
using System.Collections.Generic;


namespace MemberRegistry.model
{
    class Registry
    {
        private Storage _storage;

        public Registry()
        {
            _storage = new Storage();
        }

        public int SelectedMemberIndex { get; set; }
        public int SelectedBoatIndex { get; set; }

        public void AddMember(string name, string personalNumber)
        {
            List<Member> existingMembers = _storage.ReadFile();

            Member newMember = new Member(Guid.NewGuid(), name, personalNumber);

            existingMembers.Add(newMember);

            _storage.WriteFile(existingMembers);
        }

        public void EditMember(string newName, string newPersonalNumber)
        {
            List<Member> existingMembers = _storage.ReadFile();

            Member memberToEdit = existingMembers[SelectedMemberIndex];

            memberToEdit.Name = newName;
            memberToEdit.PersonalNumber = newPersonalNumber;

            _storage.WriteFile(existingMembers);
        }

        public void DeleteMember()
        {
            List<Member> existingMembers = _storage.ReadFile();

            existingMembers.RemoveAt(SelectedMemberIndex);

            _storage.WriteFile(existingMembers);
        }

        public Member GetMember()
        {
            List<Member> existingMembers = _storage.ReadFile();

            return existingMembers[SelectedMemberIndex];
        }

        public List<Member> GetAllMembers()
        {
            return _storage.ReadFile();
        }

        public void AddBoat(BoatType type, double length)
        {
            List<Member> existingMembers = _storage.ReadFile();

            Member memberToAddBoat = existingMembers[SelectedMemberIndex];

            Boat newBoat = new Boat(type, length);

            memberToAddBoat.Boats.Add(newBoat);

            _storage.WriteFile(existingMembers);
        }

        public void EditBoat(BoatType newType, double newLength)
        {
            List<Member> existingMembers = _storage.ReadFile();

            Member memberToEdit = existingMembers[SelectedMemberIndex];
            Boat boatToEdit = memberToEdit.Boats[SelectedBoatIndex];

            boatToEdit.Type = newType;
            boatToEdit.Length = newLength;

            _storage.WriteFile(existingMembers);
        }

        public void DeleteBoat()
        {
            List<Member> existingMembers = _storage.ReadFile();

            Member memberToEdit = existingMembers[SelectedMemberIndex];

            memberToEdit.Boats.RemoveAt(SelectedBoatIndex);

            _storage.WriteFile(existingMembers);
        }
    }
}