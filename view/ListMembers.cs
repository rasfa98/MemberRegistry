using System;
using System.Collections.Generic;

namespace MemberRegistry.view
{
    class ListMembers
    {
        private model.Registry registry;
        private bool compactList;

        public ListMembers(model.Registry registry)
        {
            this.registry = registry;
            compactList = true;
        }

        public void Display()
        {
            List<model.Member> members = registry.ViewAll();

            Console.Clear();

            Console.WriteLine("List members");
            Console.WriteLine();

            foreach (model.Member member in members)
            {
                if (compactList)
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
            compactList = !compactList;
        }

        public ConsoleKey GetUserInput()
        {
            return Console.ReadKey().Key;
        }
    }
}