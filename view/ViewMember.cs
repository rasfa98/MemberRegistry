using System;

namespace MemberRegistry.view
{
    class ViewMember
    {
        private model.Registry registry;

        public ViewMember(model.Registry registry)
        {
            this.registry = registry;
        }

        public void Display()
        {
            model.Member member = registry.ViewMember();

            Console.Clear();

            Console.WriteLine("View member");
            Console.WriteLine();

            Console.WriteLine(member.Name + "    " + member.PersonalNumber + "    " + member.Id);

            Console.WriteLine();
            Console.WriteLine("B) Go back");
        }

        public ConsoleKey GetUserInput()
        {
            return Console.ReadKey().Key;
        }
    }
}