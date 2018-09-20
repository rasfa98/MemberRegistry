using System;

namespace MemberRegistry.controller
{
    class User
    {
        private view.Menu menu;
        private view.CreateMember createMember;

        public User()
        {
            menu = new view.Menu();
            createMember = new view.CreateMember();
        }

        public void initialize()
        {
            menu.Display();

            if (menu.UserWantsToCreateMember())
            {
                createMember.Display();
            }
        }
    }
}