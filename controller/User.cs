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

                switch (_menu.GetUserInput())
                {
                    case ConsoleKey.D1:
                        HandleCreateMember();
                        break;
                    case ConsoleKey.D2:
                        HandleViewMember();
                        break;
                    case ConsoleKey.D3:
                        HandleEditMember();
                        break;
                    case ConsoleKey.D4:
                        HandleDeleteMember();
                        break;
                    case ConsoleKey.D5:
                        HandleListMembers();
                        break;
                    case ConsoleKey.D6:
                        HandleRegisterBoat();
                        break;
                    case ConsoleKey.D7:
                        HandleEditBoat();
                        break;
                    case ConsoleKey.D8:
                        HandleDeleteBoat();
                        break;
                    case ConsoleKey.Q:
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
            ConsoleKey pressedKey = default(ConsoleKey);

            while (pressedKey != ConsoleKey.B)
            {
                List<model.Member> membersToList = _registry.GetAllMembers();

                _listMembers.Display(membersToList);

                pressedKey = _listMembers.GetUserInput();

                switch (pressedKey)
                {
                    case ConsoleKey.T:
                        _listMembers.ToggleListType();
                        break;
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
            ConsoleKey pressedKey = default(ConsoleKey);

            SelectMember();

            while (pressedKey != ConsoleKey.B)
            {
                model.Member memberToView = _registry.GetMember();

                _viewMember.Display(memberToView);

                pressedKey = _viewMember.GetUserInput();
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
            List<model.Boat> boatsToList = _registry.GetMember().Boats;

            _selectMenu.Display(boatsToList);

            _registry.SelectedBoatIndex = int.Parse(_selectMenu.GetSelectedItemListIndex());
        }

        private void SelectMember()
        {
            List<model.Member> membersToList = _registry.GetAllMembers();

            _selectMenu.Display(membersToList);

            _registry.SelectedMemberIndex = int.Parse(_selectMenu.GetSelectedItemListIndex());
        }

        private void HandleQuitApplication()
        {
            Console.Clear();
            Environment.Exit(0);
        }
    }
}