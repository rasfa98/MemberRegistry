using System;
using System.Collections.Generic;

namespace MemberRegistry.controller
{
    class User
    {
        private view.BaseView baseView;
        private model.Registry registry;

        public User()
        {
            baseView = new view.BaseView();
            registry = new model.Registry();
        }

        public void Initialize()
        {
            while (true)
            {
                try
                {
                    baseView.menu.Display();
                    HandleMenuSelection();
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        private void HandleMenuSelection()
        {
            switch (baseView.menu.GetUserSelection())
            {
                case ConsoleKey.D1:
                    baseView.createMember.Display();

                    string name = baseView.createMember.GetName();
                    string personalNumber = baseView.createMember.GetPersonalNumber();

                    registry.AddMember(Guid.NewGuid(), name, personalNumber);
                    break;
                case ConsoleKey.D2:
                    HandleViewMember();
                    break;
                case ConsoleKey.D3:
                    HandleSelectMember();
                    baseView.editMember.Display();

                    string newName = baseView.editMember.GetName();
                    string newPersonalNumber = baseView.editMember.GetPersonalNumber();

                    registry.EditMember(newName, newPersonalNumber);
                    break;
                case ConsoleKey.D4:
                    HandleSelectMember();
                    registry.DeleteMember();
                    break;
                case ConsoleKey.D5:
                    HandleListMembers();
                    break;
                case ConsoleKey.D6:
                    HandleSelectMember();
                    baseView.registerBoat.Display();

                    string type = baseView.registerBoat.GetBoatType();
                    double length = baseView.registerBoat.GetBoatLength();

                    registry.AddBoat(Guid.NewGuid(), type, length);
                    break;
                case ConsoleKey.D7:
                    HandleSelectMember();
                    HandleSelectBoat();
                    baseView.editBoat.Display();

                    string newType = baseView.editBoat.GetBoatType();
                    double newLength = baseView.editBoat.GetBoatLength();

                    registry.EditBoat(newType, newLength);
                    break;
                case ConsoleKey.D8:
                    HandleSelectMember();
                    HandleSelectBoat();
                    registry.DeleteBoat();
                    break;
                case ConsoleKey.Q:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
        }

        private void HandleListMembers()
        {
            ConsoleKey pressedKey = default(ConsoleKey);

            while (pressedKey != ConsoleKey.B)
            {
                List<model.Member> membersToList = registry.ViewAll();

                baseView.listMembers.Display(membersToList);

                pressedKey = baseView.listMembers.GetUserInput();

                switch (pressedKey)
                {
                    case ConsoleKey.T:
                        baseView.listMembers.ToggleListType();
                        break;
                }
            }
        }

        private void HandleViewMember()
        {
            ConsoleKey pressedKey = default(ConsoleKey);

            HandleSelectMember();

            while (pressedKey != ConsoleKey.B)
            {
                model.Member memberToView = registry.ViewMember();

                baseView.viewMember.Display(memberToView);

                pressedKey = baseView.viewMember.GetUserInput();
            }
        }

        private void HandleSelectBoat()
        {
            List<model.Boat> boatsToList = registry.ViewMember().Boats;

            baseView.selectBoat.Display(boatsToList);

            int selectedBoatIndex = baseView.selectBoat.GetlSelectedBoatListIndex();

            registry.SelectedBoatId = boatsToList[selectedBoatIndex].Id;
        }

        private void HandleSelectMember()
        {
            List<model.Member> membersToList = registry.ViewAll();

            baseView.selectMember.Display(membersToList);

            int selectedMemberListIndex = baseView.selectMember.GetSelectedMemberListIndex();

            registry.SelectedMemberId = membersToList[selectedMemberListIndex].Id;
        }
    }
}