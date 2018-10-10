using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MemberRegistry.model
{
    class Storage
    {
        public List<Member> ReadFile()
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/data.json";

            string jsonFile = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<List<Member>>(jsonFile);
        }

        public void WriteFile(List<Member> existingMembers)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/data.json";

            string jsonFile = JsonConvert.SerializeObject(existingMembers, Formatting.Indented);

            File.WriteAllText(path, jsonFile);
        }
    }
}