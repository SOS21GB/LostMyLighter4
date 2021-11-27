using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4.MenuClasses
{
    class LoggedInMenu
    {
        //Huvudmenyloop, returnerar int beroende på input
        public int UserMenu(string userName)
        {
            while (true)
            {
                //Console.Clear();
                Console.WriteLine("Hej {0}", userName);
                PrintMenu();
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        return int.Parse(userInput);
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Avslutar programmet. Hejdå.");
                        return 0;
                    default:
                        Console.Clear();
                        Console.WriteLine("Felaktig inmatning. Försök igen!");
                        SearchMenu.UserKeyPressToContinue();
                        break;
                }
            }
        }

        //Skriver ut huvudmenyn
        private void PrintMenu()
        {
            PrintSeparator();
            Console.WriteLine("Användarmeny".PadLeft(19));
            Console.WriteLine("1) Visa\\Sök marschaller.");
            Console.WriteLine("2) Registrera marschall.");
            PrintShortSeparator();
            Console.WriteLine("3) Anmäl borttappad tändare.");
            PrintShortSeparator();
            Console.WriteLine("4) Visa profil.");
            PrintShortSeparator();
            Console.WriteLine("Inställningar".PadLeft(19));
            Console.WriteLine("5) Byt namn.");
            Console.WriteLine("6) Ändra ålder.");
            Console.WriteLine("7) Ändra adress.");
            Console.WriteLine("8) Ta bort användarprofil.");
            Console.WriteLine("9) Logga ut");
            PrintShortSeparator();
            Console.WriteLine();
            Console.WriteLine("0) Avsluta programmet.");
            PrintSeparator();
            Console.Write("Ditt val: ");
        }


        #region Hjälpmetoder
        //Printar separatorer till menyn
        private void PrintShortSeparator()
        {
            Console.WriteLine("*----------------*".PadLeft(22));
        }
        private void PrintSeparator()
        {
            Console.WriteLine("*--------------------------*");
        }
        #endregion
    }
}
