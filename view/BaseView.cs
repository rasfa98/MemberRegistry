namespace MemberRegistry.view
{
    class BaseView
    {
        public view.Menu menu { get; set; }
        public view.CreateMember createMember { get; set; }
        public view.ViewMember viewMember { get; set; }
        public view.EditMember editMember { get; set; }
        public view.SelectMember selectMember { get; set; }
        public view.ListMembers listMembers { get; set; }
        public view.RegisterBoat registerBoat { get; set; }
        public view.SelectBoat selectBoat { get; set; }
        public view.EditBoat editBoat { get; set; }

        public BaseView()
        {
            menu = new view.Menu();
            createMember = new view.CreateMember();
            viewMember = new view.ViewMember();
            editMember = new view.EditMember();
            selectMember = new view.SelectMember();
            listMembers = new view.ListMembers();
            registerBoat = new view.RegisterBoat();
            selectBoat = new view.SelectBoat();
            editBoat = new view.EditBoat();
        }
    }
}