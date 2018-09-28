using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace MemberRegistry.model
{
    class Registry
    {
        public Guid SelectedMemberId { get; set; }
        public Guid SelectedBoatId { get; set; }

        public void AddMember(string name, string personalNumber)
        {
            List<Member> existingMembers = ReadFile();

            Member newMember = new Member(Guid.NewGuid(), name, personalNumber);

            existingMembers.Add(newMember);

            WriteFile(existingMembers);
        }

        public void EditMember(string newName, string newPersonalNumber)
        {
            List<Member> existingMembers = ReadFile();

            Member memberToEdit = existingMembers.Where(member => member.Id == SelectedMemberId).ToList()[0];

            memberToEdit.Name = newName;
            memberToEdit.PersonalNumber = newPersonalNumber;

            WriteFile(existingMembers);
        }

        public void DeleteMember()
        {
            List<Member> existingMembers = ReadFile();

            List<Member> modifiedList = existingMembers.Where(member => member.Id != SelectedMemberId).ToList();

            WriteFile(modifiedList);
        }

        public Member GetMember()
        {
            List<Member> existingMembers = ReadFile();

            return existingMembers.Where(member => member.Id == SelectedMemberId).ToList()[0];
        }

        public List<Member> GetAllMembers()
        {
            return ReadFile();
        }

        public void AddBoat(string type, double length)
        {
            List<Member> existingMembers = ReadFile();

            Member memberToAddBoat = existingMembers.Where(member => member.Id == SelectedMemberId).ToList()[0];

            Boat newBoat = new Boat(Guid.NewGuid(), type, length);

            memberToAddBoat.Boats.Add(newBoat);

            WriteFile(existingMembers);
        }

        public void EditBoat(string newType, double newLength)
        {
            List<Member> existingMembers = ReadFile();

            Member memberToEdit = existingMembers.Where(member => member.Id == SelectedMemberId).ToList()[0];
            Boat boatToEdit = memberToEdit.Boats.Where(boat => boat.Id == SelectedBoatId).ToList()[0];

            boatToEdit.Type = newType;
            boatToEdit.Length = newLength;

            WriteFile(existingMembers);
        }

        public void DeleteBoat()
        {
            List<Member> existingMembers = ReadFile();

            Member memberToEdit = existingMembers.Where(member => member.Id == SelectedMemberId).ToList()[0];
            memberToEdit.Boats = memberToEdit.Boats.Where(boat => boat.Id != SelectedBoatId).ToList();

            WriteFile(existingMembers);
        }

        private List<Member> ReadFile()
        {
            string jsonFile = File.ReadAllText("data.json");

            return JsonConvert.DeserializeObject<List<Member>>(jsonFile);
        }

        private void WriteFile(List<Member> data)
        {
            string jsonFile = JsonConvert.SerializeObject(data, Formatting.Indented);

            File.WriteAllText("data.json", jsonFile);
        }
    }
}