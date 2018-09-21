using System;

namespace MemberRegistry.controller
{
    class User
    {
        private view.Menu menu;
        private view.CreateMember createMember;
        private view.ViewMember viewMember;
        private view.EditMember editMember;

        public User()
        {
            menu = new view.Menu();
            createMember = new view.CreateMember();
            viewMember = new view.ViewMember();
            editMember = new view.EditMember();
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
                case ConsoleKey.D3:
                    editMember.Display();
                    break;
            }
        }
    }
}