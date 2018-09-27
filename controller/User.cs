using System;
using System.Collections.Generic;

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
        private view.SelectBoat selectBoat;
        private view.EditBoat editBoat;

        public User()
        {
            registry = new model.Registry();
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

        public void StartApplication()
        {
            while (true)
            {
                menu.Display();

                switch (menu.GetUserInput())
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
            createMember.Display();

            string name = createMember.GetName();
            string personalNumber = createMember.GetPersonalNumber();

            registry.AddMember(name, personalNumber);
        }

        private void HandleEditMember()
        {
            HandleSelectMember();
            editMember.Display();

            string newName = editMember.GetName();
            string newPersonalNumber = editMember.GetPersonalNumber();

            registry.EditMember(newName, newPersonalNumber);
        }

        private void HandleRegisterBoat()
        {
            HandleSelectMember();
            registerBoat.Display();

            string type = registerBoat.GetBoatType();
            double length = registerBoat.GetBoatLength();

            registry.AddBoat(type, length);
        }

        private void HandleListMembers()
        {
            ConsoleKey pressedKey = default(ConsoleKey);

            while (pressedKey != ConsoleKey.B)
            {
                List<model.Member> membersToList = registry.GetAllMembers();

                listMembers.Display(membersToList);

                pressedKey = listMembers.GetUserInput();

                switch (pressedKey)
                {
                    case ConsoleKey.T:
                        listMembers.ToggleListType();
                        break;
                }
            }
        }

        private void HandleDeleteMember()
        {
            HandleSelectMember();
            registry.DeleteMember();
        }

        private void HandleViewMember()
        {
            ConsoleKey pressedKey = default(ConsoleKey);

            HandleSelectMember();

            while (pressedKey != ConsoleKey.B)
            {
                model.Member memberToView = registry.GetMember();

                viewMember.Display(memberToView);

                pressedKey = viewMember.GetUserInput();
            }
        }

        private void HandleSelectBoat()
        {
            List<model.Boat> boatsToList = registry.GetMember().Boats;

            selectBoat.Display(boatsToList);

            int selectedBoatIndex = Convert.ToInt32(selectBoat.GetlSelectedBoatListIndex());

            registry.SelectedBoatId = boatsToList[selectedBoatIndex].Id;
        }

        private void HandleSelectMember()
        {
            List<model.Member> membersToList = registry.GetAllMembers();

            selectMember.Display(membersToList);

            int selectedMemberListIndex = Convert.ToInt32(selectMember.GetSelectedMemberListIndex());

            registry.SelectedMemberId = membersToList[selectedMemberListIndex].Id;
        }

        private void HandleEditBoat()
        {
            HandleSelectMember();
            HandleSelectBoat();
            editBoat.Display();

            string newType = editBoat.GetBoatType();
            double newLength = editBoat.GetBoatLength();

            registry.EditBoat(newType, newLength);
        }

        private void HandleDeleteBoat()
        {
            HandleSelectMember();
            HandleSelectBoat();
            registry.DeleteBoat();
        }

        private void HandleQuitApplication()
        {
            Console.Clear();
            Environment.Exit(0);
        }
    }
}