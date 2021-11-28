using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LostMyLighterGroup4
{
    class ProgramManager
    {
        MenuClasses.LoggedInMenu lMenu = new ();
        MenuClasses.StandardMenu stMenu = new ();
        private static int _userActive;

        //Huvudfunktion. kallar på
        public void Presenter()
        {
            Console.Clear();

            if(_userActive == 0)
            {
                StandardUserChoice(stMenu.MainMenu());
            }
            else
            {
                User currentUser = User.GetUserById(_userActive);
                LoggedinUserChoice(lMenu.UserMenu(currentUser));
            }
        }

        //Kör metoder beroende på val från LoggedInMenu objekt
        public void LoggedinUserChoice(int selection)
        {
            User currentUser = User.GetUserById(_userActive);
            switch (selection)
                {
                    case 1:
                        Console.Clear();
                        MenuClasses.SearchMenu MSMenu = new MenuClasses.SearchMenu();
                        MSMenu.SearchAndPrintMenu(currentUser);
                        break;
                    case 2:
                        CreateMarschall.CreateMarschalls();
                    currentUser.RegisteredMarschalls++;
                        break;
                    case 3:
                        User.AddLostLighter(currentUser);
                        break;
                    case 4:
                        currentUser.PrintUser();
                        break;
                    case 5:
                        ChangeUser.ChangeUserMethod(_userActive);
                        if (User.GetUserById(_userActive) == null)
                        {
                            _userActive = 0;
                            Console.WriteLine("Användare borttagen. Du loggas ut.");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Du loggas ut");
                        MenuClasses.SearchMenu.UserKeyPressToContinue();
                        _userActive = 0;
                        break;
                    case 0:
                        return;
                }
            Presenter();
        }

        //Kör metoder beroende på output från StandardMenu objekt
        public void StandardUserChoice(int selection)
        {
            switch(selection)
            {
                case 1:
                    Console.Clear();
                    MenuClasses.SearchMenu MSMenu = new MenuClasses.SearchMenu();
                    MSMenu.SearchAndPrintMenu(null);
                    break;
                case 2:
                    CreateMarschall.CreateMarschalls();
                    break;
                case 3:
                    Console.Clear();
                    _userActive = LogIn.LogIn.CheckUser(User.UserIDList());
                    break;
                case 4:
                    Console.Clear();
                    InputUser.UserCreate();
                    break;
                case 0:
                    return;
            }
            Presenter();
        }
    }
}
