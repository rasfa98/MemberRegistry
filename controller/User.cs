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
        private view.ListMembers listMembers;
        private view.RegisterBoat registerBoat;

        public User()
        {
            registry = new model.Registry();
            menu = new view.Menu();
            createMember = new view.CreateMember(registry);
            viewMember = new view.ViewMember(registry);
            editMember = new view.EditMember(registry);
            selectMember = new view.SelectMember(registry);
            listMembers = new view.ListMembers(registry);
            registerBoat = new view.RegisterBoat(registry);
        }

        public void Initialize()
        {
            while (true)
            {
                menu.Display();
                HandleMenuSelection();
            }
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
                case ConsoleKey.D4:
                    selectMember.Display();
                    selectMember.SaveSelectedMemberId();
                    registry.DeleteMember();
                    break;
                case ConsoleKey.D5:
                    HandleListMembers();
                    break;
                case ConsoleKey.D6:
                    selectMember.Display();
                    selectMember.SaveSelectedMemberId();
                    registerBoat.Display();
                    break;
            }
        }

        public void HandleListMembers()
        {
            while (true)
            {
                listMembers.Display();

                switch (listMembers.GetUserInput())
                {
                    case ConsoleKey.T:
                        listMembers.ToggleListType();
                        break;
                }
            }
        }
    }
}