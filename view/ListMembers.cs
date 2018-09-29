using System;
using System.Collections.Generic;

namespace MemberRegistry.view
{
    class ListMembers
    {
        private bool _compactList;

        public ListMembers()
        {
            _compactList = true;
        }

        public void Display(List<model.Member> membersToList)
        {
            Console.Clear();

            foreach (model.Member member in membersToList)
            {
                if (_compactList)
                {
                    Console.WriteLine(member.Name + "    " + member.Id + "    " + member.Boats.Count);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(member.Name + "    " + member.PersonalNumber + "    " + member.Id);

                    if (member.Boats.Count > 0)
                    {
                        foreach (model.Boat boat in member.Boats)
                        {
                            Console.WriteLine("    " + boat.Type + "    " + boat.Length);
                        }
                    }

                    Console.WriteLine();
                }
            }

            Console.WriteLine("T) Toggle list type    B) Go back");
        }

        public void ToggleListType()
        {
            _compactList = !_compactList;
        }

        public ConsoleKey GetUserInput()
        {
            return Console.ReadKey().Key;
        }
    }
}