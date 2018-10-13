using System;
using System.Collections.Generic;

namespace MemberRegistry.controller
{
    class User
    {
        private model.Registry _registry;
        private view.Menu _menu;
        private view.EnterMemberDetails _enterMemberDetails;
        private view.ViewMember _viewMember;
        private view.SelectMenu _selectMenu;
        private view.ListMembers _listMembers;
        private view.EnterBoatDetails _enterBoatDetails;

        public User()
        {
            _registry = new model.Registry();
            _menu = new view.Menu();
            _enterMemberDetails = new view.EnterMemberDetails();
            _viewMember = new view.ViewMember();
            _listMembers = new view.ListMembers();
            _enterBoatDetails = new view.EnterBoatDetails();
            _selectMenu = new view.SelectMenu();
        }

        public void StartApplication()
        {
            while (true)
            {
                _menu.Display();

                switch (_menu.GetEvent())
                {
                    case view.Event.CreateMember:
                        HandleCreateMember();
                        break;
                    case view.Event.ViewMember:
                        HandleViewMember();
                        break;
                    case view.Event.EditMember:
                        HandleEditMember();
                        break;
                    case view.Event.DeleteMember:
                        HandleDeleteMember();
                        break;
                    case view.Event.ListMembers:
                        HandleListMembers();
                        break;
                    case view.Event.RegisterBoat:
                        HandleRegisterBoat();
                        break;
                    case view.Event.EditBoat:
                        HandleEditBoat();
                        break;
                    case view.Event.DeleteBoat:
                        HandleDeleteBoat();
                        break;
                    case view.Event.Quit:
                        HandleQuitApplication();
                        break;
                }
            }
        }

        private void HandleCreateMember()
        {
            _enterMemberDetails.Display();

            string name = _enterMemberDetails.GetName();
            string personalNumber = _enterMemberDetails.GetPersonalNumber();

            _registry.AddMember(name, personalNumber);
        }

        private void HandleEditMember()
        {
            SelectMember();
            _enterMemberDetails.Display();

            string newName = _enterMemberDetails.GetName();
            string newPersonalNumber = _enterMemberDetails.GetPersonalNumber();

            _registry.EditMember(newName, newPersonalNumber);
        }

        private void HandleListMembers()
        {
            view.Event e = view.Event.None;

            while (e != view.Event.GoBack)
            {
                _listMembers.Display(_registry.GetAllMembers());

                e = _listMembers.GetEvent();

                if (e == view.Event.ToggleList)
                {
                    _listMembers.ToggleListType();
                }
            }
        }

        private void HandleDeleteMember()
        {
            SelectMember();
            _registry.DeleteMember();
        }

        private void HandleViewMember()
        {
            view.Event e = view.Event.None;

            SelectMember();

            while (e != view.Event.GoBack)
            {
                _viewMember.Display(_registry.GetMember());

                e = _viewMember.GetEvent();
            }
        }

        private void HandleRegisterBoat()
        {
            SelectMember();
            _enterBoatDetails.Display();

            _registry.AddBoat(_enterBoatDetails.GetBoatType(), _enterBoatDetails.GetBoatLength());
        }

        private void HandleEditBoat()
        {
            SelectMember();
            SelectBoat();
            _enterBoatDetails.Display();

            _registry.EditBoat(_enterBoatDetails.GetBoatType(), _enterBoatDetails.GetBoatLength());
        }

        private void HandleDeleteBoat()
        {
            SelectMember();
            SelectBoat();
            _registry.DeleteBoat();
        }

        private void SelectBoat()
        {
            _selectMenu.Display(_registry.GetMember().Boats);

            _registry.SelectedBoatIndex = int.Parse(_selectMenu.GetSelectedItemListIndex());
        }

        private void SelectMember()
        {
            _selectMenu.Display(_registry.GetAllMembers());

            _registry.SelectedMemberIndex = int.Parse(_selectMenu.GetSelectedItemListIndex());
        }

        private void HandleQuitApplication()
        {
            Console.Clear();
            Environment.Exit(0);
        }
    }
}