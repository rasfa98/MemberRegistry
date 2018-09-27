using System;
using System.Collections.Generic;

namespace MemberRegistry.view
{
    class SelectMember
    {
        public void Display(List<model.Member> membersToList)
        {
            Console.Clear();

            Console.WriteLine("Select a member");
            Console.WriteLine();
            Console.WriteLine("(write the number of the member you would like to select)");
            Console.WriteLine();

            for (int i = 0; i < membersToList.Count; i++)
            {
                Console.WriteLine(i + ") " + membersToList[i].Name + "    " + membersToList[i].PersonalNumber + "    " + membersToList[i].Id);
            }

            Console.WriteLine();
            Console.Write("Member to select: ");
        }

        public string GetSelectedMemberListIndex()
        {
            return Console.ReadLine();
        }
    }
}