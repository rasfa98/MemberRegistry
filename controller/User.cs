using System;
using System.Collections.Generic;

namespace MemberRegistry.controller
{
    class User
    {
        private model.Registry registry;
        private view.Menu menu;
        private view.EnterMemberDetails enterMemberDetails;
        private view.ViewMember viewMember;
        private view.SelectMember selectMember;
        private view.ListMembers listMembers;
        private view.EnterBoatDetails enterBoatDetails;
        private view.SelectBoat selectBoat;

        public User()
        {
            registry = new model.Registry();
            menu = new view.Menu();
            enterMemberDetails = new view.EnterMemberDetails();
            viewMember = new view.ViewMember();
            selectMember = new view.SelectMember();
            listMembers = new view.ListMembers();
            enterBoatDetails = new view.EnterBoatDetails();
            selectBoat = new view.SelectBoat();
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
            enterMemberDetails.Display();

            string name = enterMemberDetails.GetName();
            string personalNumber = enterMemberDetails.GetPersonalNumber();

            registry.AddMember(name, personalNumber);
        }

        private void HandleEditMember()
        {
            SelectMember();
            enterMemberDetails.Display();

            string newName = enterMemberDetails.GetName();
            string newPersonalNumber = enterMemberDetails.GetPersonalNumber();

            registry.EditMember(newName, newPersonalNumber);
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
            SelectMember();
            registry.DeleteMember();
        }

        private void HandleViewMember()
        {
            ConsoleKey pressedKey = default(ConsoleKey);

            SelectMember();

            while (pressedKey != ConsoleKey.B)
            {
                model.Member memberToView = registry.GetMember();

                viewMember.Display(memberToView);

                pressedKey = viewMember.GetUserInput();
            }
        }

        private void HandleRegisterBoat()
        {
            SelectMember();
            enterBoatDetails.Display();

            string type = enterBoatDetails.GetBoatType();
            double length = enterBoatDetails.GetBoatLength();

            registry.AddBoat(type, length);
        }

        private void HandleEditBoat()
        {
            SelectMember();
            SelectBoat();
            enterBoatDetails.Display();

            string newType = enterBoatDetails.GetBoatType();
            double newLength = enterBoatDetails.GetBoatLength();

            registry.EditBoat(newType, newLength);
        }

        private void HandleDeleteBoat()
        {
            SelectMember();
            SelectBoat();
            registry.DeleteBoat();
        }

        private void SelectBoat()
        {
            List<model.Boat> boatsToList = registry.GetMember().Boats;

            selectBoat.Display(boatsToList);

            int selectedBoatIndex = Convert.ToInt32(selectBoat.GetlSelectedBoatListIndex());

            registry.SelectedBoatId = boatsToList[selectedBoatIndex].Id;
        }

        private void SelectMember()
        {
            List<model.Member> membersToList = registry.GetAllMembers();

            selectMember.Display(membersToList);

            int selectedMemberListIndex = Convert.ToInt32(selectMember.GetSelectedMemberListIndex());

            registry.SelectedMemberId = membersToList[selectedMemberListIndex].Id;
        }

        private void HandleQuitApplication()
        {
            Console.Clear();
            Environment.Exit(0);
        }
    }
}