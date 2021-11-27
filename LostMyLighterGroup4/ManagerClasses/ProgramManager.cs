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
            User currentUser = User.GetUserById(_userActive);
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
                    User.AddLostLighter(currentUser);
                        break;
                    case 4:
                    currentUser.PrintUser();
                        break;
                    case 5:
                       // MethodChange.ChangeUserMethod(_userActive);

                        // Kod som skall in i submenyn
                         /*
                    bool delete = User.DeleteUser(_userActive);
                    _userActive = delete == true ? 0: _userActive;
                        */
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
                    MSMenu.SearchAndPrintMenu();
                    break;
                case 2:
                    //run create new marschall method or constructor
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
        //Konstruktor
       public ProgramManager()
        {

        }
    }
}
