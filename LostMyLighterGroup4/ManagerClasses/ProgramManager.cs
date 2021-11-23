using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LostMyLighterGroup4
{
    class ProgramManager
    {
        private int _userActive;
        //Nån sorts metod för att avgjöra vilket meny som skall köras
        // User  ID=0 = standard??
        public void Presenter()
        {
            switch (_userActive)
            {
                default:
                    //LoggedinUserChoice(LoggedInUserMenuObject.UserMenu("userObjectlist[_userActive].Name"));
                    break;
                case 0:
                    //StandardUserChoice( standarMenuObject.MainMenu());
                    break;
            }
        }
        //Kör metoder beroende på val från LoggedInMenu objekt
        public void LoggedinUserChoice(int selection)
        {

                switch (selection)
                {
                    case 1:
                        //run marschalls menu
                        break;
                    case 2:
                        //run create new marschall method
                        break;
                    case 3:
                        //run add lostlighter method
                        break;
                    case 4:
                        // run print profile info method
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
                    //run marschalls menu
                    break;
                case 2:
                    //run create new marschall method or constructor
                    break;
                case 3:
                    // -> saknas lista på userID:n
                    // _userActive = LogIn.CheckUser(userIdList);
                    break;
                case 4:
                    //create new user method or constructor
                    break;
                case 0:
                    return;
            }
            Presenter();
        }
        //Konstruktor som samtidigt skapar nytt standarmeny-objekt och kör menymetoden, vet inte ifall vi skall göra så här       
       public ProgramManager()
        {

        }

    }
}
