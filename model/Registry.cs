using System;
using System.Collections.Generic;
using System.IO;
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

        private string ReadFile()
        {
            return File.ReadAllText("data.json");
        }

        public void WriteFile(string data)
        {
            File.WriteAllText("data.json", data);
        }
    }
}