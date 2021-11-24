using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LostMyLighterGroup4
{
    class ProgramManager
    {
        //Behålla dessa här eller ta bort?

        MenuClasses.LoggedInMenu lMenu = new MenuClasses.LoggedInMenu();
        MenuClasses.StandardMenu stMenu = new MenuClasses.StandardMenu();
        private static int _userActive;
        
        public void Presenter()
        {
            Console.Clear();
            switch (_userActive)
            {
                
                default:
                    User currentUser = User.GetUserById(_userActive);
                    LoggedinUserChoice(lMenu.UserMenu(currentUser.Name));
                    break;
                case 0:
                    StandardUserChoice(stMenu.MainMenu());
                    break;
            }
        }
        //Kör metoder beroende på val från LoggedInMenu objekt
        public void LoggedinUserChoice(int selection)
        {

                switch (selection)
                {
                    case 1:
                    Console.Clear();
                    MenuClasses.SearchMenu MSMenu = new MenuClasses.SearchMenu();
                    MSMenu.SearchAndPrintMenu();
                        break;
                    case 2:
                        //run create new marschall method
                        break;
                    case 3:
                        //run add lostlighter method
                        break;
                    case 4:
                    User currentUser = User.GetUserById(_userActive);
                    currentUser.PrintUser();
                        break;
                    case 5:
                        // run change user name method
                        break;
                    case 6:
                        //run change age method
                        break;
                    case 7:
                        //run change user adress method
                        break;
                    case 8:
                    Console.WriteLine("Du loggas ut");
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
                    MSMenu.SearchAndPrintMenu();
                    break;
                case 2:
                    //run create new marschall method or constructor
                    break;
                case 3:
                    _userActive = LogIn.LogIn.CheckUser(User.UserIDList());
                    break;
                case 4:
                    //create new user method or constructor
                    break;
                case 0:
                    return;
            }
            Presenter();
        }
        //Konstruktor
       public ProgramManager()
        {

        }
    }
}
