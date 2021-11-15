using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LostMyLighterGroup4
{
    class ProgramManager
    {
        
        //Nån sorts metod för att avgjöra vilket meny som skall köras
        // User  ID=0 = standard??
        public void Presenter(int userActive)
        {
                    default:
                    //LoggedinUserChoice(LoggedInUserMenuObject.UserMenu("Name"));
                        break;
                    case 0:
                    //StandardUserChoice( standarMenuObject.MainMenu());
                        break;
        }
        //Kör metoder beroende på val från LoggedInMenu objekt
        public void LoggedinUserChoice(int selection)
        {
            MenuClasses.LoggedInMenu
            switch(selection)
            {
                case 1:
                    //run print active marschalls method
                    break;
                case 2:
                    //run search marschalls method
                    break;
                case 3:
                    //run create new marschall method
                    break;         
                case 4:
                    //run add lostlighter method
                    break;
                case 5:
                    // run print profile info method
                    break;
                case 6:
                    // run change user name method
                    break;
                case 7:
                    //run change age method
                    break;
                case 8:
                    //run change user adress method
                    break;
                case 0:
                    return;
            }
        }

        //Kör metoder beroende på output från StandardMenu objekt
        public void StandardUserChoice(int selection)
        {
            switch(selection)
            {
                case 1:
                    //run print active marschalls method
                    break;
                case 2:
                    //run create new marschall method or constructor
                    break;
                case 3:
                    // - Skall GetAllIDs vara objektbaserad eller static ??
                    //LogIn.CheckUser(ManagerClasses.UserManager.GetAllIDs());
                    break;
                case 4:
                    //create new user method or constructor
                    break;
                case 0:
                    return;
            }
            
        }
        //Konstruktor som samtidigt skapar nytt standarmeny-objekt och kör menymetoden, vet inte ifall vi skall göra så här       
       public ProgramManager()
        {
            MenuClasses.StandardMenu standard = new MenuClasses.StandardMenu();
            ManagerClasses.UserManager standardManager = new ManagerClasses.UserManager();
            new LogIn.DummyUser();
            standard.MainMenu();
        }

    }
}
