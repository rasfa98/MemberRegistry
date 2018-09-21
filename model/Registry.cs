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

        public void AddMember(Guid id, string name, string personalNumber)
        {
            string jsonFile = ReadFile();

            List<Member> existingMembers = JsonConvert.DeserializeObject<List<Member>>(jsonFile);

            Member newMember = new Member(id, name, personalNumber);

            existingMembers.Add(newMember);

            string existingMembersJson = JsonConvert.SerializeObject(existingMembers, Formatting.Indented);

            WriteFile(existingMembersJson);
        }

        public Member ViewMember()
        {
            string jsonFile = ReadFile();

            List<Member> existingMembers = JsonConvert.DeserializeObject<List<Member>>(jsonFile);

            return existingMembers.Where(member => member.Id == SelectedMemberId).ToList()[0];
        }

        public void EditMember(string newName, string NewPersonalNumber)
        {
            string jsonFile = ReadFile();

            List<Member> existingMembers = JsonConvert.DeserializeObject<List<Member>>(jsonFile);

            Member memberToEdit = existingMembers.Where(member => member.Id == SelectedMemberId).ToList()[0];

            memberToEdit.Name = newName;
            memberToEdit.PersonalNumber = NewPersonalNumber;

            string existingMembersJson = JsonConvert.SerializeObject(existingMembers, Formatting.Indented);

            WriteFile(existingMembersJson);
        }

        public void DeleteMember()
        {
            string jsonFile = ReadFile();

            List<Member> existingMembers = JsonConvert.DeserializeObject<List<Member>>(jsonFile);

            List<Member> modifiedList = existingMembers.Where(member => member.Id != SelectedMemberId).ToList();

            string modifiedListJson = JsonConvert.SerializeObject(modifiedList, Formatting.Indented);

            WriteFile(modifiedListJson);
        }

        public void AddBoat(Guid id, string type, double length)
        {
            string jsonFile = ReadFile();

            List<Member> existingMembers = JsonConvert.DeserializeObject<List<Member>>(jsonFile);

            Member memberToAddBoat = existingMembers.Where(member => member.Id == SelectedMemberId).ToList()[0];

            Boat newBoat = new Boat(id, type, length);

            memberToAddBoat.Boats.Add(newBoat);

            string existingMembersJson = JsonConvert.SerializeObject(existingMembers, Formatting.Indented);

            WriteFile(existingMembersJson);
        }

        public void EditBoat(string newType, double newLength)
        {
            string jsonFile = ReadFile();

            List<Member> existingMembers = JsonConvert.DeserializeObject<List<Member>>(jsonFile);

            Member memberToEdit = existingMembers.Where(member => member.Id == SelectedMemberId).ToList()[0];
            Boat boatToEdit = memberToEdit.Boats.Where(boat => boat.Id == SelectedBoatId).ToList()[0];

            boatToEdit.Type = newType;
            boatToEdit.Length = newLength;

            string existingMembersJson = JsonConvert.SerializeObject(existingMembers, Formatting.Indented);

            WriteFile(existingMembersJson);
        }

        public void DeleteBoat()
        {
            string jsonFile = ReadFile();

            List<Member> existingMembers = JsonConvert.DeserializeObject<List<Member>>(jsonFile);

            Member memberToEdit = existingMembers.Where(member => member.Id == SelectedMemberId).ToList()[0];
            memberToEdit.Boats = memberToEdit.Boats.Where(boat => boat.Id != SelectedBoatId).ToList();

            string existingMembersJson = JsonConvert.SerializeObject(existingMembers, Formatting.Indented);

            WriteFile(existingMembersJson);
        }

        public List<Member> ViewAll()
        {
            string jsonFile = ReadFile();
            return JsonConvert.DeserializeObject<List<Member>>(jsonFile);
        }

        private string ReadFile()
        {
            return File.ReadAllText("data.json");
        }

        private void WriteFile(string data)
        {
            File.WriteAllText("data.json", data);
        }
    }
}