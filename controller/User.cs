using System;

namespace MemberRegistry.controller
{
    class User
    {
        private model.Registry registry;
        private view.Menu menu;
        private view.CreateMember createMember;
        private view.ViewMember viewMember;
        private view.EditMember editMember;
        private view.SelectMember selectMember;

        public User()
        {
            registry = new model.Registry();
            menu = new view.Menu();
            createMember = new view.CreateMember(registry);
            viewMember = new view.ViewMember(registry);
            editMember = new view.EditMember(registry);
            selectMember = new view.SelectMember(registry);
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
                    selectMember.Display();
                    selectMember.SaveSelectedMemberId();
                    viewMember.Display();
                    break;
                case ConsoleKey.D3:
                    selectMember.Display();
                    selectMember.SaveSelectedMemberId();
                    editMember.Display();
                    break;
            }
        }
    }
}