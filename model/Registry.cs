using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MemberRegistry.model
{
    class Registry
    {
        public int SelectedMemberIndex { get; set; }
        public int SelectedBoatIndex { get; set; }

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

            Member memberToEdit = existingMembers[SelectedMemberIndex];

            memberToEdit.Name = newName;
            memberToEdit.PersonalNumber = newPersonalNumber;

            WriteFile(existingMembers);
        }

        public void DeleteMember()
        {
            List<Member> existingMembers = ReadFile();

            existingMembers.RemoveAt(SelectedMemberIndex);

            WriteFile(existingMembers);
        }

        public Member GetMember()
        {
            List<Member> existingMembers = ReadFile();

            return existingMembers[SelectedMemberIndex];
        }

        public List<Member> GetAllMembers()
        {
            return ReadFile();
        }

        public void AddBoat(string type, double length)
        {
            List<Member> existingMembers = ReadFile();

            Member memberToAddBoat = existingMembers[SelectedMemberIndex];

            Boat newBoat = new Boat(type, length);

            memberToAddBoat.Boats.Add(newBoat);

            WriteFile(existingMembers);
        }

        public void EditBoat(string newType, double newLength)
        {
            List<Member> existingMembers = ReadFile();

            Member memberToEdit = existingMembers[SelectedMemberIndex];
            Boat boatToEdit = memberToEdit.Boats[SelectedBoatIndex];

            boatToEdit.Type = newType;
            boatToEdit.Length = newLength;

            WriteFile(existingMembers);
        }

        public void DeleteBoat()
        {
            List<Member> existingMembers = ReadFile();

            Member memberToEdit = existingMembers[SelectedMemberIndex];

            memberToEdit.Boats.RemoveAt(SelectedBoatIndex);

            WriteFile(existingMembers);
        }

        private List<Member> ReadFile()
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/data.json";

            string jsonFile = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<List<Member>>(jsonFile);
        }

        private void WriteFile(List<Member> existingMembers)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/data.json";

            string jsonFile = JsonConvert.SerializeObject(existingMembers, Formatting.Indented);

            File.WriteAllText(path, jsonFile);
        }
    }
}