using System;
using System.Collections.Generic;

namespace MemberRegistry.view
{
    class SelectMember
    {
        private model.Registry registry;
        private List<model.Member> members;

        public SelectMember(model.Registry registry)
        {
            this.registry = registry;
        }
        public void Display()
        {
            Console.Clear();

            members = registry.ViewAll();

            Console.WriteLine("Select a member");
            Console.WriteLine("");

            for (int i = 0; i < members.Count; i++)
            {
                Console.WriteLine(i + ") " + members[i].Name + "    " + members[i].PersonalNumber + "    " + members[i].Id);
            }
        }

        public void SaveSelectedMemberId()
        {
            Console.WriteLine();
            Console.Write("Member to select: ");

            int memberListIndex = Convert.ToInt32(Console.ReadLine());

            registry.SelectedMemberId = members[memberListIndex].Id;
        }
    }
}