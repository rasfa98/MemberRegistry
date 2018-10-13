using System;

namespace MemberRegistry.view
{
    class ViewMember
    {
        public void Display(model.Member memberToView)
        {
            Console.Clear();

            Console.WriteLine(memberToView.Name + "    " + memberToView.PersonalNumber + "    " + memberToView.Id);

            if (memberToView.Boats.Count > 0)
            {
                foreach (model.Boat boat in memberToView.Boats)
                {
                    Console.WriteLine("    " + boat.Type + "    " + boat.Length);
                }
            }

            Console.WriteLine();
            Console.WriteLine("B) Go back");
        }

        public Event GetEvent()
        {
            if (Console.ReadKey().Key == ConsoleKey.B)
            {
                return Event.GoBack;
            }

            return Event.None;
        }
    }
}