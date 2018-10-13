using System;

namespace MemberRegistry.view
{
    class Menu
    {
        public void Display()
        {
            Console.Clear();

            Console.WriteLine("The Jolly Pirate");
            Console.WriteLine();
            Console.WriteLine("Welcome to our member registry, press the number key that matches the desired action.");
            Console.WriteLine();
            Console.WriteLine("1) Create member");
            Console.WriteLine("2) View member");
            Console.WriteLine("3) Edit member");
            Console.WriteLine("4) Delete member");
            Console.WriteLine("5) List all members");
            Console.WriteLine("6) Register boat");
            Console.WriteLine("7) Edit boat");
            Console.WriteLine("8) Delete boat");
            Console.WriteLine();
            Console.WriteLine("Q) Quit");
        }

        public Event GetEvent()
        {
            ConsoleKey input = Console.ReadKey().Key;

            if (input == ConsoleKey.D1)
            {
                return Event.CreateMember;
            }
            else if (input == ConsoleKey.D2)
            {
                return Event.ViewMember;
            }
            else if (input == ConsoleKey.D3)
            {
                return Event.EditMember;
            }
            else if (input == ConsoleKey.D4)
            {
                return Event.DeleteMember;
            }
            else if (input == ConsoleKey.D5)
            {
                return Event.ListMembers;
            }
            else if (input == ConsoleKey.D6)
            {
                return Event.RegisterBoat;
            }
            else if (input == ConsoleKey.D7)
            {
                return Event.EditBoat;
            }
            else if (input == ConsoleKey.D8)
            {
                return Event.DeleteBoat;
            }
            else if (input == ConsoleKey.Q)
            {
                return Event.Quit;
            }

            return Event.None;
        }
    }
}