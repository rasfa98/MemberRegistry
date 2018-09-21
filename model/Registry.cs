using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace MemberRegistry.model
{
    class Registry
    {
        public void AddMember(string name, string personalNumber)
        {
            string jsonFile = ReadFile();

            List<Member> existingMembers = JsonConvert.DeserializeObject<List<Member>>(jsonFile);

            Member newMember = new Member(name, personalNumber);

            existingMembers.Add(newMember);

            string existingMembersJson = JsonConvert.SerializeObject(existingMembers, Formatting.Indented);

            WriteFile(existingMembersJson);
        }

        public Member ViewMember(Guid memberId)
        {
            string jsonFile = ReadFile();

            List<Member> existingMembers = JsonConvert.DeserializeObject<List<Member>>(jsonFile);

            return existingMembers.Where(member => member.Id == memberId).ToList()[0];
        }

        public void EditMember(Guid memberId, string newName, string NewPersonalNumber)
        {
            // TODO: Edit members information
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