using System;

namespace MemberRegistry.view
{
    class Menu
    {
        public void Display()
        {
            Console.Clear();

            Console.WriteLine("Welcome to MemberRegistry!");
            Console.WriteLine();
            Console.WriteLine("What would you like to do? (press the matching key on your keyboard)");
            Console.WriteLine();
            Console.WriteLine("1) Create member");
            Console.WriteLine("2) View member");
            Console.WriteLine("3) Edit member");
            Console.WriteLine("4) Delete member");
            Console.WriteLine("5) List all members");
            Console.WriteLine("6) Register boat");
            Console.WriteLine("7) Edit boat information");
            Console.WriteLine("8) Delete boat");
        }

        public ConsoleKey GetUserSelection()
        {
            return Console.ReadKey().Key;
        }
    }
}