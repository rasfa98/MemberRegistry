using System;

namespace MemberRegistry.controller
{
    class User
    {
        private view.Menu menu;
        private view.CreateMember createMember;
        private view.ViewMember viewMember;

        public User()
        {
            menu = new view.Menu();
            createMember = new view.CreateMember();
            viewMember = new view.ViewMember();
        }

        public void Initialize()
        {
            menu.Display();
            HandleMenuSelection();
        }

        private void HandleMenuSelection()
        {
            switch (menu.UserSelection())
            {
                case ConsoleKey.D1:
                    createMember.Display();
                    break;
                case ConsoleKey.D2:
                    viewMember.Display();
                    break;
            }
        }
    }
}