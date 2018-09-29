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

        public ConsoleKey GetUserInput()
        {
            return Console.ReadKey().Key;
        }
    }
}