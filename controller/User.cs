namespace MemberRegistry.controller
{
    class User
    {
        private view.Menu menu;

        public User()
        {
            menu = new view.Menu();
        }

        public void initialize()
        {
            menu.Display();
        }
    }
}